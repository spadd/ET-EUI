/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_ServerItemAwakeSystem : AwakeSystem<FUI_ServerItem>
	{
		public override void Awake(FUI_ServerItem self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = (GButton)self.GObject;
		}
	}

    [ObjectSystem]
    public class FUI_ServerItemAwakeSystem1 : AwakeSystem<FUI_ServerItem,GObject>
    {
        public override void Awake(FUI_ServerItem self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = (GButton)transform;
        }
    }

    [ObjectSystem]
    public class FUI_ServerItemDestroySystem : DestroySystem<FUI_ServerItem>
    {
        public override void Destroy(FUI_ServerItem self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_ItemBg = null;
			self.m_ItemSelectBg = null;
			self.m_Content = null;
        }
    }
}