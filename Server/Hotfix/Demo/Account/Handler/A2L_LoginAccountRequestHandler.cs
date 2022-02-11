using System;

namespace ET
{
    [ActorMessageHandler]
    public class A2L_LoginAccountRequestHandler:AMActorRpcHandler<Scene,A2L_LoginAccountRequest,L2A_LoginAccountResponse>
    {
        protected override async ETTask Run(Scene scene, A2L_LoginAccountRequest request, L2A_LoginAccountResponse response, Action reply)
        {
            long accountId = request.AccountId;

            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginCenterLock,accountId.GetHashCode()))
            {
                if (!scene.GetComponent<LoginInfoRecordComponent>().IsExist(accountId))
                {
                    reply();
                    return;
                }

                // 通过 zone 获取网关地址
                int zone = scene.GetComponent<LoginInfoRecordComponent>().Get(accountId);
                StartSceneConfig gateConfig = RealmGateAddressHelper.GetGate(zone,accountId);

                // 另外一种方式 发送 Actor 消息
                G2L_DisconnectGateUnit g2LDisconnectGateUnit = (G2L_DisconnectGateUnit)await MessageHelper.CallActor(gateConfig.InstanceId, new L2G_DisconnectGateUnit(){AccountId = accountId});

                response.Error = g2LDisconnectGateUnit.Error;
                reply();

            }
        }
    }
}