namespace ET
{
    public class DlgTestServerListUI : Entity,IAwake,ILoad,IDestroy
    {
        public FUI_TestServerListUI View { get => this.Parent.GetComponent<FUI_TestServerListUI>();} 
    }
}