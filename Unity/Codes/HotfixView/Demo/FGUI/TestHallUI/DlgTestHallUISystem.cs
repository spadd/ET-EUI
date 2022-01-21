namespace ET
{
    public static class DlgTestHallUISystem
    {
        public static void RegisterUIEvent(this DlgTestHallUI self)
        {
            self.View.EGButton_enter.AddListener(() =>
            {
                self.OnEnterClick();
            });
        }
        
        public static void ShowWindow(this DlgTestHallUI self, Entity contextData = null)
        {
            self.View.EGTextField_tip.text = "设置内容试试";
        }

        public static void OnEnterClick(this DlgTestHallUI self)
        {
            Log.Info("Onenter");
        }

    }
}