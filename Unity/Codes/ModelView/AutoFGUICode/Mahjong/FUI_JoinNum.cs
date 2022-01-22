/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_JoinNum : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "JoinNum";
        public const string URL = "ui://wtxqw9t3k5s1f4";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_JoinNum CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_JoinNum, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_JoinNum> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_JoinNum> tcs = ETTask<FUI_JoinNum>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_JoinNum, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_Num = null;

        public GTextField EGTextField_Num
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num == null )
                {
                    this.m_Num = (GTextField)uiTransform.GetChildAt(1);
                }
                return this.m_Num;
            }
        }
    }
}