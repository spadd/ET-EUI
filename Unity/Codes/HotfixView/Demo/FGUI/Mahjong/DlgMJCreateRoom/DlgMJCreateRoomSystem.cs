namespace ET
{
    public static class DlgMJCreateRoomSystem
    {
        public static void RegisterUIEvent(this DlgMJCreateRoom self)
        {
            self.View.EGButton_close.AddListener(() =>
            {
                self.OnCloseClick();
            });
        }
        
        public static void ShowWindow(this DlgMJCreateRoom self, Entity contextData = null)
        {
            
        }
        
        public static void OnCloseClick(this DlgMJCreateRoom self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().CloseWindow(FUI_MJCreateRoom.UIResName);
        }
    }
}