/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_TestServerListUIAwakeSystem : AwakeSystem<FUI_TestServerListUI>
	{
		public override void Awake(FUI_TestServerListUI self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = (GComponent)self.GObject;
		}
	}

    [ObjectSystem]
    public class FUI_TestServerListUIAwakeSystem1 : AwakeSystem<FUI_TestServerListUI,GObject>
    {
        public override void Awake(FUI_TestServerListUI self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = (GComponent)transform;
        }
    }

    [ObjectSystem]
    public class FUI_TestServerListUIDestroySystem : DestroySystem<FUI_TestServerListUI>
    {
        public override void Destroy(FUI_TestServerListUI self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_title = null;
			self.m_ServerList = null;
			self.m_BtnSelect = null;
        }
    }
}