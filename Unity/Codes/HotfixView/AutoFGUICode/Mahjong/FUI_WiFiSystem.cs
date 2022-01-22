/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;
namespace ET
{
    [ObjectSystem]
	public class FUI_WiFiAwakeSystem : AwakeSystem<FUI_WiFi>
	{
		public override void Awake(FUI_WiFi self)
		{
			self.GObject = self.GetParent<FGUIBaseWindow>().UIPrefabGameObject;
			self.uiTransform = self.GObject.asCom;
		}
	}

    [ObjectSystem]
    public class FUI_WiFiAwakeSystem1 : AwakeSystem<FUI_WiFi,GObject>
    {
        public override void Awake(FUI_WiFi self,GObject transform)
        {
            self.GObject = transform;
            self.uiTransform = transform.asCom;
        }
    }

    [ObjectSystem]
    public class FUI_WiFiDestroySystem : DestroySystem<FUI_WiFi>
    {
        public override void Destroy(FUI_WiFi self)
        {
            self.GObject?.Dispose();
            self.GObject = null;
            self.uiTransform = null;
			self.m_c1 = null;
        }
    }
}