/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJGameEnd : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJGameEnd";
        public const string URL = "ui://wtxqw9t3c17ybn";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJGameEnd CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJGameEnd, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJGameEnd> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJGameEnd> tcs = ETTask<FUI_MJGameEnd>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJGameEnd, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GImage m_container = null;
        public GTextField m_title = null;
        public GTextField m_desc = null;
        public GTextField m_timestamp = null;
        public GList m_list = null;
        public GButton m_cancel = null;
        public GButton m_share = null;

        public GImage EGImage_container
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_container == null )
                {
                    this.m_container = (GImage)uiTransform.GetChildAt(1);
                }
                return this.m_container;
            }
        }
        public GTextField EGTextField_title
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_title == null )
                {
                    this.m_title = (GTextField)uiTransform.GetChildAt(2);
                }
                return this.m_title;
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
                    this.m_desc = (GTextField)uiTransform.GetChildAt(3);
                }
                return this.m_desc;
            }
        }
        public GTextField EGTextField_timestamp
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_timestamp == null )
                {
                    this.m_timestamp = (GTextField)uiTransform.GetChildAt(4);
                }
                return this.m_timestamp;
            }
        }
        public GList EGList_list
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_list == null )
                {
                    this.m_list = (GList)uiTransform.GetChildAt(5);
                }
                return this.m_list;
            }
        }
        public GButton EGButton_cancel
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_cancel == null )
                {
                    this.m_cancel = (GButton)uiTransform.GetChildAt(6);
                }
                return this.m_cancel;
            }
        }
        public GButton EGButton_share
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_share == null )
                {
                    this.m_share = (GButton)uiTransform.GetChildAt(7);
                }
                return this.m_share;
            }
        }
    }
}