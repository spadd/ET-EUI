/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_LobbyUserInfo : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "LobbyUserInfo";
        public const string URL = "ui://wtxqw9t3k5s1ez";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_LobbyUserInfo CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_LobbyUserInfo, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_LobbyUserInfo> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_LobbyUserInfo> tcs = ETTask<FUI_LobbyUserInfo>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_LobbyUserInfo, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_Nickname = null;
        public GTextField m_UId = null;

        public GTextField EGTextField_Nickname
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Nickname == null )
                {
                    this.m_Nickname = (GTextField)uiTransform.GetChildAt(1);
                }
                return this.m_Nickname;
            }
        }
        public GTextField EGTextField_UId
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_UId == null )
                {
                    this.m_UId = (GTextField)uiTransform.GetChildAt(2);
                }
                return this.m_UId;
            }
        }
    }
}