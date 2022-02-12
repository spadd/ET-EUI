namespace ET
{
    public class DlgTestHallUI : Entity,IAwake,ILoad,IDestroy
    {
        public FUI_TestHallUI View { get => this.Parent.GetComponent<FUI_TestHallUI>();} 
    }
}