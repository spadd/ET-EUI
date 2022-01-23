using System.IO;
using UnityEditor;

namespace ET
{
    public class FileServerRun
    {
        [MenuItem("Tools/web资源服务器")]
        public static void OpenFileServer()
        {
#if !UNITY_EDITOR_OSX
            string currentDir = System.Environment.CurrentDirectory;
            string path = Path.Combine(currentDir, @"..\Bin\");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.FileName = "FileServer.exe";
            process.StartInfo.WorkingDirectory = path;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
#else
			string path = System.Environment.CurrentDirectory + "/../Bin/";
			("cd " + path + " && go run FileServer.go").Bash(path, true);
#endif
        }
    }
}