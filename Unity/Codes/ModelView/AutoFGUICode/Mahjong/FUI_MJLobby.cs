/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace ET
{
    public class FUI_MJLobby : Entity,IAwake,IAwake<GObject>,IDestroy
    {
        public const string UIPackageName = "Mahjong";
        public const string UIResName = "MJLobby";
        public const string URL = "ui://wtxqw9t3eu5bbr";

        private static GObject CreateGObject()
        {
            return UIPackage.CreateObject(UIPackageName, UIResName);
        }

        private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
        {
            UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
        }

        public static FUI_MJLobby CreateInstance(Entity domain)
        {
            return domain.AddChild<FUI_MJLobby, GObject>(CreateGObject());
        }

        public static async ETTask<FUI_MJLobby> CreateInstanceAsync(Entity domain)
        {
            ETTask<FUI_MJLobby> tcs = ETTask<FUI_MJLobby>.Create(true);
            CreateGObjectAsync((go) =>
            {
                tcs.SetResult(domain.AddChild<FUI_MJLobby, GObject>(go));
            });
            return await tcs;
        }

        public GObject GObject = null;
        public GComponent uiTransform = null;
        public GButton m_CreateRoom = null;
        public GButton m_JoinRoom = null;
        public GButton m_Club = null;
        public GButton m_History = null;
        public GButton m_Rule = null;
        public FUI_LobbyRoomCard m_RoomCard = null;
        public FUI_LobbyUserInfo m_UserInfo = null;
        public FUI_LobbyBoard m_Board = null;

        public GButton EGButton_CreateRoom
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_CreateRoom == null )
                {
                    this.m_CreateRoom = (GButton)uiTransform.GetChildAt(3);
                }
                return this.m_CreateRoom;
            }
        }
        public GButton EGButton_JoinRoom
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_JoinRoom == null )
                {
                    this.m_JoinRoom = (GButton)uiTransform.GetChildAt(4);
                }
                return this.m_JoinRoom;
            }
        }
        public GButton EGButton_Club
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Club == null )
                {
                    this.m_Club = (GButton)uiTransform.GetChildAt(5);
                }
                return this.m_Club;
            }
        }
        public GButton EGButton_History
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_History == null )
                {
                    this.m_History = (GButton)uiTransform.GetChildAt(6);
                }
                return this.m_History;
            }
        }
        public GButton EGButton_Rule
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Rule == null )
                {
                    this.m_Rule = (GButton)uiTransform.GetChildAt(7);
                }
                return this.m_Rule;
            }
        }
        public FUI_LobbyRoomCard EFUI_LobbyRoomCard_RoomCard
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_RoomCard == null )
                {
                    this.m_RoomCard = this.AddChild<FUI_LobbyRoomCard, GObject>(uiTransform.GetChildAt(8));
                }
                return this.m_RoomCard;
            }
        }
        public FUI_LobbyUserInfo EFUI_LobbyUserInfo_UserInfo
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_UserInfo == null )
                {
                    this.m_UserInfo = this.AddChild<FUI_LobbyUserInfo, GObject>(uiTransform.GetChildAt(9));
                }
                return this.m_UserInfo;
            }
        }
        public FUI_LobbyBoard EFUI_LobbyBoard_Board
        {
            get
            {
                if (this.uiTransform == null)
                {
                    Log.Error("uiTransform is null.");
                    return null;
                }
                if( this.m_Board == null )
                {
                    this.m_Board = this.AddChild<FUI_LobbyBoard, GObject>(uiTransform.GetChildAt(10));
                }
                return this.m_Board;
            }
        }
    }
}