namespace ET
{
    public static class DlgMJLobbySystem
    {
        public static void RegisterUIEvent(this DlgMJLobby self)
        {
            self.View.EGButton_Club.AddListener(() =>
            {
                self.OnClubClick();
            });
            
            self.View.EGButton_CreateRoom.AddListener(() =>
            {
                self.OnCreateRoomClick();
            });
            
            self.View.EGButton_JoinRoom.AddListener(() =>
            {
                self.OnJoinRoomClick();
            });
            
            self.View.EGButton_Rule.AddListener(() =>
            {
                self.OnRuleClick();
            });
        }
        
        public static void ShowWindow(this DlgMJLobby self, Entity contextData = null)
        {
            
        }

        public static void OnClubClick(this DlgMJLobby self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().ShowWindowAsync(FUI_MJClub.UIPackageName,FUI_MJClub.UIResName).Coroutine();
        }
        
        public static void OnCreateRoomClick(this DlgMJLobby self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().ShowWindowAsync(FUI_MJCreateRoom.UIPackageName,FUI_MJCreateRoom.UIResName).Coroutine();
        }
        
        public static void OnJoinRoomClick(this DlgMJLobby self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().ShowWindowAsync(FUI_MJJoinRoom.UIPackageName,FUI_MJJoinRoom.UIResName).Coroutine();
        }        
        public static void OnRuleClick(this DlgMJLobby self)
        {
            self.DomainScene().GetComponent<FGUIComponent>().ShowWindowAsync(FUI_MJRule.UIPackageName,FUI_MJRule.UIResName).Coroutine();
        }

    }
}