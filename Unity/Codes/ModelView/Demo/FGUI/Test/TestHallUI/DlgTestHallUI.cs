namespace ET
{
    public class DlgTestHallUI : Entity,IAwake,IDestroy
    {
        public FUI_TestHallUI View { get => this.Parent.GetComponent<FUI_TestHallUI>();} 
    }
}