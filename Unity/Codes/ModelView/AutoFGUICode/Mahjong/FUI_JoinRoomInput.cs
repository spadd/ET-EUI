/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_JoinRoomInput : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "JoinRoomInput";
        public const string URL = "ui://wtxqw9t3k5s1f9";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_JoinRoomInput CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_JoinRoomInput, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_JoinRoomInput> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_JoinRoomInput> tcs = ETTask<FUI_JoinRoomInput>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_JoinRoomInput, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GButton m_Num1 = null;
        public GButton m_Num2 = null;
        public GButton m_Num3 = null;
        public GButton m_Num4 = null;
        public GButton m_Num5 = null;
        public GButton m_Num6 = null;
        public GButton m_Num7 = null;
        public GButton m_Num8 = null;
        public GButton m_Num9 = null;
        public GButton m_NumReset = null;
        public GButton m_Num0 = null;
        public GButton m_NumDel = null;

        public GButton EGButton_Num1
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
                    this.m_Num1 = (GButton)uiTransform.GetChildAt(0);
                }
                return this.m_Num1;
            }
        }
        public GButton EGButton_Num2
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
                    this.m_Num2 = (GButton)uiTransform.GetChildAt(1);
                }
                return this.m_Num2;
            }
        }
        public GButton EGButton_Num3
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
                    this.m_Num3 = (GButton)uiTransform.GetChildAt(2);
                }
                return this.m_Num3;
            }
        }
        public GButton EGButton_Num4
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
                    this.m_Num4 = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_Num4;
            }
        }
        public GButton EGButton_Num5
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
                    this.m_Num5 = (GButton)uiTransform.GetChildAt(4);
                }
                return this.m_Num5;
            }
        }
        public GButton EGButton_Num6
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
                    this.m_Num6 = (GButton)uiTransform.GetChildAt(5);
                }
                return this.m_Num6;
            }
        }
        public GButton EGButton_Num7
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num7 == null )
                {
                    this.m_Num7 = (GButton)uiTransform.GetChildAt(6);
                }
                return this.m_Num7;
            }
        }
        public GButton EGButton_Num8
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num8 == null )
                {
                    this.m_Num8 = (GButton)uiTransform.GetChildAt(7);
                }
                return this.m_Num8;
            }
        }
        public GButton EGButton_Num9
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num9 == null )
                {
                    this.m_Num9 = (GButton)uiTransform.GetChildAt(8);
                }
                return this.m_Num9;
            }
        }
        public GButton EGButton_NumReset
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_NumReset == null )
                {
                    this.m_NumReset = (GButton)uiTransform.GetChildAt(9);
                }
                return this.m_NumReset;
            }
        }
        public GButton EGButton_Num0
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Num0 == null )
                {
                    this.m_Num0 = (GButton)uiTransform.GetChildAt(10);
                }
                return this.m_Num0;
            }
        }
        public GButton EGButton_NumDel
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_NumDel == null )
                {
                    this.m_NumDel = (GButton)uiTransform.GetChildAt(11);
                }
                return this.m_NumDel;
            }
        }
    }
}