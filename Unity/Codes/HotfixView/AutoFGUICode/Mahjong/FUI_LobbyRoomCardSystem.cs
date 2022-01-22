/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_LobbyRoomCardAwakeSystem : AwakeSystem<FUI_LobbyRoomCard>
	{
		public override void Awake(FUI_LobbyRoomCard self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_LobbyRoomCardAwakeSystem1 : AwakeSystem<FUI_LobbyRoomCard,GObject>
    {
        public override void Awake(FUI_LobbyRoomCard self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_LobbyRoomCardDestroySystem : DestroySystem<FUI_LobbyRoomCard>
    {
        public override void Destroy(FUI_LobbyRoomCard self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_AddRoomCard = null;
			self.m_CardCnt = null;
        }
    }
}