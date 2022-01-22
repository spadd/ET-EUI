/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJAlertAwakeSystem : AwakeSystem<FUI_MJAlert>
	{
		public override void Awake(FUI_MJAlert self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJAlertAwakeSystem1 : AwakeSystem<FUI_MJAlert,GObject>
    {
        public override void Awake(FUI_MJAlert self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJAlertDestroySystem : DestroySystem<FUI_MJAlert>
    {
        public override void Destroy(FUI_MJAlert self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_yes = null;
			self.m_no = null;
			self.m_text = null;
        }
    }
}