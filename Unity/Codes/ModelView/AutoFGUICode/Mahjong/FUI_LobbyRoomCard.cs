/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_LobbyRoomCard : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "LobbyRoomCard";
        public const string URL = "ui://wtxqw9t3k5s1ey";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_LobbyRoomCard CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_LobbyRoomCard, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_LobbyRoomCard> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_LobbyRoomCard> tcs = ETTask<FUI_LobbyRoomCard>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_LobbyRoomCard, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GButton m_AddRoomCard = null;
        public GTextField m_CardCnt = null;

        public GButton EGButton_AddRoomCard
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_AddRoomCard == null )
                {
                    this.m_AddRoomCard = (GButton)uiTransform.GetChildAt(1);
                }
                return this.m_AddRoomCard;
            }
        }
        public GTextField EGTextField_CardCnt
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_CardCnt == null )
                {
                    this.m_CardCnt = (GTextField)uiTransform.GetChildAt(3);
                }
                return this.m_CardCnt;
            }
        }
    }
}