/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJDeskHead : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJDeskHead";
        public const string URL = "ui://wtxqw9t3x82hb6";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJDeskHead CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJDeskHead, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJDeskHead> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJDeskHead> tcs = ETTask<FUI_MJDeskHead>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJDeskHead, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public Controller m_que = null;
        public GImage m_head_background = null;
        public GTextField m_name = null;
        public GImage m_head = null;
        public GButton m_frame = null;
        public GTextField m_score = null;
        public GImage m_bg = null;
        public GTextField m_id = null;
        public GTextField m_ip = null;
        public GTextField m_chattext = null;
        public GGroup m_message = null;
        public GTextField m_offlinetext = null;
        public GImage m_maker = null;
        public GImage m_ready = null;
        public GImage m_dingque = null;
        public GImage m_queBG = null;
        public GImage m_que_tiao = null;
        public GImage m_que_tong = null;
        public GImage m_que_wan = null;

        public Controller EController_que
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_que == null )
                {
                    this.m_que = (Controller)uiTransform.GetControllerAt(0);
                }
                return this.m_que;
            }
        }
        public GImage EGImage_head_background
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_head_background == null )
                {
                    this.m_head_background = (GImage)uiTransform.GetChildAt(0);
                }
                return this.m_head_background;
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
                    this.m_name = (GTextField)uiTransform.GetChildAt(1);
                }
                return this.m_name;
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
                    this.m_head = (GImage)uiTransform.GetChildAt(2);
                }
                return this.m_head;
            }
        }
        public GButton EGButton_frame
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
                    this.m_frame = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_frame;
            }
        }
        public GTextField EGTextField_score
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_score == null )
                {
                    this.m_score = (GTextField)uiTransform.GetChildAt(4);
                }
                return this.m_score;
            }
        }
        public GImage EGImage_bg
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_bg == null )
                {
                    this.m_bg = (GImage)uiTransform.GetChildAt(5);
                }
                return this.m_bg;
            }
        }
        public GTextField EGTextField_id
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_id == null )
                {
                    this.m_id = (GTextField)uiTransform.GetChildAt(6);
                }
                return this.m_id;
            }
        }
        public GTextField EGTextField_ip
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_ip == null )
                {
                    this.m_ip = (GTextField)uiTransform.GetChildAt(7);
                }
                return this.m_ip;
            }
        }
        public GTextField EGTextField_chattext
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_chattext == null )
                {
                    this.m_chattext = (GTextField)uiTransform.GetChildAt(9);
                }
                return this.m_chattext;
            }
        }
        public GGroup EGGroup_message
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_message == null )
                {
                    this.m_message = (GGroup)uiTransform.GetChildAt(10);
                }
                return this.m_message;
            }
        }
        public GTextField EGTextField_offlinetext
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_offlinetext == null )
                {
                    this.m_offlinetext = (GTextField)uiTransform.GetChildAt(12);
                }
                return this.m_offlinetext;
            }
        }
        public GImage EGImage_maker
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_maker == null )
                {
                    this.m_maker = (GImage)uiTransform.GetChildAt(13);
                }
                return this.m_maker;
            }
        }
        public GImage EGImage_ready
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_ready == null )
                {
                    this.m_ready = (GImage)uiTransform.GetChildAt(14);
                }
                return this.m_ready;
            }
        }
        public GImage EGImage_dingque
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dingque == null )
                {
                    this.m_dingque = (GImage)uiTransform.GetChildAt(15);
                }
                return this.m_dingque;
            }
        }
        public GImage EGImage_queBG
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_queBG == null )
                {
                    this.m_queBG = (GImage)uiTransform.GetChildAt(16);
                }
                return this.m_queBG;
            }
        }
        public GImage EGImage_que_tiao
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_que_tiao == null )
                {
                    this.m_que_tiao = (GImage)uiTransform.GetChildAt(17);
                }
                return this.m_que_tiao;
            }
        }
        public GImage EGImage_que_tong
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_que_tong == null )
                {
                    this.m_que_tong = (GImage)uiTransform.GetChildAt(18);
                }
                return this.m_que_tong;
            }
        }
        public GImage EGImage_que_wan
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_que_wan == null )
                {
                    this.m_que_wan = (GImage)uiTransform.GetChildAt(19);
                }
                return this.m_que_wan;
            }
        }
    }
}