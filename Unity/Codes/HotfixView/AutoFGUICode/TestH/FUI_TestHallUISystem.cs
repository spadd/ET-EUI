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
			self.uiTransform = (GComponent)self.GObject;
		}
	}

    [ObjectSystem]
    public class FUI_TestHallUIAwakeSystem1 : AwakeSystem<FUI_TestHallUI,GObject>
    {
        public override void Awake(FUI_TestHallUI self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = (GComponent)transform;
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
			self.m_title = null;
			self.m_tip = null;
			self.m_UserInfo = null;
			self.m_EnterMj = null;
			self.m_EnterMMO = null;
        }
    }
}