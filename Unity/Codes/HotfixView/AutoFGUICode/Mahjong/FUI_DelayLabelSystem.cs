/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_DelayLabelAwakeSystem : AwakeSystem<FUI_DelayLabel>
	{
		public override void Awake(FUI_DelayLabel self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_DelayLabelAwakeSystem1 : AwakeSystem<FUI_DelayLabel,GObject>
    {
        public override void Awake(FUI_DelayLabel self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_DelayLabelDestroySystem : DestroySystem<FUI_DelayLabel>
    {
        public override void Destroy(FUI_DelayLabel self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_c1 = null;
			self.m_delay = null;
        }
    }
}