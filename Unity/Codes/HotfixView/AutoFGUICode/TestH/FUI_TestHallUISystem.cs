/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_TestHallUIAwakeSystem : AwakeSystem<FUI_TestHallUI>
	{
		public override void Awake(FUI_TestHallUI self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_TestHallUIAwakeSystem1 : AwakeSystem<FUI_TestHallUI,GObject>
    {
        public override void Awake(FUI_TestHallUI self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_TestHallUIDestroySystem : DestroySystem<FUI_TestHallUI>
    {
        public override void Destroy(FUI_TestHallUI self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_bg = null;
			self.m_title = null;
			self.m_tip = null;
			self.m_enter = null;
        }
    }
}