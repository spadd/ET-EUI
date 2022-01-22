/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJClubAwakeSystem : AwakeSystem<FUI_MJClub>
	{
		public override void Awake(FUI_MJClub self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJClubAwakeSystem1 : AwakeSystem<FUI_MJClub,GObject>
    {
        public override void Awake(FUI_MJClub self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJClubDestroySystem : DestroySystem<FUI_MJClub>
    {
        public override void Destroy(FUI_MJClub self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_BlackView = null;
			self.m_ClubList = null;
			self.m_Empty = null;
			self.m_Apply = null;
			self.m_Ok = null;
			self.m_Close = null;
        }
    }
}