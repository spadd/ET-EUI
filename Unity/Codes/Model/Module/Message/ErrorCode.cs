namespace ET
{
    public static partial class ErrorCode
    {
        public const int ERR_Success = 0;

        // 1-11004 是SocketError请看SocketError定义
        //-----------------------------------
        // 100000-109999是Core层的错误
        
        // 110000以下的错误请看ErrorCore.cs
        
        // 这里配置逻辑层的错误码
        // 110000 - 200000是抛异常的错误
        // 200001以上不抛异常

        public const int ERR_NetWorkError = 200002; // 网络错误
        
        public const int ERR_LoginInfoIsNull = 200003; // 登录信息错误
        public const int ERR_AccountNameFormError = 200004; // 登录账号格式错误
        public const int ERR_PasswordFormError = 200005; // 登录密码格式错误
        public const int ERR_AccountInBlackListError = 200006; // 账号处于黑名单
        public const int ERR_LoginPasswordError = 200007; // 账号密码错误
        public const int RequestRepeatedly = 200008; // 请求重复
        public const int ERR_TokenError = 200009; // 令牌Token错误
        
        public const int ERR_RoleNameIsNull = 200010; // 游戏角色名称为空
        public const int ERR_RoleNameSame = 200011; // 游戏角色名称重复
        public const int ERR_RoleNotExist = 200012; // 游戏角色不存在
        public const int Err_RequestSceneTypeError = 200013; // 游戏角色不存在
        public const int Err_ConnectGateKeyError = 200014; // Gate网关key错误
        public const int Err_OtherAccountLogin = 200015; // Gate网关 被顶号
        public const int Err_SessionPlayError = 200016; // 
        public const int Err_NonePlayerError = 200017; // 
        public const int Err_PlayerSessionError = 200018; // 
        public const int Err_SessionStateError = 200019; // 
        public const int ERR_ReEnterGameError = 200020; // 
        public const int ERR_EnterGameError = 200021; // 
        public const int ERR_ReEnterGameError2 = 200022; // 

    }
}