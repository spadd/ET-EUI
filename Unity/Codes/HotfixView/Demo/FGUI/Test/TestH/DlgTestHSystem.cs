using System;

namespace ET
{
    [ObjectSystem]
    public class DlgTestHLoadSystem: LoadSystem<DlgTestH>
    {
        public override void Load(DlgTestH self)
        {
            self.RegisterUIEvent();
        }
    }

    public static class DlgTestHSystem
    {
        public static void RegisterUIEvent(this DlgTestH self)
        {
            self.View.EFUI_InputA_account.EGTextInput_input.text = "Uw123456";
            self.View.EFUI_InputP_password.EGTextInput_input.text = "Uw123456";
            self.View.EGButton_login.AddListenerAsync(() =>
            {
                return self.OnLoginClick();
            });

            self.View.EGButton_register.AddListener(() =>
            {
                self.OnRegisterClick();
            });
        }

        public static void ShowWindow(this DlgTestH self, Entity contextData = null)
        {
            self.View.EGTextField_tip.text = "设置内容试试";
        }

        public static async  ETTask OnLoginClick(this DlgTestH self)
        {
            string account = self.View.EFUI_InputA_account.EGTextInput_input.text;
            string password = self.View.EFUI_InputP_password.EGTextInput_input.text;

            Log.Info($"OnLoginClick account={account} password={password}");

            try
            {
                int errCode = await LoginHelper.Login(self.DomainScene(),
                    ConstValue.LoginAddress,
                    account,
                    password);

                self.SetTip(errCode);
                if (errCode != ErrorCode.ERR_Success)
                {
                    Log.Error(errCode.ToString());
                    return;
                }
                
                // 获取区服表
                errCode = await LoginHelper.GetServerInfo(self.ZoneScene());
                if (errCode != ErrorCode.ERR_Success)
                {
                    Log.Error(errCode.ToString());
                    return;
                }
                
                // 显示登录之后的页面逻辑
                FGUIComponent fguiComponent = self.DomainScene().GetComponent<FGUIComponent>();
                fguiComponent.CloseWindow(FUI_TestHUI.UIResName);
                await fguiComponent.ShowWindowAsync(FUI_TestServerListUI.UIPackageName,FUI_TestServerListUI.UIResName);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
        }
        public static void OnRegisterClick(this DlgTestH self)
        {
            string account = self.View.EFUI_InputA_account.EGTextInput_input.text;
            string password = self.View.EFUI_InputP_password.EGTextInput_input.text;
            Log.Info($"OnRegisterClick account={account} password={password}");
            Game.EventSystem.PublishAsync(new EventType.LoginFinishTest() {ZoneScene = self.DomainScene()}).Coroutine();
        }

        public static void SetTip(this DlgTestH self,int errCode)
        {
            switch (@errCode)
            {
                case ErrorCode.ERR_LoginInfoIsNull:
                    self.View.EGTextField_tip.text = "tips:账号或密码为空";
                    break;
                case ErrorCode.ERR_AccountNameFormError:
                    self.View.EGTextField_tip.text = "tips:登录账号格式错误";
                    break;
                case ErrorCode.ERR_PasswordFormError:
                    self.View.EGTextField_tip.text = "tips:登录密码格式错误";
                    break;
                case ErrorCode.ERR_AccountInBlackListError:
                    self.View.EGTextField_tip.text = "tips:账号处于黑名单";
                    break;
                case ErrorCode.ERR_LoginPasswordError:
                    self.View.EGTextField_tip.text = "tips:账号密码错误";
                    break;
                case ErrorCode.RequestRepeatedly:
                    self.View.EGTextField_tip.text = "tips:请求重复";
                    break;
                case ErrorCode.ERR_NetWorkError:
                    self.View.EGTextField_tip.text = "tips:网络错误";
                    break;
                case ErrorCode.ERR_Success:
                    self.View.EGTextField_tip.text = "tips:登录成功";
                    break;
                default:
                    self.View.EGTextField_tip.text = $"tips:未知错误 code = {errCode}！";
                    break;
            }
            
            
        }

    }
}