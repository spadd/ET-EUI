namespace ET
{
    public class DlgMJClub : Entity,IAwake,IDestroy
    {
        public FUI_MJClub View { get => this.Parent.GetComponent<FUI_MJClub>();} 
    }
}