using System;


namespace ET
{
    public static class LoginHelper
    {
        public static async ETTask<int> Login(Scene zoneScene, string address, string account, string password)
        {
            A2C_LoginAccount a2CLoginAccount = null;
            Session accountSession = null;
            try
            {
                accountSession = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
                
                // md5进行加密
                password = MD5Helper.StringMD5(password);
                
                a2CLoginAccount = (A2C_LoginAccount) await accountSession.Call(new C2A_LoginAccount(){AccountName = account,PassWord = password});
            }
            catch (Exception e)
            {
                accountSession?.Dispose();
                Log.Error(e.ToString());
                
                return ErrorCode.ERR_NetWorkError;
            }

            if (a2CLoginAccount.Error != ErrorCode.ERR_Success)
            {
                accountSession?.Dispose();
                return a2CLoginAccount.Error;
            }

            zoneScene.AddComponent<SessionComponent>().Session = accountSession;
            // 增加心跳检测
            zoneScene.GetComponent<SessionComponent>().Session.AddComponent<PingComponent>();

            zoneScene.GetComponent<AccountInfoComponent>().Token = a2CLoginAccount.Token;
            zoneScene.GetComponent<AccountInfoComponent>().AccountId = a2CLoginAccount.AccountId;
            
            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> GetServerInfo(Scene zoneScene)
        {
            A2C_GetServerInfo a2CGetServerInfo = null;
            try
            {
                a2CGetServerInfo = (A2C_GetServerInfo) await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2A_GetServerInfo()
                {
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId,
                    Token = zoneScene.GetComponent<AccountInfoComponent>().Token,
                });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }

            if (a2CGetServerInfo.Error != ErrorCode.ERR_Success)
            {
                return a2CGetServerInfo.Error;
            }

            // 添加区服信息
            foreach (var serverInfoProto in a2CGetServerInfo.ServerInfoList)
            {
                ServerInfo serverInfo = zoneScene.GetComponent<ServerInfosComponent>().AddChild<ServerInfo>();
                serverInfo.FromMessage(serverInfoProto);
                zoneScene.GetComponent<ServerInfosComponent>().Add(serverInfo);
            }
            
            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> CreateRole(Scene zoneScene,string name)
        {
            A2C_CreateRole a2CCreateRole = null;

            try
            {
                a2CCreateRole = (A2C_CreateRole)await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2A_CreateRole()
                {
                    AccountId = zoneScene.GetComponent<AccountInfoComponent>().AccountId,
                    Token = zoneScene.GetComponent<AccountInfoComponent>().Token,
                    Name = name,
                    ServerId = 1,
                });
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return ErrorCode.ERR_NetWorkError;
            }

            if (a2CCreateRole.Error != ErrorCode.ERR_Success)
            {
                Log.Error(a2CCreateRole.Error.ToString());
                return a2CCreateRole.Error;
            }
            return ErrorCode.ERR_Success;
        }


        // public static async ETTask Login(Scene zoneScene, string address, string account, string password)
        // {
        //     try
        //     {
        //         // 创建一个ETModel层的Session
        //         R2C_Login r2CLogin;
        //         Session session = null;
        //         try
        //         {
        //             session = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(address));
        //             {
        //                 r2CLogin = (R2C_Login) await session.Call(new C2R_Login() { Account = account, Password = password });
        //             }
        //         }
        //         finally
        //         {
        //             session?.Dispose();
        //         }
        //
        //         // 创建一个gate Session,并且保存到SessionComponent中
        //         Session gateSession = zoneScene.GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(r2CLogin.Address));
        //         gateSession.AddComponent<PingComponent>();
        //         zoneScene.AddComponent<SessionComponent>().Session = gateSession;
				    //
        //         G2C_LoginGate g2CLoginGate = (G2C_LoginGate)await gateSession.Call(
        //             new C2G_LoginGate() { Key = r2CLogin.Key, GateId = r2CLogin.GateId});
        //
        //         Log.Debug("登陆gate成功!");
        //
        //         await Game.EventSystem.PublishAsync(new EventType.LoginFinish() {ZoneScene = zoneScene});
        //     }
        //     catch (Exception e)
        //     {
        //         Log.Error(e);
        //     }
        // } 
    }
}