/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJClub : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJClub";
        public const string URL = "ui://wtxqw9t3x82hax";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJClub CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJClub, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJClub> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJClub> tcs = ETTask<FUI_MJClub>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJClub, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GComponent m_BlackView = null;
        public GList m_ClubList = null;
        public GImage m_Empty = null;
        public GButton m_Apply = null;
        public GButton m_Ok = null;
        public GButton m_Close = null;

        public GComponent EGComponent_BlackView
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_BlackView == null )
                {
                    this.m_BlackView = (GComponent)uiTransform.GetChildAt(0);
                }
                return this.m_BlackView;
            }
        }
        public GList EGList_ClubList
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_ClubList == null )
                {
                    this.m_ClubList = (GList)uiTransform.GetChildAt(2);
                }
                return this.m_ClubList;
            }
        }
        public GImage EGImage_Empty
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Empty == null )
                {
                    this.m_Empty = (GImage)uiTransform.GetChildAt(3);
                }
                return this.m_Empty;
            }
        }
        public GButton EGButton_Apply
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Apply == null )
                {
                    this.m_Apply = (GButton)uiTransform.GetChildAt(4);
                }
                return this.m_Apply;
            }
        }
        public GButton EGButton_Ok
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Ok == null )
                {
                    this.m_Ok = (GButton)uiTransform.GetChildAt(5);
                }
                return this.m_Ok;
            }
        }
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
                    this.m_Close = (GButton)uiTransform.GetChildAt(6);
                }
                return this.m_Close;
            }
        }
    }
}