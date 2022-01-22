/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJDissolveAwakeSystem : AwakeSystem<FUI_MJDissolve>
	{
		public override void Awake(FUI_MJDissolve self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJDissolveAwakeSystem1 : AwakeSystem<FUI_MJDissolve,GObject>
    {
        public override void Awake(FUI_MJDissolve self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJDissolveDestroySystem : DestroySystem<FUI_MJDissolve>
    {
        public override void Destroy(FUI_MJDissolve self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_yes = null;
			self.m_no = null;
			self.m_text = null;
			self.m_list = null;
        }
    }
}