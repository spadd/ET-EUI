/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJLobbyAwakeSystem : AwakeSystem<FUI_MJLobby>
	{
		public override void Awake(FUI_MJLobby self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJLobbyAwakeSystem1 : AwakeSystem<FUI_MJLobby,GObject>
    {
        public override void Awake(FUI_MJLobby self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJLobbyDestroySystem : DestroySystem<FUI_MJLobby>
    {
        public override void Destroy(FUI_MJLobby self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_CreateRoom = null;
			self.m_JoinRoom = null;
			self.m_Club = null;
			self.m_History = null;
			self.m_Rule = null;
			self.m_RoomCard?.Dispose();
			self.m_RoomCard = null;
			self.m_UserInfo?.Dispose();
			self.m_UserInfo = null;
			self.m_Board?.Dispose();
			self.m_Board = null;
        }
    }
}