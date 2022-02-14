using System;

namespace ET
{
    public class R2C_LoginRealmHandler:AMRpcHandler<C2R_LoginRealm,R2C_LoginRealm>
    {
        protected override async ETTask Run(Session session, C2R_LoginRealm request, R2C_LoginRealm response, Action reply)
        {
            if (SceneType.Realm != session.DomainScene().SceneType)
            {
                Log.Error($"请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
                session.Dispose();
                return;
            }

            Scene domainScene = session.DomainScene();

            if (session.GetComponent<SessionLockingComponent>() != null)
            {
                response.Error = ErrorCode.Err_RequestSceneTypeError;
                reply();
                session?.Disconnect().Coroutine();
                return;
            }

            string token = session.DomainScene().GetComponent<TokenComponent>().Get(request.AccountId);

            if (token == null || token != request.RealmTokenKey)
            {
                response.Error = ErrorCode.ERR_TokenError;
                reply();
                session?.Disconnect().Coroutine();
                return;
            }

            using (session.AddComponent<SessionLockingComponent>())
            {
                // 对账号 加锁
                using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginRealm, request.AccountId))
                {
                    // 取模固定一个Gate
                    StartSceneConfig config = RealmGateAddressHelper.GetGate(domainScene.Zone, request.AccountId);

                    G2R_GetLoginGateKey g2RGetLoginGateKey = (G2R_GetLoginGateKey)await MessageHelper.CallActor(config.InstanceId,new R2G_GetLoginGateKey(){AccountId = request.AccountId});
                    if (g2RGetLoginGateKey.Error != ErrorCode.ERR_Success)
                    {
                        response.Error = g2RGetLoginGateKey.Error;
                        reply();
                        return;
                    }

                    response.GateSessionKey = g2RGetLoginGateKey.GateSessionKey;
                    response.GateAddress = config.OuterIPPort.ToString();
                    reply();
                    
                    session?.Disconnect().Coroutine();
                }
            }

        }
    }
}