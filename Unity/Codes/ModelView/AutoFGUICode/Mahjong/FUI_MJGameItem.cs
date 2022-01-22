/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJGameItem : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJGameItem";
        public const string URL = "ui://wtxqw9t3c17ybq";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJGameItem CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJGameItem, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJGameItem> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJGameItem> tcs = ETTask<FUI_MJGameItem>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJGameItem, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GTextField m_zimoScore = null;
        public GTextField m_huScore = null;
        public GTextField m_paoScore = null;
        public GTextField m_mingScore = null;
        public GTextField m_anScore = null;
        public GGroup m_scoreGroup = null;
        public GTextField m_name = null;
        public GTextField m_id = null;
        public GImage m_headIcon = null;
        public GImage m_owner = null;
        public GImage m_winner = null;
        public GImage m_loser = null;
        public GTextField m_total = null;

        public GTextField EGTextField_zimoScore
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_zimoScore == null )
                {
                    this.m_zimoScore = (GTextField)uiTransform.GetChildAt(1);
                }
                return this.m_zimoScore;
            }
        }
        public GTextField EGTextField_huScore
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_huScore == null )
                {
                    this.m_huScore = (GTextField)uiTransform.GetChildAt(2);
                }
                return this.m_huScore;
            }
        }
        public GTextField EGTextField_paoScore
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_paoScore == null )
                {
                    this.m_paoScore = (GTextField)uiTransform.GetChildAt(3);
                }
                return this.m_paoScore;
            }
        }
        public GTextField EGTextField_mingScore
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_mingScore == null )
                {
                    this.m_mingScore = (GTextField)uiTransform.GetChildAt(4);
                }
                return this.m_mingScore;
            }
        }
        public GTextField EGTextField_anScore
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_anScore == null )
                {
                    this.m_anScore = (GTextField)uiTransform.GetChildAt(5);
                }
                return this.m_anScore;
            }
        }
        public GGroup EGGroup_scoreGroup
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_scoreGroup == null )
                {
                    this.m_scoreGroup = (GGroup)uiTransform.GetChildAt(6);
                }
                return this.m_scoreGroup;
            }
        }
        public GTextField EGTextField_name
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_name == null )
                {
                    this.m_name = (GTextField)uiTransform.GetChildAt(7);
                }
                return this.m_name;
            }
        }
        public GTextField EGTextField_id
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_id == null )
                {
                    this.m_id = (GTextField)uiTransform.GetChildAt(8);
                }
                return this.m_id;
            }
        }
        public GImage EGImage_headIcon
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_headIcon == null )
                {
                    this.m_headIcon = (GImage)uiTransform.GetChildAt(9);
                }
                return this.m_headIcon;
            }
        }
        public GImage EGImage_owner
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_owner == null )
                {
                    this.m_owner = (GImage)uiTransform.GetChildAt(10);
                }
                return this.m_owner;
            }
        }
        public GImage EGImage_winner
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_winner == null )
                {
                    this.m_winner = (GImage)uiTransform.GetChildAt(11);
                }
                return this.m_winner;
            }
        }
        public GImage EGImage_loser
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_loser == null )
                {
                    this.m_loser = (GImage)uiTransform.GetChildAt(12);
                }
                return this.m_loser;
            }
        }
        public GTextField EGTextField_total
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_total == null )
                {
                    this.m_total = (GTextField)uiTransform.GetChildAt(13);
                }
                return this.m_total;
            }
        }
    }
}