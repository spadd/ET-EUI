using System;
using FairyGUI;

namespace ET
{
    
    [ObjectSystem]
    public class DlgTestServerListUILoadSystem: LoadSystem<DlgTestServerListUI>
    {
        public override void Load(DlgTestServerListUI self)
        {
            self.RegisterUIEvent();
        }
    }
    public static class DlgTestServerListUISystem
    {


        public static void RegisterUIEvent(this DlgTestServerListUI self)
        {
            self.View.EGButton_BtnSelect.AddListenerAsync(() =>
            {
                return self.OnSelectClick();
            });
        }

        public static void ShowWindow(this DlgTestServerListUI self, Entity contextData = null)
        {
            self.View.EGList_ServerList.itemRenderer = self.ItemRenderer;

            int count =  self.ZoneScene().GetComponent<ServerInfosComponent>().ServerInfoList.Count;
            
            // self.View.EGList_ServerList.SetVirtual();
            self.View.EGList_ServerList.numItems = count;
            self.View.EGList_ServerList.onClickItem.Set(self.OnClickItem);
            
        }
        
        public static void BeforeUnload(this DlgTestServerListUI self)
        {
            self.View.EGList_ServerList.numItems = 0;
        }

        public static async ETTask OnSelectClick(this DlgTestServerListUI self)
        {
            if (self.View.EGList_ServerList.selectedIndex == -1)
            {
                Log.Error("未选择区服！");
                return;
            }

            int index = self.View.EGList_ServerList.selectedIndex;
            var serverInfo = self.ZoneScene().GetComponent<ServerInfosComponent>().ServerInfoList[index];
            self.ZoneScene().GetComponent<ServerInfosComponent>().CurrentServerId = int.Parse(serverInfo.Id.ToString());
            Log.Info($"当前选择的区服ID是 {serverInfo.Id} 名字是 ：{serverInfo.ServerName}");

            try
            {
                int errCode = await LoginHelper.GetRoles(self.ZoneScene());
                if (errCode != ErrorCode.ERR_Success)
                {
                    Log.Error(errCode.ToString());
                    return;
                }
                
                // 切换UI
                FGUIComponent fguiComponent = self.DomainScene().GetComponent<FGUIComponent>();
                fguiComponent.CloseWindow(FUI_TestServerListUI.UIResName);
                await fguiComponent.ShowWindowAsync(FUI_TestRoleUI.UIPackageName,FUI_TestRoleUI.UIResName);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
        }

        public static void ItemRenderer(this DlgTestServerListUI self,int index, GObject item)
        {
            // 测试点击事件
            item.data = index;
            
            FUI_ServerItem itemEntity = self.GetChild<FUI_ServerItem>(index);
            if (itemEntity == null)
            {
                itemEntity = self.AddChildWithId<FUI_ServerItem, GObject>(index, item);
            }

            var serverInfo = self.ZoneScene().GetComponent<ServerInfosComponent>().ServerInfoList[index];
            string statue = serverInfo.Status == (int)ServerStatus.Normal ? "[color=#00FF00][正常][/color]" : "[color=#FF0000][维护][/color]";
            itemEntity.EGTextField_Content.text = $"{statue} {serverInfo.ServerName}";
        }
        
        public static void OnClickItem(this DlgTestServerListUI self,EventContext context)
        {
            int index = (int)((GButton) context.data).data;
            Log.Info($"{index}点击");
        }

    }
}