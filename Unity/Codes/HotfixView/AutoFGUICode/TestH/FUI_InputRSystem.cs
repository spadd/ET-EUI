/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_InputRAwakeSystem : AwakeSystem<FUI_InputR>
	{
		public override void Awake(FUI_InputR self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = (GComponent)self.GObject;
		}
	}

    [ObjectSystem]
    public class FUI_InputRAwakeSystem1 : AwakeSystem<FUI_InputR,GObject>
    {
        public override void Awake(FUI_InputR self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = (GComponent)transform;
        }
    }

    [ObjectSystem]
    public class FUI_InputRDestroySystem : DestroySystem<FUI_InputR>
    {
        public override void Destroy(FUI_InputR self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_title = null;
			self.m_input = null;
        }
    }
}