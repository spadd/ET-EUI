using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;
using System.IO;
using ET;
using UnityEngine;

namespace ClientEditor
{
    class UIEditorController
    {
        public static string unity3dEx = ".unity3d";
        
        [MenuItem("GameObject/SpawnEUICode", false, -2)]
        static public void CreateNewCode()
        {
            GameObject go = Selection.activeObject as GameObject;
            UICodeSpawner.SpawnEUICode(go);
        }

        [MenuItem("Assets/AssetBundle/NameUIPrefab")]
        public static void NameAllUIPrefab()
        {
            UnityEngine.Object[] selectAsset = Selection.GetFiltered<UnityEngine.Object>(SelectionMode.DeepAssets);
            for (int i = 0; i < selectAsset.Length; i++)
            {
                string prefabName = AssetDatabase.GetAssetPath(selectAsset[i]);
                //MARKER：判断是否是.prefab
                if (prefabName.EndsWith(".prefab"))
                {
                    Debug.Log(prefabName);
                    AssetImporter importer = AssetImporter.GetAtPath(prefabName);
                    importer.assetBundleName = selectAsset[i].name.ToLower() + unity3dEx;
                }

            }
            AssetDatabase.Refresh();
            AssetDatabase.RemoveUnusedAssetBundleNames();
        }
        
        [MenuItem("Assets/AssetBundle/FguiABName")]
        public static void SetSelectionFUIABName()
        {
            var gameObjects = Selection.objects;

            foreach (var go in gameObjects)
            {
                AssetImporter assetImporter = AssetImporter.GetAtPath(AssetDatabase.GetAssetPath(go.GetInstanceID()));

                if (go.name.Contains("fui"))
                {
                    assetImporter.assetBundleName = $"{go.name.ToLower()}{unity3dEx}";
                }
                else
                {
                    var texts = go.name.Split('_');

                    if(texts != null && texts.Length > 0)
                    {
                        assetImporter.assetBundleName = $"{texts[0].ToLower()}{unity3dEx}";
                    }
                }
            }
            
            AssetDatabase.Refresh();
            AssetDatabase.RemoveUnusedAssetBundleNames();
        }

        [MenuItem("Assets/AssetBundle/ClearABName")]
        public static void ClearABName()
        {
            UnityEngine.Object[] selectAsset = Selection.GetFiltered<UnityEngine.Object>(SelectionMode.DeepAssets);
            for (int i = 0; i < selectAsset.Length; i++)
            {
                string prefabName = AssetDatabase.GetAssetPath(selectAsset[i]);
                AssetImporter importer = AssetImporter.GetAtPath(prefabName);
                importer.assetBundleName = string.Empty;
                Debug.Log(prefabName);
            }
            AssetDatabase.Refresh();
            AssetDatabase.RemoveUnusedAssetBundleNames();
        }
    }
}
