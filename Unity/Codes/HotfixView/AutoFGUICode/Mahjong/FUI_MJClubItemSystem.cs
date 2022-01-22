/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJClubItemAwakeSystem : AwakeSystem<FUI_MJClubItem>
	{
		public override void Awake(FUI_MJClubItem self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJClubItemAwakeSystem1 : AwakeSystem<FUI_MJClubItem,GObject>
    {
        public override void Awake(FUI_MJClubItem self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJClubItemDestroySystem : DestroySystem<FUI_MJClubItem>
    {
        public override void Destroy(FUI_MJClubItem self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_name = null;
			self.m_member_count = null;
			self.m_club_id = null;
			self.m_create = null;
			self.m_desc = null;
        }
    }
}