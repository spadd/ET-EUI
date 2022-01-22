namespace ET
{
    [AFGUIEvent(FUI_MJCreateRoom.UIResName)]
    public class DlgMJCreateRoomEventHandler : IAFGUIEventHandler
    {
        public void OnInitWindowCoreData(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void OnInitComponent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.AddComponent<FUI_MJCreateRoom>(); 
            uiBaseWindow.AddComponent<DlgMJCreateRoom>(); 
        }

        public void OnRegisterUIEvent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.GetComponent<DlgMJCreateRoom>().RegisterUIEvent(); 
        }

        public void OnShowWindow(FGUIBaseWindow uiBaseWindow, Entity contextData = null)
        {
            uiBaseWindow.GetComponent<DlgMJCreateRoom>().ShowWindow(contextData); 
        }

        public void OnHideWindow(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void BeforeUnload(FGUIBaseWindow uiBaseWindow)
        {
            
        }
    }
}