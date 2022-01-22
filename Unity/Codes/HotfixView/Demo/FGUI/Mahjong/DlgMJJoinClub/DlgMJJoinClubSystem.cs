namespace ET
{
    public static class DlgMJJoinClubSystem
    {
        public static void RegisterUIEvent(this DlgMJJoinClub self)
        {
            self.View.EGButton_Close.AddListener(() =>
            {
                self.OnCloseClick();
            });
        }
        
        public static void ShowWindow(this DlgMJJoinClub self, Entity contextData = null)
        {
            
        }
        
        public static void OnCloseClick(this DlgMJJoinClub self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().CloseWindow(FUI_MJJoinClub.UIResName);
        }
    }
}