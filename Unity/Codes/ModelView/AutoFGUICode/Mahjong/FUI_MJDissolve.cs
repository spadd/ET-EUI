/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJDissolve : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJDissolve";
        public const string URL = "ui://wtxqw9t3c17ybj";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJDissolve CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJDissolve, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJDissolve> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJDissolve> tcs = ETTask<FUI_MJDissolve>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJDissolve, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GButton m_yes = null;
        public GButton m_no = null;
        public GTextField m_text = null;
        public GList m_list = null;

        public GButton EGButton_yes
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_yes == null )
                {
                    this.m_yes = (GButton)uiTransform.GetChildAt(2);
                }
                return this.m_yes;
            }
        }
        public GButton EGButton_no
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_no == null )
                {
                    this.m_no = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_no;
            }
        }
        public GTextField EGTextField_text
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_text == null )
                {
                    this.m_text = (GTextField)uiTransform.GetChildAt(5);
                }
                return this.m_text;
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
                    this.m_list = (GList)uiTransform.GetChildAt(6);
                }
                return this.m_list;
            }
        }
    }
}