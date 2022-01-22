/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJDissolveHead : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJDissolveHead";
        public const string URL = "ui://wtxqw9t3c17ybm";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJDissolveHead CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJDissolveHead, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJDissolveHead> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJDissolveHead> tcs = ETTask<FUI_MJDissolveHead>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJDissolveHead, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GImage m_frame = null;
        public GImage m_head = null;
        public GTextField m_name = null;
        public GImage m_status_background = null;
        public GTextField m_status = null;

        public GImage EGImage_frame
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_frame == null )
                {
                    this.m_frame = (GImage)uiTransform.GetChildAt(0);
                }
                return this.m_frame;
            }
        }
        public GImage EGImage_head
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_head == null )
                {
                    this.m_head = (GImage)uiTransform.GetChildAt(1);
                }
                return this.m_head;
            }
        }
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
        public GImage EGImage_status_background
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_status_background == null )
                {
                    this.m_status_background = (GImage)uiTransform.GetChildAt(3);
                }
                return this.m_status_background;
            }
        }
        public GTextField EGTextField_status
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_status == null )
                {
                    this.m_status = (GTextField)uiTransform.GetChildAt(4);
                }
                return this.m_status;
            }
        }
    }
}