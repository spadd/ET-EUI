

namespace ET
{
    public class EnterMJHall_Event: AEvent<EventType.EnterMJHall>
    {
        protected override async ETTask Run(EventType.EnterMJHall args)
        {
            args.ZoneScene.GetComponent<FGUIComponent>().CloseWindow(FUI_TestHallUI.UIResName);
            await args.ZoneScene.GetComponent<FGUIComponent>().ShowWindowAsync(FUI_MJLobby.UIPackageName,FUI_MJLobby.UIResName);
        }
    }
}