/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJJoinClub : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJJoinClub";
        public const string URL = "ui://wtxqw9t3k5s1fa";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJJoinClub CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJJoinClub, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJJoinClub> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJJoinClub> tcs = ETTask<FUI_MJJoinClub>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJJoinClub, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GButton m_Close = null;
        public FUI_JoinRoomNums m_JoinNums = null;
        public FUI_JoinRoomInput m_JoinInput = null;

        public GButton EGButton_Close
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Close == null )
                {
                    this.m_Close = (GButton)uiTransform.GetChildAt(2);
                }
                return this.m_Close;
            }
        }
        public FUI_JoinRoomNums EFUI_JoinRoomNums_JoinNums
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_JoinNums == null )
                {
                    this.m_JoinNums = this.AddChild<FUI_JoinRoomNums, GObject>(uiTransform.GetChildAt(4));
                }
                return this.m_JoinNums;
            }
        }
        public FUI_JoinRoomInput EFUI_JoinRoomInput_JoinInput
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_JoinInput == null )
                {
                    this.m_JoinInput = this.AddChild<FUI_JoinRoomInput, GObject>(uiTransform.GetChildAt(5));
                }
                return this.m_JoinInput;
            }
        }
    }
}