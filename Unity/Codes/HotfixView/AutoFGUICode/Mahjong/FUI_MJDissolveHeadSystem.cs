/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJDissolveHeadAwakeSystem : AwakeSystem<FUI_MJDissolveHead>
	{
		public override void Awake(FUI_MJDissolveHead self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJDissolveHeadAwakeSystem1 : AwakeSystem<FUI_MJDissolveHead,GObject>
    {
        public override void Awake(FUI_MJDissolveHead self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJDissolveHeadDestroySystem : DestroySystem<FUI_MJDissolveHead>
    {
        public override void Destroy(FUI_MJDissolveHead self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_frame = null;
			self.m_head = null;
			self.m_name = null;
			self.m_status_background = null;
			self.m_status = null;
        }
    }
}