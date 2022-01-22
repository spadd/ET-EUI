/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_JoinRoomNumsAwakeSystem : AwakeSystem<FUI_JoinRoomNums>
	{
		public override void Awake(FUI_JoinRoomNums self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_JoinRoomNumsAwakeSystem1 : AwakeSystem<FUI_JoinRoomNums,GObject>
    {
        public override void Awake(FUI_JoinRoomNums self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_JoinRoomNumsDestroySystem : DestroySystem<FUI_JoinRoomNums>
    {
        public override void Destroy(FUI_JoinRoomNums self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_Num1?.Dispose();
			self.m_Num1 = null;
			self.m_Num2?.Dispose();
			self.m_Num2 = null;
			self.m_Num3?.Dispose();
			self.m_Num3 = null;
			self.m_Num4?.Dispose();
			self.m_Num4 = null;
			self.m_Num5?.Dispose();
			self.m_Num5 = null;
			self.m_Num6?.Dispose();
			self.m_Num6 = null;
        }
    }
}