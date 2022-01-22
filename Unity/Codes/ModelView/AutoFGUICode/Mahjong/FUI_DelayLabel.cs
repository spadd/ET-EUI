/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_DelayLabel : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "DelayLabel";
        public const string URL = "ui://wtxqw9t3x82hbh";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_DelayLabel CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_DelayLabel, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_DelayLabel> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_DelayLabel> tcs = ETTask<FUI_DelayLabel>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_DelayLabel, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public Controller m_c1 = null;
        public GTextField m_delay = null;

        public Controller EController_c1
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_c1 == null )
                {
                    this.m_c1 = (Controller)uiTransform.GetControllerAt(0);
                }
                return this.m_c1;
            }
        }
        public GTextField EGTextField_delay
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
                    this.m_delay = (GTextField)uiTransform.GetChildAt(0);
                }
                return this.m_delay;
            }
        }
    }
}