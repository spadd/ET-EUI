/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_Roletem : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "TestH";
        public const string UIResName = "Roletem";
        public const string URL = "ui://5jb64ecmo5nxb";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_Roletem CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_Roletem, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_Roletem> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_Roletem> tcs = ETTask<FUI_Roletem>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_Roletem, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GButton uiTransform = null;
        public GGraph m_ItemBg = null;
        public GGraph m_ItemSelectBg = null;
        public GTextField m_Content = null;

        public GGraph EGGraph_ItemBg
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_ItemBg == null )
                {
                    this.m_ItemBg = (GGraph)uiTransform.GetChildAt(0);
                }
                return this.m_ItemBg;
            }
        }
        public GGraph EGGraph_ItemSelectBg
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_ItemSelectBg == null )
                {
                    this.m_ItemSelectBg = (GGraph)uiTransform.GetChildAt(1);
                }
                return this.m_ItemSelectBg;
            }
        }
        public GTextField EGTextField_Content
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Content == null )
                {
                    this.m_Content = (GTextField)uiTransform.GetChildAt(2);
                }
                return this.m_Content;
            }
        }
    }
}