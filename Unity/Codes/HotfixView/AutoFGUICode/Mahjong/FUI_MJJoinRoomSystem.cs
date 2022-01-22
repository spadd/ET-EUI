/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJJoinRoomAwakeSystem : AwakeSystem<FUI_MJJoinRoom>
	{
		public override void Awake(FUI_MJJoinRoom self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJJoinRoomAwakeSystem1 : AwakeSystem<FUI_MJJoinRoom,GObject>
    {
        public override void Awake(FUI_MJJoinRoom self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJJoinRoomDestroySystem : DestroySystem<FUI_MJJoinRoom>
    {
        public override void Destroy(FUI_MJJoinRoom self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_Close = null;
			self.m_JoinNums?.Dispose();
			self.m_JoinNums = null;
			self.m_JoinInput?.Dispose();
			self.m_JoinInput = null;
        }
    }
}