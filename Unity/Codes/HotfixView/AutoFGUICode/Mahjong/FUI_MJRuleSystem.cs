/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJRuleAwakeSystem : AwakeSystem<FUI_MJRule>
	{
		public override void Awake(FUI_MJRule self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJRuleAwakeSystem1 : AwakeSystem<FUI_MJRule,GObject>
    {
        public override void Awake(FUI_MJRule self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJRuleDestroySystem : DestroySystem<FUI_MJRule>
    {
        public override void Destroy(FUI_MJRule self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_Close = null;
        }
    }
}