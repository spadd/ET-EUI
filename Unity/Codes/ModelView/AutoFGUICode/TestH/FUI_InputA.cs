/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_InputA : Entity,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "TestH";
        public const string UIResName = "InputA";
        public const string URL = "ui://5jb64ecmbaih2";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_InputA CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_InputA, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_InputA> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_InputA> tcs = ETTask<FUI_InputA>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_InputA, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_title = null;
        public GTextInput m_input = null;

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
        public GTextInput EGTextInput_input
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_input == null )
                {
                    this.m_input = (GTextInput)uiTransform.GetChildAt(2);
                }
                return this.m_input;
            }
        }
    }
}