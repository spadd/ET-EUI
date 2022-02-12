/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_RoletemAwakeSystem : AwakeSystem<FUI_Roletem>
	{
		public override void Awake(FUI_Roletem self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = (GButton)self.GObject;
		}
	}

    [ObjectSystem]
    public class FUI_RoletemAwakeSystem1 : AwakeSystem<FUI_Roletem,GObject>
    {
        public override void Awake(FUI_Roletem self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = (GButton)transform;
        }
    }

    [ObjectSystem]
    public class FUI_RoletemDestroySystem : DestroySystem<FUI_Roletem>
    {
        public override void Destroy(FUI_Roletem self)
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