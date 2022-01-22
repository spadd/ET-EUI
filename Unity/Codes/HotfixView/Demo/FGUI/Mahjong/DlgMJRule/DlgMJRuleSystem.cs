namespace ET
{
    public static class DlgMJRuleSystem
    {
        public static void RegisterUIEvent(this DlgMJRule self)
        {
            self.View.EGButton_Close.AddListener(() =>
            {
                self.OnCloseClick();
            });
        }
        
        public static void ShowWindow(this DlgMJRule self, Entity contextData = null)
        {
            
        }
        
        public static void OnCloseClick(this DlgMJRule self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().CloseWindow(FUI_MJRule.UIResName);
        }
    }
}