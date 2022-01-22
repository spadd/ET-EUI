namespace ET
{
    [AFGUIEvent(FUI_MJRule.UIResName)]
    public class DlgMJRuleEventHandler : IAFGUIEventHandler
    {
        public void OnInitWindowCoreData(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void OnInitComponent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.AddComponent<FUI_MJRule>(); 
            uiBaseWindow.AddComponent<DlgMJRule>(); 
        }

        public void OnRegisterUIEvent(FGUIBaseWindow uiBaseWindow)
        {
            uiBaseWindow.GetComponent<DlgMJRule>().RegisterUIEvent(); 
        }

        public void OnShowWindow(FGUIBaseWindow uiBaseWindow, Entity contextData = null)
        {
            uiBaseWindow.GetComponent<DlgMJRule>().ShowWindow(contextData); 
        }

        public void OnHideWindow(FGUIBaseWindow uiBaseWindow)
        {
            
        }

        public void BeforeUnload(FGUIBaseWindow uiBaseWindow)
        {
            
        }
    }
}