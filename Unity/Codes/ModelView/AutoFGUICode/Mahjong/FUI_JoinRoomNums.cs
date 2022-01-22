/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_JoinRoomNums : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "JoinRoomNums";
        public const string URL = "ui://wtxqw9t3k5s1f5";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_JoinRoomNums CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_JoinRoomNums, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_JoinRoomNums> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_JoinRoomNums> tcs = ETTask<FUI_JoinRoomNums>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_JoinRoomNums, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public FUI_JoinNum m_Num1 = null;
        public FUI_JoinNum m_Num2 = null;
        public FUI_JoinNum m_Num3 = null;
        public FUI_JoinNum m_Num4 = null;
        public FUI_JoinNum m_Num5 = null;
        public FUI_JoinNum m_Num6 = null;

        public FUI_JoinNum EFUI_JoinNum_Num1
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num1 == null )
                {
                    this.m_Num1 = this.AddChild<FUI_JoinNum, GObject>(uiTransform.GetChildAt(1));
                }
                return this.m_Num1;
            }
        }
        public FUI_JoinNum EFUI_JoinNum_Num2
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num2 == null )
                {
                    this.m_Num2 = this.AddChild<FUI_JoinNum, GObject>(uiTransform.GetChildAt(2));
                }
                return this.m_Num2;
            }
        }
        public FUI_JoinNum EFUI_JoinNum_Num3
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num3 == null )
                {
                    this.m_Num3 = this.AddChild<FUI_JoinNum, GObject>(uiTransform.GetChildAt(3));
                }
                return this.m_Num3;
            }
        }
        public FUI_JoinNum EFUI_JoinNum_Num4
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num4 == null )
                {
                    this.m_Num4 = this.AddChild<FUI_JoinNum, GObject>(uiTransform.GetChildAt(4));
                }
                return this.m_Num4;
            }
        }
        public FUI_JoinNum EFUI_JoinNum_Num5
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num5 == null )
                {
                    this.m_Num5 = this.AddChild<FUI_JoinNum, GObject>(uiTransform.GetChildAt(5));
                }
                return this.m_Num5;
            }
        }
        public FUI_JoinNum EFUI_JoinNum_Num6
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num6 == null )
                {
                    this.m_Num6 = this.AddChild<FUI_JoinNum, GObject>(uiTransform.GetChildAt(6));
                }
                return this.m_Num6;
            }
        }
    }
}