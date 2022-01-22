/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_JoinRoomInputAwakeSystem : AwakeSystem<FUI_JoinRoomInput>
	{
		public override void Awake(FUI_JoinRoomInput self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_JoinRoomInputAwakeSystem1 : AwakeSystem<FUI_JoinRoomInput,GObject>
    {
        public override void Awake(FUI_JoinRoomInput self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_JoinRoomInputDestroySystem : DestroySystem<FUI_JoinRoomInput>
    {
        public override void Destroy(FUI_JoinRoomInput self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_Num1 = null;
			self.m_Num2 = null;
			self.m_Num3 = null;
			self.m_Num4 = null;
			self.m_Num5 = null;
			self.m_Num6 = null;
			self.m_Num7 = null;
			self.m_Num8 = null;
			self.m_Num9 = null;
			self.m_NumReset = null;
			self.m_Num0 = null;
			self.m_NumDel = null;
        }
    }
}