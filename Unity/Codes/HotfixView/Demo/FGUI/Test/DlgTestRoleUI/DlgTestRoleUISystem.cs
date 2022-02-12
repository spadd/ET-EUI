using System;
using FairyGUI;

namespace ET
{
    [ObjectSystem]
    public class DlgTestRoleUILoadSystem: LoadSystem<DlgTestRoleUI>
    {
        public override void Load(DlgTestRoleUI self)
        {
            self.RegisterUIEvent();
        }
    }
    public static class DlgTestRoleUISystem
    {
        
        public static void RegisterUIEvent(this DlgTestRoleUI self)
        {
            self.View.EGButton_BtnCreateRole.AddListenerAsync(() =>
            {
                return self.OnCreateRoleClickHandler();
            });
            self.View.EGButton_BtnDelRole.AddListenerAsync(() =>
            {
                return self.OnDeleteRoleClickHandler();
            });
            self.View.EGButton_BtnGoGame.AddListenerAsync(() =>
            {
                return self.OnConfirmClickHandler();
            });
        }

        public static void ShowWindow(this DlgTestRoleUI self, Entity contextData = null)
        {
            self.View.EGList_RoleList.itemRenderer = self.ItemRenderer;
            self.RefreshRoleItems();
            // self.View.EGList_RoleList.SetVirtual();
        }
        
        public static void BeforeUnload(this DlgTestRoleUI self)
        {
            self.View.EGList_RoleList.numItems = 0;
        }
        
        public static void ItemRenderer(this DlgTestRoleUI self,int index, GObject item)
        {
            FUI_Roletem itemEntity = self.GetChild<FUI_Roletem>(index);
            if (itemEntity == null)
            {
                itemEntity = self.AddChildWithId<FUI_Roletem, GObject>(index, item);
            }

            var roleInfo = self.ZoneScene().GetComponent<RoleInfosComponent>().RoleInfos[index];
            itemEntity.EGTextField_Content.text = $"{roleInfo.Name}";
        }

        public static async ETTask OnCreateRoleClickHandler(this DlgTestRoleUI self)
        {
            string name = self.View.EFUI_InputR_InputRole.EGTextInput_input.text;

            if (string.IsNullOrEmpty(name))
            {
                Log.Error("name is null!");
                return;
            }

            try
            {
                int errCode = await LoginHelper.CreateRole(self.ZoneScene(), name);
                if (errCode != ErrorCode.ERR_Success)
                {
                    Log.Error(errCode.ToString());
                    return;
                }

                self.RefreshRoleItems();
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
            
        }
        
        public static async ETTask OnDeleteRoleClickHandler(this DlgTestRoleUI self)
        {
            int index = self.View.EGList_RoleList.selectedIndex;
            if (index == -1)
            {
                Log.Error("请选择要删除的角色");
                return;
            }

            // 对角色Id赋值
            self.ZoneScene().GetComponent<RoleInfosComponent>().CurrentRoleId =
                    self.ZoneScene().GetComponent<RoleInfosComponent>().RoleInfos[index].Id;
            
            if(self.ZoneScene().GetComponent<RoleInfosComponent>().CurrentRoleId == 0)
            {
                Log.Error("请选择要删除的角色");
                return;
            }

            try
            {
                int errCode = await LoginHelper.DeleteRole(self.ZoneScene());
                if (errCode != ErrorCode.ERR_Success)
                {
                    Log.Error(errCode.ToString());
                    return;
                }
                
                // 刷新列表
                self.RefreshRoleItems();
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
        }
        
        public static async ETTask OnConfirmClickHandler(this DlgTestRoleUI self)
        {
            int index = self.View.EGList_RoleList.selectedIndex;
            if (index == -1)
            {
                Log.Error("请选择要进入游戏的角色");
                return;
            }

            // 对角色Id赋值
            self.ZoneScene().GetComponent<RoleInfosComponent>().CurrentRoleId =
                    self.ZoneScene().GetComponent<RoleInfosComponent>().RoleInfos[index].Id;
            
            if(self.ZoneScene().GetComponent<RoleInfosComponent>().CurrentRoleId == 0)
            {
                Log.Error("请选择要进入游戏的角色");
                return;
            }

            try
            {
                int errCode = await LoginHelper.GetRealmKey(self.ZoneScene());
                if (errCode != ErrorCode.ERR_Success)
                {
                    Log.Error(errCode.ToString());
                    return;
                }
                
                
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
            
            await ETTask.CompletedTask;
        }

        public static void RefreshRoleItems(this DlgTestRoleUI self)
        {
            int count = self.ZoneScene().GetComponent<RoleInfosComponent>().RoleInfos.Count;
            self.View.EGList_RoleList.numItems = count;
        }

    }
}