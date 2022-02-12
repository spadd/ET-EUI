namespace ET
{
    [ObjectSystem]
    public class DlgTestHallUILoadSystem: LoadSystem<DlgTestHallUI>
    {
        public override void Load(DlgTestHallUI self)
        {
            self.RegisterUIEvent();
        }
    }
    public static class DlgTestHallUISystem
    {
        public static void RegisterUIEvent(this DlgTestHallUI self)
        {
            self.View.EGButton_EnterMj.AddListener(() =>
            {
                self.OnEnterMJClick();
            });
            
            self.View.EGButton_EnterMMO.AddListener(() =>
            {
                self.OnEnterMMOClick();
            });
        }
        
        public static void ShowWindow(this DlgTestHallUI self, Entity contextData = null)
        {
            self.View.EGTextField_tip.text = "设置内容试试";
        }

        public static void OnEnterMJClick(this DlgTestHallUI self)
        {
            Log.Info("On enter mj");
            Game.EventSystem.PublishAsync(new EventType.EnterMJHall()
            {
                ZoneScene = self.DomainScene()
            }).Coroutine();
        }
        
        public static void OnEnterMMOClick(this DlgTestHallUI self)
        {
            Log.Info("On enter mmo");
        }

    }
}