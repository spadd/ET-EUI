namespace ET
{
    [AFGUIEvent(FUI_MJClub.UIResName)]
    public class DlgMJClubEventHandler : IAFGUIEventHandler
    {
        public void OnInitWindowCoreData(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void OnInitComponent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.AddComponent<FUI_MJClub>(); 
            uiBaseWindow.AddComponent<DlgMJClub>(); 
        }

        public void OnRegisterUIEvent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.GetComponent<DlgMJClub>().RegisterUIEvent(); 
        }

        public void OnShowWindow(FGUIBaseWindow uiBaseWindow, Entity contextData = null)
        {
            uiBaseWindow.GetComponent<DlgMJClub>().ShowWindow(contextData); 
        }

        public void OnHideWindow(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void BeforeUnload(FGUIBaseWindow uiBaseWindow)
        {
            
        }
    }
}