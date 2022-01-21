namespace ET
{
    public class DlgTestH : Entity,IAwake
    {
        public FUI_TestHUI View { get => this.Parent.GetComponent<FUI_TestHUI>();} 
    }
}