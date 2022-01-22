/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_LobbyUserInfoAwakeSystem : AwakeSystem<FUI_LobbyUserInfo>
	{
		public override void Awake(FUI_LobbyUserInfo self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_LobbyUserInfoAwakeSystem1 : AwakeSystem<FUI_LobbyUserInfo,GObject>
    {
        public override void Awake(FUI_LobbyUserInfo self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_LobbyUserInfoDestroySystem : DestroySystem<FUI_LobbyUserInfo>
    {
        public override void Destroy(FUI_LobbyUserInfo self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_Nickname = null;
			self.m_UId = null;
        }
    }
}