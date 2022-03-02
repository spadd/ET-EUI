using System;

namespace ET
{
    public class C2G_EnterGameHandler : AMRpcHandler<C2G_EnterGame,G2C_EnterGame>
    {
        protected override async ETTask Run(Session session, C2G_EnterGame request, G2C_EnterGame response, Action reply)
        {
            if (session.DomainScene().SceneType != SceneType.Gate)
            {
                Log.Error($"请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
                session.Dispose();
                return;
            }
            
            if (session.GetComponent<SessionLockingComponent>() != null)
            {
                response.Error = ErrorCode.RequestRepeatedly;
                reply();
                return;
            }

            SessionPlayerComponent sessionPlayerComponent = session.GetComponent<SessionPlayerComponent>();
            if (null == sessionPlayerComponent)
            {
                response.Error = ErrorCode.Err_SessionPlayError;
                reply();
                return;
            }

            Player player = Game.EventSystem.Get(sessionPlayerComponent.PlayerInstanceId) as Player;
            if (player == null || player.IsDisposed)
            {
                response.Error = ErrorCode.Err_NonePlayerError;
                reply();
                return;
            }

            long instanceId = session.InstanceId;
            using (session.AddComponent<SessionLockingComponent>())
            {
                using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginGate,player.Account.GetHashCode()))
                {
                    // 防止连接断开 二次执行 的错误
                    if (instanceId != session.InstanceId || player.IsDisposed)
                    {
                        response.Error = ErrorCode.Err_PlayerSessionError;
                        reply();
                        return;
                    }

                    // 已经进入游戏
                    if (session.GetComponent<SessionStateComponent>() != null && session.GetComponent<SessionStateComponent>().State == SessionState.Game)
                    {
                        response.Error = ErrorCode.Err_SessionStateError;
                        reply();
                        return;
                    }

                    // 这里不return,因为 玩家相互顶号 play 不同时段 映射 不同session
                    if (player.PlayerState == PlayerState.Game)
                    {
                        try
                        {
                            IActorResponse reqEnter = await MessageHelper.CallLocationActor(player.UnitId, new G2M_RequestEnterGameState());
                            if (reqEnter.Error == 0)
                            {
                                reply();
                                return;
                            }
                            Log.Error("二次登录失败："+reqEnter.Error + "|" + reqEnter.Message);
                            response.Error = ErrorCode.ERR_ReEnterGameError;
                            await DisconnectHelp.KickPlayer(player, true);
                            reply();
                            session?.Disconnect().Coroutine();
                        }
                        catch (Exception e)
                        {
                            Log.Error("二次登录失败："+ e.ToString());
                            response.Error = ErrorCode.ERR_ReEnterGameError2;
                            await DisconnectHelp.KickPlayer(player, true);
                            reply();
                            session?.Disconnect().Coroutine();
                            throw;
                        }
                        
                        return;
                    }
                    
                    // 正常情况下 操作 ,Normal
                    try
                    {
                        GateMapComponent gateMapComponent = player.AddComponent<GateMapComponent>();
                        gateMapComponent.Scene = await SceneFactory.Create(gateMapComponent, "GateMap", SceneType.Map);

                        Unit unit = UnitFactory.Create(gateMapComponent.Scene, player.Id, UnitType.Player);
                        unit.AddComponent<UnitGateComponent, long>(session.InstanceId);
                        long unitId = unit.Id;

                        StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), "Map1");
                        await TransferHelper.Transfer(unit, startSceneConfig.InstanceId,startSceneConfig.Name);

                        player.UnitId = unitId;
                        response.MyId = unitId;

                        reply();

                        SessionStateComponent SessionStateComponent = session.GetComponent<SessionStateComponent>();
                        if (SessionStateComponent == null)
                        {
                            SessionStateComponent = session.AddComponent<SessionStateComponent>();
                        }

                        SessionStateComponent.State = SessionState.Game;

                        player.PlayerState = PlayerState.Game;


                    }
                    catch (Exception e)
                    {
                        Log.Error($"角色进入游戏逻辑服出现问题 ， 账号Id:{player.Account} 角色Id:{player.Id} 异常信息：{e.ToString()}");
                        response.Error = ErrorCode.ERR_EnterGameError;
                        reply();
                        await DisconnectHelp.KickPlayer(player, true);
                        session.Disconnect().Coroutine();
                    }
                }
            }


        }
    }
}