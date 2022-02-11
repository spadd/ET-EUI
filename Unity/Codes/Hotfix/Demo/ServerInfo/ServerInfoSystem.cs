namespace ET
{
    public static class ServerInfoSystem
    {
        public static void FromMessage(this ServerInfo self,ServerInfoProto serverInfoProto)
        {
            self.Id = serverInfoProto.Id;
            self.Status = serverInfoProto.Status;
            self.ServerName = serverInfoProto.ServeName;
        }

        public static ServerInfoProto ToMessage(this ServerInfo self)
        {
            return new ServerInfoProto(){Id = (int)self.Id,ServeName = self.ServerName,Status = self.Status};
        }
    }
}