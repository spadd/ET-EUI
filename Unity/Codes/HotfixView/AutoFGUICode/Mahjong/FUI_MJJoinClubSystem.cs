/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJJoinClubAwakeSystem : AwakeSystem<FUI_MJJoinClub>
	{
		public override void Awake(FUI_MJJoinClub self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJJoinClubAwakeSystem1 : AwakeSystem<FUI_MJJoinClub,GObject>
    {
        public override void Awake(FUI_MJJoinClub self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJJoinClubDestroySystem : DestroySystem<FUI_MJJoinClub>
    {
        public override void Destroy(FUI_MJJoinClub self)
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