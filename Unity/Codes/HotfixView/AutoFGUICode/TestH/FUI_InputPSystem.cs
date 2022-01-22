/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_InputPAwakeSystem : AwakeSystem<FUI_InputP>
	{
		public override void Awake(FUI_InputP self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_InputPAwakeSystem1 : AwakeSystem<FUI_InputP,GObject>
    {
        public override void Awake(FUI_InputP self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_InputPDestroySystem : DestroySystem<FUI_InputP>
    {
        public override void Destroy(FUI_InputP self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_title = null;
			self.m_input = null;
        }
    }
}