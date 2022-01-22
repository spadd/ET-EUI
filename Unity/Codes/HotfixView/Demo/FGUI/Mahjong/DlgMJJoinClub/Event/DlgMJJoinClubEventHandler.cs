namespace ET
{
    [AFGUIEvent(FUI_MJJoinClub.UIResName)]
    public class DlgMJJoinClubEventHandler : IAFGUIEventHandler
    {
        public void OnInitWindowCoreData(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void OnInitComponent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.AddComponent<FUI_MJJoinClub>(); 
            uiBaseWindow.AddComponent<DlgMJJoinClub>(); 
        }

        public void OnRegisterUIEvent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.GetComponent<DlgMJJoinClub>().RegisterUIEvent(); 
        }

        public void OnShowWindow(FGUIBaseWindow uiBaseWindow, Entity contextData = null)
        {
            uiBaseWindow.GetComponent<DlgMJJoinClub>().ShowWindow(contextData); 
        }

        public void OnHideWindow(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void BeforeUnload(FGUIBaseWindow uiBaseWindow)
        {
            
        }
    }
}