using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_Variable_Editor
{
    public class InstallExe
    {
        public string? Name { get; set; }
        public string? Url { get; set; }
        public string? InCmd { get; set; }
        public string? SavePath { get; set; }

        public InstallExe() { }
        public InstallExe(string? name, string? url, string? inCmd, string? savePath)
        {
            this.Name = name;
            this.Url = url;
            this.InCmd = inCmd;
            this.SavePath = savePath;
        }
    }
}
