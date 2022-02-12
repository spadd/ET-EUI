/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_TestRoleUIAwakeSystem : AwakeSystem<FUI_TestRoleUI>
	{
		public override void Awake(FUI_TestRoleUI self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = (GComponent)self.GObject;
		}
	}

    [ObjectSystem]
    public class FUI_TestRoleUIAwakeSystem1 : AwakeSystem<FUI_TestRoleUI,GObject>
    {
        public override void Awake(FUI_TestRoleUI self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = (GComponent)transform;
        }
    }

    [ObjectSystem]
    public class FUI_TestRoleUIDestroySystem : DestroySystem<FUI_TestRoleUI>
    {
        public override void Destroy(FUI_TestRoleUI self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_title = null;
			self.m_RoleList = null;
			self.m_InputRole?.Dispose();
			self.m_InputRole = null;
			self.m_BtnDelRole = null;
			self.m_BtnCreateRole = null;
			self.m_BtnGoGame = null;
        }
    }
}