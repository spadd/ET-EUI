namespace ET
{
    public static class DlgMJClubSystem
    {
        public static void RegisterUIEvent(this DlgMJClub self)
        {
            self.View.EGButton_Close.AddListener(() =>
            {
                self.OnCloseClick();
            });
            
            self.View.EGButton_Apply.AddListener(() =>
            {
                self.OnApplyClick();
            });
        }
        
        public static void ShowWindow(this DlgMJClub self, Entity contextData = null)
        {
            
        }

        public static void OnCloseClick(this DlgMJClub self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().CloseWindow(FUI_MJClub.UIResName);
        }
        
        public static void OnApplyClick(this DlgMJClub self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().ShowWindowAsync(FUI_MJJoinClub.UIPackageName,FUI_MJJoinClub.UIResName).Coroutine();
        }


    }
}