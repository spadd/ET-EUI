using System;

namespace ET
{
    public class L2G_DisconnectGateUnitHandler:AMActorRpcHandler<Scene,L2G_DisconnectGateUnit,G2L_DisconnectGateUnit>
    {
        protected override async ETTask Run(Scene scene, L2G_DisconnectGateUnit request, G2L_DisconnectGateUnit response, Action reply)
        {
            long accountId = request.AccountId;
            // 需要和登录保持一致，顶号操作
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginGate, accountId.GetHashCode()))
            {
                PlayerComponent playerComponent = scene.GetComponent<PlayerComponent>();
                Player player = playerComponent.Get(accountId);

                if (player == null)
                {
                    reply();
                    return;
                }
                
                // 移除令牌操作
                scene.GetComponent<GateSessionKeyComponent>().Remove(accountId);
                Session gateSession = Game.EventSystem.Get(player.SessionInstanceId) as Session;
                if (gateSession != null && !gateSession.IsDisposed)
                {
                    // 断开连接消息
                    gateSession.Send(new A2C_Disconnect(){Error = ErrorCode.Err_OtherAccountLogin});
                    gateSession?.Disconnect().Coroutine();
                }

                // 归0
                player.SessionInstanceId = 0;
                player.AddComponent<PlayerOfflineOutTimeComponent>();
            }

            reply();
        }
    }
}