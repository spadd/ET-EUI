namespace ET
{
    public static class DlgMJJoinRoomSystem
    {
        public static void RegisterUIEvent(this DlgMJJoinRoom self)
        {
            self.View.EGButton_Close.AddListener(() =>
            {
                self.OnCloseClick();
            });
        }
        
        public static void ShowWindow(this DlgMJJoinRoom self, Entity contextData = null)
        {
            
        }
        
        public static void OnCloseClick(this DlgMJJoinRoom self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().CloseWindow(FUI_MJJoinRoom.UIResName);
        }
    }
}