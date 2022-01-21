namespace ET
{
    public class DlgTestHallUI : Entity,IAwake
    {
        public FUI_TestHallUI View { get => this.Parent.GetComponent<FUI_TestHallUI>();} 
    }
}