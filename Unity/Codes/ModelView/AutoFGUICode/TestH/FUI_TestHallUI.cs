/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_TestHallUI : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "TestH";
        public const string UIResName = "TestHallUI";
        public const string URL = "ui://5jb64ecmkvck4";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_TestHallUI CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_TestHallUI, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_TestHallUI> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_TestHallUI> tcs = ETTask<FUI_TestHallUI>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_TestHallUI, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_title = null;
        public GTextField m_tip = null;
        public GTextField m_UserInfo = null;
        public GButton m_EnterMj = null;
        public GButton m_EnterMMO = null;

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
                    this.m_title = (GTextField)uiTransform.GetChildAt(1);
                }
                return this.m_title;
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
                    this.m_tip = (GTextField)uiTransform.GetChildAt(2);
                }
                return this.m_tip;
            }
        }
        public GTextField EGTextField_UserInfo
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_UserInfo == null )
                {
                    this.m_UserInfo = (GTextField)uiTransform.GetChildAt(3);
                }
                return this.m_UserInfo;
            }
        }
        public GButton EGButton_EnterMj
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_EnterMj == null )
                {
                    this.m_EnterMj = (GButton)uiTransform.GetChildAt(4);
                }
                return this.m_EnterMj;
            }
        }
        public GButton EGButton_EnterMMO
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_EnterMMO == null )
                {
                    this.m_EnterMMO = (GButton)uiTransform.GetChildAt(5);
                }
                return this.m_EnterMMO;
            }
        }
    }
}