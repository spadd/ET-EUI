/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_JoinNumAwakeSystem : AwakeSystem<FUI_JoinNum>
	{
		public override void Awake(FUI_JoinNum self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_JoinNumAwakeSystem1 : AwakeSystem<FUI_JoinNum,GObject>
    {
        public override void Awake(FUI_JoinNum self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_JoinNumDestroySystem : DestroySystem<FUI_JoinNum>
    {
        public override void Destroy(FUI_JoinNum self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_Num = null;
        }
    }
}