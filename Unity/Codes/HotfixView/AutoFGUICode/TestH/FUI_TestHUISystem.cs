/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_TestHUIAwakeSystem : AwakeSystem<FUI_TestHUI>
	{
		public override void Awake(FUI_TestHUI self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_TestHUIAwakeSystem1 : AwakeSystem<FUI_TestHUI,GObject>
    {
        public override void Awake(FUI_TestHUI self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_TestHUIDestroySystem : DestroySystem<FUI_TestHUI>
    {
        public override void Destroy(FUI_TestHUI self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_bg = null;
			self.m_title = null;
			self.m_tip = null;
			self.m_account?.Dispose();
			self.m_account = null;
			self.m_password?.Dispose();
			self.m_password = null;
			self.m_register = null;
			self.m_login = null;
        }
    }
}