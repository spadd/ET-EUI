namespace ET
{
    public class DlgMJJoinClub : Entity,IAwake,IDestroy
    {
        public FUI_MJJoinClub View { get => this.Parent.GetComponent<FUI_MJJoinClub>();} 
    }
}