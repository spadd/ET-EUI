/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJGameItemAwakeSystem : AwakeSystem<FUI_MJGameItem>
	{
		public override void Awake(FUI_MJGameItem self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJGameItemAwakeSystem1 : AwakeSystem<FUI_MJGameItem,GObject>
    {
        public override void Awake(FUI_MJGameItem self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJGameItemDestroySystem : DestroySystem<FUI_MJGameItem>
    {
        public override void Destroy(FUI_MJGameItem self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_zimoScore = null;
			self.m_huScore = null;
			self.m_paoScore = null;
			self.m_mingScore = null;
			self.m_anScore = null;
			self.m_scoreGroup = null;
			self.m_name = null;
			self.m_id = null;
			self.m_headIcon = null;
			self.m_owner = null;
			self.m_winner = null;
			self.m_loser = null;
			self.m_total = null;
        }
    }
}