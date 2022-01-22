/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_WiFi : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "WiFi";
        public const string URL = "ui://wtxqw9t3x82hbg";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_WiFi CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_WiFi, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_WiFi> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_WiFi> tcs = ETTask<FUI_WiFi>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_WiFi, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public Controller m_c1 = null;

        public Controller EController_c1
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_c1 == null )
                {
                    this.m_c1 = (Controller)uiTransform.GetControllerAt(0);
                }
                return this.m_c1;
            }
        }
    }
}