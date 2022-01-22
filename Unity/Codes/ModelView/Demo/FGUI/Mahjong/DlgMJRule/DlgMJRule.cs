namespace ET
{
    public class DlgMJRule : Entity, IAwake, IDestroy
    {
        public FUI_MJRule View
        {
            get => this.Parent.GetComponent<FUI_MJRule>();
        }
    }
}