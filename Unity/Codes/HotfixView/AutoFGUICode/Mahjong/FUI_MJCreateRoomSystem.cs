/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_MJCreateRoomAwakeSystem : AwakeSystem<FUI_MJCreateRoom>
	{
		public override void Awake(FUI_MJCreateRoom self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_MJCreateRoomAwakeSystem1 : AwakeSystem<FUI_MJCreateRoom,GObject>
    {
        public override void Awake(FUI_MJCreateRoom self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_MJCreateRoomDestroySystem : DestroySystem<FUI_MJCreateRoom>
    {
        public override void Destroy(FUI_MJCreateRoom self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_mode = null;
			self.m_round = null;
			self.m_max_fan = null;
			self.m_zimo = null;
			self.m_rules = null;
			self.m_close = null;
			self.m_create = null;
			self.m_m3 = null;
			self.m_m4 = null;
			self.m_r4 = null;
			self.m_r8 = null;
			self.m_f3 = null;
			self.m_f4 = null;
			self.m_f5 = null;
			self.m_fan = null;
			self.m_di = null;
			self.m_yaojiu = null;
			self.m_menqing = null;
			self.m_pengpeng = null;
			self.m_jiaxin = null;
			self.m_jiangdui = null;
			self.m_pinghu = null;
        }
    }
}