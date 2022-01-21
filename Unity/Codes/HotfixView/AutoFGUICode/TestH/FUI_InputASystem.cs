/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_InputAAwakeSystem : AwakeSystem<FUI_InputA>
	{
		public override void Awake(FUI_InputA self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_InputAAwakeSystem1 : AwakeSystem<FUI_InputA,GObject>
    {
        public override void Awake(FUI_InputA self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_InputADestroySystem : DestroySystem<FUI_InputA>
    {
        public override void Destroy(FUI_InputA self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_title = null;
			self.m_input = null;
        }
    }
}