/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJGameEndAwakeSystem : AwakeSystem<FUI_MJGameEnd>
	{
		public override void Awake(FUI_MJGameEnd self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJGameEndAwakeSystem1 : AwakeSystem<FUI_MJGameEnd,GObject>
    {
        public override void Awake(FUI_MJGameEnd self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJGameEndDestroySystem : DestroySystem<FUI_MJGameEnd>
    {
        public override void Destroy(FUI_MJGameEnd self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_container = null;
			self.m_title = null;
			self.m_desc = null;
			self.m_timestamp = null;
			self.m_list = null;
			self.m_cancel = null;
			self.m_share = null;
        }
    }
}