/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_TestServerListUI : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "TestH";
        public const string UIResName = "TestServerListUI";
        public const string URL = "ui://5jb64ecmo5nx8";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_TestServerListUI CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_TestServerListUI, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_TestServerListUI> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_TestServerListUI> tcs = ETTask<FUI_TestServerListUI>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_TestServerListUI, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_title = null;
        public GList m_ServerList = null;
        public GButton m_BtnSelect = null;

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
        public GList EGList_ServerList
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_ServerList == null )
                {
                    this.m_ServerList = (GList)uiTransform.GetChildAt(2);
                }
                return this.m_ServerList;
            }
        }
        public GButton EGButton_BtnSelect
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_BtnSelect == null )
                {
                    this.m_BtnSelect = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_BtnSelect;
            }
        }
    }
}