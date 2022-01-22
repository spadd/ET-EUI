/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_TestHUI : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "TestH";
        public const string UIResName = "TestHUI";
        public const string URL = "ui://5jb64ecmbaih0";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_TestHUI CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_TestHUI, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_TestHUI> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_TestHUI> tcs = ETTask<FUI_TestHUI>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_TestHUI, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_title = null;
        public FUI_InputA m_account = null;
        public FUI_InputP m_password = null;
        public GButton m_register = null;
        public GButton m_login = null;
        public GTextField m_tip = null;
        public GTextField m_version = null;

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
                    this.m_title = (GTextField)uiTransform.GetChildAt(0);
                }
                return this.m_title;
            }
        }
        public FUI_InputA EFUI_InputA_account
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_account == null )
                {
                    this.m_account = this.AddChild<FUI_InputA, GObject>(uiTransform.GetChildAt(1));
                }
                return this.m_account;
            }
        }
        public FUI_InputP EFUI_InputP_password
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_password == null )
                {
                    this.m_password = this.AddChild<FUI_InputP, GObject>(uiTransform.GetChildAt(2));
                }
                return this.m_password;
            }
        }
        public GButton EGButton_register
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_register == null )
                {
                    this.m_register = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_register;
            }
        }
        public GButton EGButton_login
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_login == null )
                {
                    this.m_login = (GButton)uiTransform.GetChildAt(4);
                }
                return this.m_login;
            }
        }
        public GTextField EGTextField_tip
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_tip == null )
                {
                    this.m_tip = (GTextField)uiTransform.GetChildAt(5);
                }
                return this.m_tip;
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
                    this.m_version = (GTextField)uiTransform.GetChildAt(6);
                }
                return this.m_version;
            }
        }
    }
}