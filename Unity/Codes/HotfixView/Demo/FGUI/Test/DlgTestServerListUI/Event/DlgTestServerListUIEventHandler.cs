namespace ET
{
    [AFGUIEvent(FUI_TestServerListUI.UIResName)]
    public class DlgTestServerListUIEventHandler : IAFGUIEventHandler
    {
        public void OnInitWindowCoreData(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void OnInitComponent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.AddComponent<FUI_TestServerListUI>(); 
            uiBaseWindow.AddComponent<DlgTestServerListUI>(); 
        }

        public void OnRegisterUIEvent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.GetComponent<DlgTestServerListUI>().RegisterUIEvent(); 
        }

        public void OnShowWindow(FGUIBaseWindow uiBaseWindow, Entity contextData = null)
        {
            uiBaseWindow.GetComponent<DlgTestServerListUI>().ShowWindow(contextData); 
        }

        public void OnHideWindow(FGUIBaseWindow uiBaseWindow)
        {
        }

        public void BeforeUnload(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.GetComponent<DlgTestServerListUI>().BeforeUnload(); 
        }
    }
}