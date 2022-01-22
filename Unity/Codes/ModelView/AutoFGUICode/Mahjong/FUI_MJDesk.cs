/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJDesk : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJDesk";
        public const string URL = "ui://wtxqw9t3x82hb9";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJDesk CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJDesk, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJDesk> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJDesk> tcs = ETTask<FUI_MJDesk>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJDesk, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GButton m_setting = null;
        public GButton m_exit = null;
        public GButton m_voice = null;
        public GButton m_voiceMessage = null;
        public GButton m_share_no = null;
        public GButton m_wechat = null;
        public FUI_WiFi m_wifi = null;
        public GTextField m_timeLabel = null;
        public GTextField m_batteryTxt = null;
        public GImage m_batteryImg = null;
        public FUI_DelayLabel m_delay = null;
        public GTextField m_label = null;
        public GTextField m_rule = null;
        public GTextField m_version = null;
        public GGraph m_dir1Start = null;
        public GGraph m_dir2Start = null;
        public GGraph m_dir3Start = null;
        public GGraph m_dir4Start = null;
        public GGraph m_dir1Hu = null;
        public GGraph m_dir2Hu = null;
        public GGraph m_dir3Hu = null;
        public GGraph m_dir4Hu = null;
        public GGraph m_gangEffect4 = null;
        public GGraph m_gangEffect3 = null;
        public GGraph m_gangEffect2 = null;
        public GGraph m_gangEffect1 = null;

        public GButton EGButton_setting
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_setting == null )
                {
                    this.m_setting = (GButton)uiTransform.GetChildAt(0);
                }
                return this.m_setting;
            }
        }
        public GButton EGButton_exit
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_exit == null )
                {
                    this.m_exit = (GButton)uiTransform.GetChildAt(1);
                }
                return this.m_exit;
            }
        }
        public GButton EGButton_voice
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_voice == null )
                {
                    this.m_voice = (GButton)uiTransform.GetChildAt(2);
                }
                return this.m_voice;
            }
        }
        public GButton EGButton_voiceMessage
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_voiceMessage == null )
                {
                    this.m_voiceMessage = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_voiceMessage;
            }
        }
        public GButton EGButton_share_no
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_share_no == null )
                {
                    this.m_share_no = (GButton)uiTransform.GetChildAt(4);
                }
                return this.m_share_no;
            }
        }
        public GButton EGButton_wechat
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_wechat == null )
                {
                    this.m_wechat = (GButton)uiTransform.GetChildAt(5);
                }
                return this.m_wechat;
            }
        }
        public FUI_WiFi EFUI_WiFi_wifi
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_wifi == null )
                {
                    this.m_wifi = this.AddChild<FUI_WiFi, GObject>(uiTransform.GetChildAt(6));
                }
                return this.m_wifi;
            }
        }
        public GTextField EGTextField_timeLabel
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_timeLabel == null )
                {
                    this.m_timeLabel = (GTextField)uiTransform.GetChildAt(7);
                }
                return this.m_timeLabel;
            }
        }
        public GTextField EGTextField_batteryTxt
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_batteryTxt == null )
                {
                    this.m_batteryTxt = (GTextField)uiTransform.GetChildAt(8);
                }
                return this.m_batteryTxt;
            }
        }
        public GImage EGImage_batteryImg
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_batteryImg == null )
                {
                    this.m_batteryImg = (GImage)uiTransform.GetChildAt(9);
                }
                return this.m_batteryImg;
            }
        }
        public FUI_DelayLabel EFUI_DelayLabel_delay
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_delay == null )
                {
                    this.m_delay = this.AddChild<FUI_DelayLabel, GObject>(uiTransform.GetChildAt(10));
                }
                return this.m_delay;
            }
        }
        public GTextField EGTextField_label
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_label == null )
                {
                    this.m_label = (GTextField)uiTransform.GetChildAt(11);
                }
                return this.m_label;
            }
        }
        public GTextField EGTextField_rule
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_rule == null )
                {
                    this.m_rule = (GTextField)uiTransform.GetChildAt(12);
                }
                return this.m_rule;
            }
        }
        public GTextField EGTextField_version
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_version == null )
                {
                    this.m_version = (GTextField)uiTransform.GetChildAt(13);
                }
                return this.m_version;
            }
        }
        public GGraph EGGraph_dir1Start
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dir1Start == null )
                {
                    this.m_dir1Start = (GGraph)uiTransform.GetChildAt(14);
                }
                return this.m_dir1Start;
            }
        }
        public GGraph EGGraph_dir2Start
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dir2Start == null )
                {
                    this.m_dir2Start = (GGraph)uiTransform.GetChildAt(15);
                }
                return this.m_dir2Start;
            }
        }
        public GGraph EGGraph_dir3Start
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dir3Start == null )
                {
                    this.m_dir3Start = (GGraph)uiTransform.GetChildAt(16);
                }
                return this.m_dir3Start;
            }
        }
        public GGraph EGGraph_dir4Start
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dir4Start == null )
                {
                    this.m_dir4Start = (GGraph)uiTransform.GetChildAt(17);
                }
                return this.m_dir4Start;
            }
        }
        public GGraph EGGraph_dir1Hu
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dir1Hu == null )
                {
                    this.m_dir1Hu = (GGraph)uiTransform.GetChildAt(18);
                }
                return this.m_dir1Hu;
            }
        }
        public GGraph EGGraph_dir2Hu
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dir2Hu == null )
                {
                    this.m_dir2Hu = (GGraph)uiTransform.GetChildAt(19);
                }
                return this.m_dir2Hu;
            }
        }
        public GGraph EGGraph_dir3Hu
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dir3Hu == null )
                {
                    this.m_dir3Hu = (GGraph)uiTransform.GetChildAt(20);
                }
                return this.m_dir3Hu;
            }
        }
        public GGraph EGGraph_dir4Hu
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_dir4Hu == null )
                {
                    this.m_dir4Hu = (GGraph)uiTransform.GetChildAt(21);
                }
                return this.m_dir4Hu;
            }
        }
        public GGraph EGGraph_gangEffect4
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_gangEffect4 == null )
                {
                    this.m_gangEffect4 = (GGraph)uiTransform.GetChildAt(22);
                }
                return this.m_gangEffect4;
            }
        }
        public GGraph EGGraph_gangEffect3
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_gangEffect3 == null )
                {
                    this.m_gangEffect3 = (GGraph)uiTransform.GetChildAt(23);
                }
                return this.m_gangEffect3;
            }
        }
        public GGraph EGGraph_gangEffect2
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_gangEffect2 == null )
                {
                    this.m_gangEffect2 = (GGraph)uiTransform.GetChildAt(24);
                }
                return this.m_gangEffect2;
            }
        }
        public GGraph EGGraph_gangEffect1
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_gangEffect1 == null )
                {
                    this.m_gangEffect1 = (GGraph)uiTransform.GetChildAt(25);
                }
                return this.m_gangEffect1;
            }
        }
    }
}