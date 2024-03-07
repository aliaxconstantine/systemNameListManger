using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace System_Variable_Editor
{
    public static class InStallExeFactor
    {

        public static ThreadLocal<List<InstallExe>>? installExes = new ThreadLocal<List<InstallExe>>();
        public static string defaultPath = AppDomain.CurrentDomain.BaseDirectory;

        public static ThreadLocal<List<InstallExe>> GetFactor()
        {
            if(installExes?.Value == null)
            {
                installExes ??= new ThreadLocal<List<InstallExe>>();
                installExes.Value = new List<InstallExe>();
            }
            return installExes;
        }

        //TODO:读取json文件里下载url对象到仓库
        public static void InitCreateFactor(string path)
        {
            if (!Utils.CheckFileExistsWithExtension(path, "json"))
            {
                throw new Exception("文件不存在");
            }
            string jsonText = File.ReadAllText(path);
            JObject json = JObject.Parse(jsonText);
            Dictionary<string, string> properDict = new Dictionary<string, string>();
            foreach (var item in json.Properties())
            {
                if (!item.Value.HasValues)
                {
                    throw new Exception($"{item.Name}属性为空");
                }
                foreach (var child in item.Value)
                {
                    var c = (JProperty)child;
                    if (!child.HasValues)
                    {
                        throw new Exception($"{item.Name}的{c.Name}属性为空");
                    }
                    properDict.Add(c.Name, c.Value.ToString());
                }
                if (!properDict.ContainsKey("url") && !properDict.ContainsKey("cmd"))
                {
                    throw new Exception($"{item.Name}属性有空缺");
                }
                if (properDict["path"] == "" || properDict["path"] == null)
                {
                    properDict["path"] = defaultPath;
                }
                createStallExe(item.Name, properDict["url"], properDict["cmd"], properDict["path"]);
                properDict.Clear();
            }
        }
        public static InstallExe createStallExe(string name, string url, string cmd, string path)
        {
            var exe = new InstallExe(name, url, cmd, path);
            var e = GetFactor().Value;
            if (e != null)
            {
                e.Add(exe);
            }
            return exe;
        }

        //TODO:从仓库读取对象存储到json文件


    }
}
