/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJDeskAwakeSystem : AwakeSystem<FUI_MJDesk>
	{
		public override void Awake(FUI_MJDesk self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJDeskAwakeSystem1 : AwakeSystem<FUI_MJDesk,GObject>
    {
        public override void Awake(FUI_MJDesk self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJDeskDestroySystem : DestroySystem<FUI_MJDesk>
    {
        public override void Destroy(FUI_MJDesk self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_setting = null;
			self.m_exit = null;
			self.m_voice = null;
			self.m_voiceMessage = null;
			self.m_share_no = null;
			self.m_wechat = null;
			self.m_wifi?.Dispose();
			self.m_wifi = null;
			self.m_timeLabel = null;
			self.m_batteryTxt = null;
			self.m_batteryImg = null;
			self.m_delay?.Dispose();
			self.m_delay = null;
			self.m_label = null;
			self.m_rule = null;
			self.m_version = null;
			self.m_dir1Start = null;
			self.m_dir2Start = null;
			self.m_dir3Start = null;
			self.m_dir4Start = null;
			self.m_dir1Hu = null;
			self.m_dir2Hu = null;
			self.m_dir3Hu = null;
			self.m_dir4Hu = null;
			self.m_gangEffect4 = null;
			self.m_gangEffect3 = null;
			self.m_gangEffect2 = null;
			self.m_gangEffect1 = null;
        }
    }
}