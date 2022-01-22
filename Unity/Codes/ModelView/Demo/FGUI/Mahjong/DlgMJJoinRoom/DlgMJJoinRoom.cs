namespace ET
{
    public class DlgMJJoinRoom : Entity,IAwake,IDestroy
    {
        public FUI_MJJoinRoom View { get => this.Parent.GetComponent<FUI_MJJoinRoom>();} 
    }
}