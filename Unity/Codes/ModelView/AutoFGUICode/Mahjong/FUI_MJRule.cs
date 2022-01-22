/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJRule : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJRule";
        public const string URL = "ui://wtxqw9t3k5s1fb";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJRule CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJRule, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJRule> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJRule> tcs = ETTask<FUI_MJRule>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJRule, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GButton m_Close = null;

        public GButton EGButton_Close
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Close == null )
                {
                    this.m_Close = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_Close;
            }
        }
    }
}