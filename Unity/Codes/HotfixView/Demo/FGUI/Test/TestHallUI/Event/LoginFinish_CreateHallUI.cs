

namespace ET
{
    public class LoginFinish_CreateHallUI: AEvent<EventType.LoginFinishTest>
    {
        protected override async ETTask Run(EventType.LoginFinishTest args)
        {
            args.ZoneScene.GetComponent<FGUIComponent>().CloseWindow(FUI_TestHUI.UIResName);
            await args.ZoneScene.GetComponent<FGUIComponent>().ShowWindowAsync(FUI_TestHallUI.UIPackageName,FUI_TestHallUI.UIResName);
        }
    }
}