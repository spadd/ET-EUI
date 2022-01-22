﻿namespace ET
{
    public static class TokenComponentSystem
    {
        public static void Add(this TokenComponent self,long key,string token)
        {
            self.TokenDictionary.Add(key,token);
            self.TimeOutRemoveKey(key,token).Coroutine();
        }

        public static string Get(this TokenComponent self, long key)
        {
            string value = null;

            self.TokenDictionary.TryGetValue(key, out value);
            return value;
        }

        public static void Remove(this TokenComponent self, long key)
        {
            if (self.TokenDictionary.ContainsKey(key))
            {
                self.TokenDictionary.Remove(key);
            }
        }

        public static async ETTask TimeOutRemoveKey(this TokenComponent self, long key,string token)
        {
            // 十分钟后删除令牌
            await TimerComponent.Instance.WaitAsync(600000);

            string onlineToken = self.Get(key);
            if (!string.IsNullOrEmpty(onlineToken) && onlineToken == token)
            {
                self.Remove(key);   
            }
        }

    }
}