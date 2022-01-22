/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_LobbyBoardAwakeSystem : AwakeSystem<FUI_LobbyBoard>
	{
		public override void Awake(FUI_LobbyBoard self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_LobbyBoardAwakeSystem1 : AwakeSystem<FUI_LobbyBoard,GObject>
    {
        public override void Awake(FUI_LobbyBoard self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_LobbyBoardDestroySystem : DestroySystem<FUI_LobbyBoard>
    {
        public override void Destroy(FUI_LobbyBoard self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_Msg = null;
        }
    }
}