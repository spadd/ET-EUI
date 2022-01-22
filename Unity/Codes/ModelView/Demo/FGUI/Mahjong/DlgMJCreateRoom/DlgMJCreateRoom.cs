namespace ET
{
    public class DlgMJCreateRoom : Entity,IAwake,IDestroy
    {
        public FUI_MJCreateRoom View { get => this.Parent.GetComponent<FUI_MJCreateRoom>();} 
    }
}