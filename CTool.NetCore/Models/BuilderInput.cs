using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CTool.NetCore.Models
{
    public class BuilderInput
    {
        public string Host { get; set; }
        public string DBName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Namespace { get; set; }
        public string[] SelectedTable { get; set; }
        public string[] SelectedView { get; set; }
        public string[] SelectedSp { get; set; }
    }
}
