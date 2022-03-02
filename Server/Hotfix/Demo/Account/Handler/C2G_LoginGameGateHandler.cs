using System;

namespace ET
{
    public class C2G_LoginGameGateHandler:AMRpcHandler<C2G_LoginGameGate,G2C_LoginGameGate>
    {
        protected override async ETTask Run(Session session, C2G_LoginGameGate request, G2C_LoginGameGate response, Action reply)
        {
            if (session.DomainScene().SceneType != SceneType.Gate)
            {
                Log.Error($"请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
                session.Dispose();
                return;
            }
            
            session.RemoveComponent<SessionAcceptTimeoutComponent>();

            if (session.GetComponent<SessionLockingComponent>() != null)
            {
                response.Error = ErrorCode.RequestRepeatedly;
                reply();
                return;
            }

            Scene scene = session.DomainScene();
            string tokenKey = scene.GetComponent<GateSessionKeyComponent>().Get(request.Account);
            if (tokenKey == null || !tokenKey.Equals(request.Key))
            {
                response.Error = ErrorCode.Err_ConnectGateKeyError;
                response.Message = "gate key 严重失败";
                reply();
                session?.Disconnect().Coroutine();
                return;
            }
            
            scene.GetComponent<GateSessionKeyComponent>().Remove(request.Account);
            long instanceId = session.InstanceId;
            using (session.AddComponent<SessionLockingComponent>())
            {
                using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginGate,request.Account.GetHashCode()))
                {
                    if (instanceId != session.InstanceId)
                    {
                        return;
                    }
                    
                    // 通知登录中心服，记录本次登录的服务器zone
                    StartSceneConfig loginCenterConfig = StartSceneConfigCategory.Instance.LoginCenterConfig;
                    L2G_AddLoginRecord l2GAddLoginRecord = (L2G_AddLoginRecord)await MessageHelper.CallActor(loginCenterConfig.InstanceId,
                        new G2L_AddLoginRecord()
                        {
                            AccountId = request.Account,ServerId = scene.Zone
                        });

                    if (l2GAddLoginRecord.Error != ErrorCode.ERR_Success)
                    {
                        response.Error = l2GAddLoginRecord.Error;
                        reply();
                        session?.Disconnect().Coroutine();
                        return;
                    }

                    SessionStateComponent SessionStateComponent = session.GetComponent<SessionStateComponent>();
                    if (SessionStateComponent == null)
                    {
                        SessionStateComponent = session.AddComponent<SessionStateComponent>();
                    }

                    SessionStateComponent.State = SessionState.Normal;

                    // 角色有多个，账号只有一个
                    Player player = scene.GetComponent<PlayerComponent>().Get(request.Account);
                    if (player == null)
                    {
                        // 添加一个新的GateUnit
                        player = scene.GetComponent<PlayerComponent>()
                                .AddChildWithId<Player, long, long>(request.RoleId, request.Account, request.RoleId);
                        player.PlayerState = PlayerState.Gate;
                        scene.GetComponent<PlayerComponent>().Add(player);
                        session.AddComponent<MailBoxComponent, MailboxType>(MailboxType.GateSession);
                    }
                    else
                    {
                        player.RemoveComponent<PlayerOfflineOutTimeComponent>();
                    }

                    session.AddComponent<SessionPlayerComponent>().PlayerId = player.Id;
                    session.GetComponent<SessionPlayerComponent>().PlayerInstanceId = player.InstanceId;
                    session.GetComponent<SessionPlayerComponent>().AccountId = request.Account;
                    // 通过Player的SessionInstanceId也可以反过来拿到对应的Session
                    player.SessionInstanceId = session.InstanceId;

                    response.PlayerId = player.Id;
                    reply();

                }

                

            }

        }
    }
}