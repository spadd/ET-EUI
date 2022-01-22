/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJCreateRoom : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJCreateRoom";
        public const string URL = "ui://wtxqw9t3x82hb2";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJCreateRoom CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJCreateRoom, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJCreateRoom> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJCreateRoom> tcs = ETTask<FUI_MJCreateRoom>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJCreateRoom, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public Controller m_mode = null;
        public Controller m_round = null;
        public Controller m_max_fan = null;
        public Controller m_zimo = null;
        public Controller m_rules = null;
        public GButton m_close = null;
        public GButton m_create = null;
        public GButton m_m3 = null;
        public GButton m_m4 = null;
        public GButton m_r4 = null;
        public GButton m_r8 = null;
        public GButton m_f3 = null;
        public GButton m_f4 = null;
        public GButton m_f5 = null;
        public GButton m_fan = null;
        public GButton m_di = null;
        public GButton m_yaojiu = null;
        public GButton m_menqing = null;
        public GButton m_pengpeng = null;
        public GButton m_jiaxin = null;
        public GButton m_jiangdui = null;
        public GButton m_pinghu = null;

        public Controller EController_mode
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_mode == null )
                {
                    this.m_mode = (Controller)uiTransform.GetControllerAt(0);
                }
                return this.m_mode;
            }
        }
        public Controller EController_round
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_round == null )
                {
                    this.m_round = (Controller)uiTransform.GetControllerAt(1);
                }
                return this.m_round;
            }
        }
        public Controller EController_max_fan
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_max_fan == null )
                {
                    this.m_max_fan = (Controller)uiTransform.GetControllerAt(2);
                }
                return this.m_max_fan;
            }
        }
        public Controller EController_zimo
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_zimo == null )
                {
                    this.m_zimo = (Controller)uiTransform.GetControllerAt(3);
                }
                return this.m_zimo;
            }
        }
        public Controller EController_rules
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_rules == null )
                {
                    this.m_rules = (Controller)uiTransform.GetControllerAt(4);
                }
                return this.m_rules;
            }
        }
        public GButton EGButton_close
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_close == null )
                {
                    this.m_close = (GButton)uiTransform.GetChildAt(2);
                }
                return this.m_close;
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
                    this.m_create = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_create;
            }
        }
        public GButton EGButton_m3
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_m3 == null )
                {
                    this.m_m3 = (GButton)uiTransform.GetChildAt(4);
                }
                return this.m_m3;
            }
        }
        public GButton EGButton_m4
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_m4 == null )
                {
                    this.m_m4 = (GButton)uiTransform.GetChildAt(5);
                }
                return this.m_m4;
            }
        }
        public GButton EGButton_r4
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_r4 == null )
                {
                    this.m_r4 = (GButton)uiTransform.GetChildAt(6);
                }
                return this.m_r4;
            }
        }
        public GButton EGButton_r8
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_r8 == null )
                {
                    this.m_r8 = (GButton)uiTransform.GetChildAt(7);
                }
                return this.m_r8;
            }
        }
        public GButton EGButton_f3
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_f3 == null )
                {
                    this.m_f3 = (GButton)uiTransform.GetChildAt(8);
                }
                return this.m_f3;
            }
        }
        public GButton EGButton_f4
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_f4 == null )
                {
                    this.m_f4 = (GButton)uiTransform.GetChildAt(9);
                }
                return this.m_f4;
            }
        }
        public GButton EGButton_f5
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_f5 == null )
                {
                    this.m_f5 = (GButton)uiTransform.GetChildAt(10);
                }
                return this.m_f5;
            }
        }
        public GButton EGButton_fan
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_fan == null )
                {
                    this.m_fan = (GButton)uiTransform.GetChildAt(11);
                }
                return this.m_fan;
            }
        }
        public GButton EGButton_di
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_di == null )
                {
                    this.m_di = (GButton)uiTransform.GetChildAt(12);
                }
                return this.m_di;
            }
        }
        public GButton EGButton_yaojiu
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_yaojiu == null )
                {
                    this.m_yaojiu = (GButton)uiTransform.GetChildAt(13);
                }
                return this.m_yaojiu;
            }
        }
        public GButton EGButton_menqing
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_menqing == null )
                {
                    this.m_menqing = (GButton)uiTransform.GetChildAt(14);
                }
                return this.m_menqing;
            }
        }
        public GButton EGButton_pengpeng
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_pengpeng == null )
                {
                    this.m_pengpeng = (GButton)uiTransform.GetChildAt(15);
                }
                return this.m_pengpeng;
            }
        }
        public GButton EGButton_jiaxin
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_jiaxin == null )
                {
                    this.m_jiaxin = (GButton)uiTransform.GetChildAt(16);
                }
                return this.m_jiaxin;
            }
        }
        public GButton EGButton_jiangdui
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_jiangdui == null )
                {
                    this.m_jiangdui = (GButton)uiTransform.GetChildAt(17);
                }
                return this.m_jiangdui;
            }
        }
        public GButton EGButton_pinghu
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_pinghu == null )
                {
                    this.m_pinghu = (GButton)uiTransform.GetChildAt(18);
                }
                return this.m_pinghu;
            }
        }
    }
}