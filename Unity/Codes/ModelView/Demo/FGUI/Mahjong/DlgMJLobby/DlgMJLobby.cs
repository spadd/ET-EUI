namespace ET
{
    public class DlgMJLobby : Entity,IAwake,IDestroy
    {
        public FUI_MJLobby View { get => this.Parent.GetComponent<FUI_MJLobby>();} 
    }
}