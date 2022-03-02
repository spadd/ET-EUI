

namespace ET
{
	public static class SessionPlayerComponentSystem
	{
		public class SessionPlayerComponentDestroySystem: DestroySystem<SessionPlayerComponent>
		{
			public override void Destroy(SessionPlayerComponent self)
			{
				// 发送断线消息
				ActorLocationSenderComponent.Instance.Send(self.PlayerId, new G2M_SessionDisconnect());
				self.Domain.GetComponent<PlayerComponent>()?.Remove(self.AccountId);
				
				// todo 判断 主动断开（不执行kickplay） 还是 2次登录（执行KickPlay）
				// DisconnectHelp.KickPlayer();
			}
		}

		public static Player GetMyPlayer(this SessionPlayerComponent self)
		{
			return self.Domain.GetComponent<PlayerComponent>().Get(self.AccountId);
		}
	}
}
