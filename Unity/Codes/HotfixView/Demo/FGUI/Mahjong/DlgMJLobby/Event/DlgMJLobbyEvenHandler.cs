namespace ET
{
    [AFGUIEvent(FUI_MJLobby.UIResName)]
    public class DlgMJLobbyEvenHandler : IAFGUIEventHandler
    {
        public void OnInitWindowCoreData(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void OnInitComponent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.AddComponent<FUI_MJLobby>(); 
            uiBaseWindow.AddComponent<DlgMJLobby>(); 
        }

        public void OnRegisterUIEvent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.GetComponent<DlgMJLobby>().RegisterUIEvent(); 
        }

        public void OnShowWindow(FGUIBaseWindow uiBaseWindow, Entity contextData = null)
        {
            uiBaseWindow.GetComponent<DlgMJLobby>().ShowWindow(contextData); 
        }

        public void OnHideWindow(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void BeforeUnload(FGUIBaseWindow uiBaseWindow)
        {
            
        }
    }
}