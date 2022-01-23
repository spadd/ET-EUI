using System.Collections.Generic;
using FairyGUI;
using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class FUIPackageComponentAwakeSystem: AwakeSystem<FUIPackageComponent>
    {
        public override void Awake(FUIPackageComponent self)
        {
            FUIPackageComponent.Instance = self;
        }
    }

    public class FUIPackageComponent : Entity,IAwake
    {
        public static FUIPackageComponent Instance = null;
        
        public const string FUI_PACKAGE_DIR = "Assets/Bundles/FGUI";

        public Dictionary<string, UIPackage> packages = new Dictionary<string, UIPackage>();
        public List<string> loadingPkg = new List<string>();

        public void AddPackage(string type)
        {
            type = type.ToLower();
            if (packages.ContainsKey(type))
            {
                Log.Debug($"{type}包已经加载");
                return;
            }

            if (Define.IsEditor)
            {
                UIPackage uiPackage = UIPackage.AddPackage($"{FUI_PACKAGE_DIR}/{type}");
                
                packages.Add(type, uiPackage);
            }
            else
            {
                string uiBundleDesName = $"{type}_fui".StringToAB();
                string uiBundleResName = type.StringToAB();

                ResourcesComponent resourcesComponent = ResourcesComponent.Instance;
                resourcesComponent.LoadBundle(uiBundleDesName);
                resourcesComponent.LoadBundle(uiBundleResName);
            
                AssetBundle desAssetBundle = resourcesComponent.GetAssetBundle(uiBundleDesName);
                AssetBundle resAssetBundle = resourcesComponent.GetAssetBundle(uiBundleResName);
                UIPackage uiPackage = UIPackage.AddPackage(desAssetBundle, resAssetBundle);
                
                packages.Add(type, uiPackage);
            }
        }

        public async ETTask AddPackageAsync(string type)
        {
            type = type.ToLower();
            if (loadingPkg.IndexOf(type) != -1 || packages.ContainsKey(type))
            {
                Log.Debug($"{type}包已经加载");
                return;
            }
            if (Define.IsEditor)
            {
                UIPackage uiPackage = UIPackage.AddPackage($"{FUI_PACKAGE_DIR}/{type}");
                
                packages.Add(type, uiPackage);
            }
            else
            {
                loadingPkg.Add(type);
                
                string uiBundleDesName = $"{type}_fui".StringToAB();
                string uiBundleResName = type.StringToAB();

                ResourcesComponent resourcesComponent = ResourcesComponent.Instance;
                await resourcesComponent.LoadBundleAsync(uiBundleDesName);
                await resourcesComponent.LoadBundleAsync(uiBundleResName);
                
                AssetBundle desAssetBundle = resourcesComponent.GetAssetBundle(uiBundleDesName);
                AssetBundle resAssetBundle = resourcesComponent.GetAssetBundle(uiBundleResName);
                UIPackage uiPackage = UIPackage.AddPackage(desAssetBundle, resAssetBundle);
                
                packages.Add(type, uiPackage);
                
                loadingPkg.Remove(type);
            }
        }

        public void RemovePackage(string type)
        {
            type = type.ToLower();
            if (!packages.ContainsKey(type))
            {
                Log.Debug($"{type}包已经卸载");
                return;
            }
            UIPackage package;
            
            if(packages.TryGetValue(type, out package))
            {
                var p = UIPackage.GetByName(package.name);

                if (p != null)
                {
                    UIPackage.RemovePackage(package.name);
                }

                packages.Remove(package.name);
            }

            if (!Define.IsEditor)
            {
                string uiBundleDesName = $"{type}_fui".StringToAB();
                string uiBundleResName = type.StringToAB();
                
                ResourcesComponent resourcesComponent = ResourcesComponent.Instance;
                resourcesComponent.UnloadBundle(uiBundleDesName);
                resourcesComponent.UnloadBundle(uiBundleResName);
            }
        }
        
        public async ETTask RemovePackageAsync(string type)
        {
            type = type.ToLower();
            if (!packages.ContainsKey(type))
            {
                Log.Debug($"{type}包已经卸载");
                return;
            }
            
            UIPackage package;
            
            if(packages.TryGetValue(type, out package))
            {
                var p = UIPackage.GetByName(package.name);

                if (p != null)
                {
                    UIPackage.RemovePackage(package.name);
                }

                packages.Remove(package.name);
            }

            if (!Define.IsEditor)
            {
                string uiBundleDesName = $"{type}_fui".StringToAB();
                string uiBundleResName = type.StringToAB();
                
                ResourcesComponent resourcesComponent = ResourcesComponent.Instance;
                await resourcesComponent.UnloadBundleAsync(uiBundleDesName);
                await resourcesComponent.UnloadBundleAsync(uiBundleResName);
            }
        }

        public async ETTask<GObject> CreateGo(string packageName,string res)
        {
            ETTask<GObject> tcs = ETTask<GObject>.Create(true);
            UIPackage.CreateObjectAsync(packageName,res, (go) =>
            {
                tcs.SetResult(go);
            });
            return await tcs;
        }


    }
}