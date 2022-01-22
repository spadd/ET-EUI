/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJClubItem : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJClubItem";
        public const string URL = "ui://wtxqw9t3x82haz";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJClubItem CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJClubItem, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJClubItem> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJClubItem> tcs = ETTask<FUI_MJClubItem>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJClubItem, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_name = null;
        public GTextField m_member_count = null;
        public GTextField m_club_id = null;
        public GButton m_create = null;
        public GTextField m_desc = null;

        public GTextField EGTextField_name
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_name == null )
                {
                    this.m_name = (GTextField)uiTransform.GetChildAt(2);
                }
                return this.m_name;
            }
        }
        public GTextField EGTextField_member_count
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_member_count == null )
                {
                    this.m_member_count = (GTextField)uiTransform.GetChildAt(3);
                }
                return this.m_member_count;
            }
        }
        public GTextField EGTextField_club_id
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_club_id == null )
                {
                    this.m_club_id = (GTextField)uiTransform.GetChildAt(4);
                }
                return this.m_club_id;
            }
        }
        public GButton EGButton_create
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_create == null )
                {
                    this.m_create = (GButton)uiTransform.GetChildAt(5);
                }
                return this.m_create;
            }
        }
        public GTextField EGTextField_desc
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_desc == null )
                {
                    this.m_desc = (GTextField)uiTransform.GetChildAt(6);
                }
                return this.m_desc;
            }
        }
    }
}