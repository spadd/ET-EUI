namespace ET.Handler
{
    [MessageHandler]
    public class A2C_DisconnectHandler : AMHandler<A2C_Disconnect>
    {
        protected override async ETTask Run(Session session, A2C_Disconnect message)
        {
            Log.Error($"服务器主动断开连接 code = {message.Error}");
            await ETTask.CompletedTask;
        }
    }
}