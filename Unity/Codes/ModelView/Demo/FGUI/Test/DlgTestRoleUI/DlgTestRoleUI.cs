namespace ET
{
    public class DlgTestRoleUI : Entity,IAwake,ILoad,IDestroy
    {
        public FUI_TestRoleUI View { get => this.Parent.GetComponent<FUI_TestRoleUI>();} 
    }
}