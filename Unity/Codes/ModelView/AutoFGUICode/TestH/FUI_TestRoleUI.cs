/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_TestRoleUI : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "TestH";
        public const string UIResName = "TestRoleUI";
        public const string URL = "ui://5jb64ecmo5nxa";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_TestRoleUI CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_TestRoleUI, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_TestRoleUI> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_TestRoleUI> tcs = ETTask<FUI_TestRoleUI>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_TestRoleUI, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_title = null;
        public GList m_RoleList = null;
        public FUI_InputR m_InputRole = null;
        public GButton m_BtnDelRole = null;
        public GButton m_BtnCreateRole = null;
        public GButton m_BtnGoGame = null;

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
        public GList EGList_RoleList
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_RoleList == null )
                {
                    this.m_RoleList = (GList)uiTransform.GetChildAt(2);
                }
                return this.m_RoleList;
            }
        }
        public FUI_InputR EFUI_InputR_InputRole
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_InputRole == null )
                {
                    this.m_InputRole = this.AddChild<FUI_InputR, GObject>(uiTransform.GetChildAt(3));
                }
                return this.m_InputRole;
            }
        }
        public GButton EGButton_BtnDelRole
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_BtnDelRole == null )
                {
                    this.m_BtnDelRole = (GButton)uiTransform.GetChildAt(4);
                }
                return this.m_BtnDelRole;
            }
        }
        public GButton EGButton_BtnCreateRole
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_BtnCreateRole == null )
                {
                    this.m_BtnCreateRole = (GButton)uiTransform.GetChildAt(5);
                }
                return this.m_BtnCreateRole;
            }
        }
        public GButton EGButton_BtnGoGame
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_BtnGoGame == null )
                {
                    this.m_BtnGoGame = (GButton)uiTransform.GetChildAt(6);
                }
                return this.m_BtnGoGame;
            }
        }
    }
}