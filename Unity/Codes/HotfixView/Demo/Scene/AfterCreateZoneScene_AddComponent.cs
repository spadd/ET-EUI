namespace ET
{
    public class AfterCreateZoneScene_AddComponent: AEvent<EventType.AfterCreateZoneScene>
    {
        protected override async ETTask Run(EventType.AfterCreateZoneScene args)
        {
            Scene zoneScene = args.ZoneScene;
            // zoneScene.AddComponent<UIComponent>();
            // zoneScene.AddComponent<UIPathComponent>();
            // zoneScene.AddComponent<UIEventComponent>();
            // zoneScene.AddComponent<RedDotComponent>();
            // zoneScene.AddComponent<ResourcesLoaderComponent>();
            //
            // zoneScene.GetComponent<UIComponent>().ShowWindow(WindowID.WindowID_Login);
            // await ETTask.CompletedTask;

            Log.Info("<color=green>在这显示界面</color>");
            
            zoneScene.AddComponent<FGUIComponent>();
            zoneScene.AddComponent<FGUIEventComponent>();
            zoneScene.AddComponent<ResourcesLoaderComponent>();
            
            await zoneScene.GetComponent<FGUIComponent>().ShowWindowAsync(FUI_TestHUI.UIPackageName,FUI_TestHUI.UIResName);
        }
    }
}