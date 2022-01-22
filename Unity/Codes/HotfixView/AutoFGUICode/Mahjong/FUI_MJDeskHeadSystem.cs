/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJDeskHeadAwakeSystem : AwakeSystem<FUI_MJDeskHead>
	{
		public override void Awake(FUI_MJDeskHead self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJDeskHeadAwakeSystem1 : AwakeSystem<FUI_MJDeskHead,GObject>
    {
        public override void Awake(FUI_MJDeskHead self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJDeskHeadDestroySystem : DestroySystem<FUI_MJDeskHead>
    {
        public override void Destroy(FUI_MJDeskHead self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_que = null;
			self.m_head_background = null;
			self.m_name = null;
			self.m_head = null;
			self.m_frame = null;
			self.m_score = null;
			self.m_bg = null;
			self.m_id = null;
			self.m_ip = null;
			self.m_chattext = null;
			self.m_message = null;
			self.m_offlinetext = null;
			self.m_maker = null;
			self.m_ready = null;
			self.m_dingque = null;
			self.m_queBG = null;
			self.m_que_tiao = null;
			self.m_que_tong = null;
			self.m_que_wan = null;
        }
    }
}