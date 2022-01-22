namespace ET
{
    public class DlgTestH : Entity,IAwake,ILoad,IDestroy
    {
        public FUI_TestHUI View { get => this.Parent.GetComponent<FUI_TestHUI>();} 
    }
}