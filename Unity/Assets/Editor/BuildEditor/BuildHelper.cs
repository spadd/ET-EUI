﻿using System.IO;

using UnityEditor;
using UnityEngine;

namespace ET
{
    public static class BuildHelper
    {
        private const string relativeDirPrefix = "../Release";

        public static string BuildFolder = "../Release/{0}/StreamingAssets/";

        public static void Build(PlatformType type, BuildAssetBundleOptions buildAssetBundleOptions, BuildOptions buildOptions, bool isBuildExe, bool isContainAB, bool clearFolder)
        {
            BuildTarget buildTarget = BuildTarget.StandaloneWindows;
            string programName = "ET";
            string exeName = programName;
            switch (type)
            {
                case PlatformType.PC:
                    buildTarget = BuildTarget.StandaloneWindows64;
                    exeName += ".exe";
                    break;
                case PlatformType.Android:
                    buildTarget = BuildTarget.Android;
                    exeName += ".apk";
                    break;
                case PlatformType.IOS:
                    buildTarget = BuildTarget.iOS;
                    break;
                case PlatformType.MacOS:
                    buildTarget = BuildTarget.StandaloneOSX;
                    break;
            }

            string fold = string.Format(BuildFolder, type);

            if (clearFolder && Directory.Exists(fold))
            {
                Directory.Delete(fold, true);
                Directory.CreateDirectory(fold);
            }
            else
            {
                Directory.CreateDirectory(fold);
            }

            UnityEngine.Debug.Log("开始资源打包");
            BuildPipeline.BuildAssetBundles(fold, buildAssetBundleOptions, buildTarget);

            //生成各个版本的分支文件
            GenerateVersionInfo(fold);
            UnityEngine.Debug.Log("完成资源打包");

            if (isContainAB)
            {
                FileHelper.CleanDirectory("Assets/StreamingAssets/");
                FileHelper.CopyDirectory(fold, "Assets/StreamingAssets/");
            }

            if (isBuildExe)
            {
                AssetDatabase.Refresh();
                string[] levels = {
                    "Assets/Scenes/Init.unity",
                };
                UnityEngine.Debug.Log("开始EXE打包");
                BuildPipeline.BuildPlayer(levels, $"{relativeDirPrefix}/{exeName}", buildTarget, buildOptions);
                UnityEngine.Debug.Log("完成exe打包");
            }
            // else
            // {
            //     if (isContainAB && type == PlatformType.PC)
            //     {
            //         string targetPath = Path.Combine(relativeDirPrefix, $"{programName}_Data/StreamingAssets/");
            //         FileHelper.CleanDirectory(targetPath);
            //         Debug.Log($"src dir: {fold}    target: {targetPath}");
            //         FileHelper.CopyDirectory(fold, targetPath);
            //     }
            // }
        }
        
        private static void GenerateVersionInfo(string dir)
        {
            VersionConfig versionProto = new VersionConfig();
            GenerateVersionProto(dir, versionProto, "");

            using (FileStream fileStream = new FileStream($"{dir}/Version.txt", FileMode.Create))
            {
                byte[] bytes = JsonHelper.ToJson(versionProto).ToByteArray();
                fileStream.Write(bytes, 0, bytes.Length);
            }
        }
        
        private static void GenerateVersionProto(string dir, VersionConfig versionProto, string relativePath)
        {
            foreach (string file in Directory.GetFiles(dir))
            {
                string md5 = MD5Helper.FileMD5(file);
                FileInfo fi = new FileInfo(file);
                long size = fi.Length;
                string filePath = relativePath == "" ? fi.Name : $"{relativePath}/{fi.Name}";

                versionProto.FileInfoDict.Add(filePath, new FileVersionInfo
                {
                    File = filePath,
                    MD5 = md5,
                    Size = size,
                });
            }

            foreach (string directory in Directory.GetDirectories(dir))
            {
                DirectoryInfo dinfo = new DirectoryInfo(directory);
                GenerateToGameVersionProto(directory, dinfo.Name);
            }
        }
        
        //每单个游戏都有个version
        public static void GenerateToGameVersionProto(string dir,string dirName)
        {
            VersionConfig versionProto=new VersionConfig();
            foreach (string file in Directory.GetFiles(dir))
            {
                string md5 = MD5Helper.FileMD5(file);
                FileInfo fi = new FileInfo(file);
                long size = fi.Length;
                versionProto.FileInfoDict.Add(fi.Name, new FileVersionInfo
                {
                    File = fi.Name,
                    MD5 = md5,
                    Size = size,
                });
            }
            string versionPath = dir + "/" + dirName + "Version.txt";
            using (FileStream fileStream = new FileStream(versionPath, FileMode.Create))
            {
                byte[] bytes = JsonHelper.ToJson(versionProto).ToByteArray();
                fileStream.Write(bytes, 0, bytes.Length);
            }

        }

        
        
    }
}
