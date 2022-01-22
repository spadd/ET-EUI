/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_LobbyBoard : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "LobbyBoard";
        public const string URL = "ui://wtxqw9t3k5s1f1";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_LobbyBoard CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_LobbyBoard, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_LobbyBoard> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_LobbyBoard> tcs = ETTask<FUI_LobbyBoard>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_LobbyBoard, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_Msg = null;

        public GTextField EGTextField_Msg
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Msg == null )
                {
                    this.m_Msg = (GTextField)uiTransform.GetChildAt(2);
                }
                return this.m_Msg;
            }
        }
    }
}