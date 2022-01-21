namespace ET
{
    public static class DlgTestHSystem
    {
        public static void RegisterUIEvent(this DlgTestH self)
        {
            self.View.EGButton_login.AddListener(() =>
            {
                self.OnLoginClick();
            });

            self.View.EGButton_register.AddListener(() =>
            {
                self.OnRegisterClick();
            });
        }

        public static void ShowWindow(this DlgTestH self, Entity contextData = null)
        {
            self.View.EGTextField_tip.text = "设置内容试试";
        }

        public static void OnLoginClick(this DlgTestH self)
        {
            string account = self.View.EFUI_InputA_account.EGTextInput_input.text;
            string password = self.View.EFUI_InputA_password.EGTextInput_input.text;
            Log.Info($"OnLoginClick account={account} password={password}");
            Game.EventSystem.PublishAsync(new EventType.LoginFinishTest() {ZoneScene = self.DomainScene()}).Coroutine();
        }
        public static void OnRegisterClick(this DlgTestH self)
        {
            string account = self.View.EFUI_InputA_account.EGTextInput_input.text;
            string password = self.View.EFUI_InputA_password.EGTextInput_input.text;
            Log.Info($"OnRegisterClick account={account} password={password}");
            Game.EventSystem.PublishAsync(new EventType.LoginFinishTest() {ZoneScene = self.DomainScene()}).Coroutine();
        }
    }
}