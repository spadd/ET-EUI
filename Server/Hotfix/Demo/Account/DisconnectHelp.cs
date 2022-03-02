﻿using System;

namespace ET
{
    public static class DisconnectHelp
    {
        public static async ETTask Disconnect(this Session self)
        {
            if (self == null || self.IsDisposed)
            {
                return;
            }

            long instanceId = self.InstanceId;

            await TimerComponent.Instance.WaitAsync(1000);

            if (self.InstanceId != instanceId)
            {
                return;
            }
            self.Dispose();
        }

        public static async ETTask KickPlayer(Player player,bool isException = false)
        {
            if (player == null || player.IsDisposed)
            {
                return;
            }

            long instanceId = player.InstanceId;
            using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginGate,player.Account.GetHashCode()))
            {
                if (player.IsDisposed || instanceId != player.InstanceId)
                {
                    return;
                }

                if (!isException)
                {
                    switch (player.PlayerState)
                    {
                        case PlayerState.Disconnect:
                            break;
                        case PlayerState.Gate:
                            break;
                        case PlayerState.Game:
                            // 通知游戏逻辑下线Unit角色逻辑，并将数据存入数据库
                            M2G_RequestExitGame m2GRequestEnterGameState = (M2G_RequestExitGame)await MessageHelper.CallLocationActor(player.UnitId, new G2M_RequestExitGame());
                            // 通知 移除账号角色登录信息
                            long LoginCenterConfigSceneId = StartSceneConfigCategory.Instance.LoginCenterConfig.InstanceId;
                            L2G_RemoveLoginRecord l2GRemoveLoginRecord = (L2G_RemoveLoginRecord)await MessageHelper.CallActor(LoginCenterConfigSceneId,new G2L_RemoveLoginRecord()
                            {
                                AccountId = player.Account,ServerId = player.DomainZone()
                            });
                            break;
                    }
                }

                player.PlayerState = PlayerState.Disconnect;
                player.DomainScene().GetComponent<PlayerComponent>()?.Remove(player.Account);
                player?.Dispose();
                // 防止有异步逻辑 没有处理完没，等待0.3秒
                await TimerComponent.Instance.WaitAsync(300);

            }
        }
    }
}