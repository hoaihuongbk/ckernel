using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Web;
using OMS.Ice.T4Generator;

namespace CTool.Builder.CSharp
{
    public class DotNetWebServiceBuilder
    {
        private readonly Dictionary<string, string> _tpl = new Dictionary<string, string>
        {
            {"asmx", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Templates\CSharp\DotNetService\Asmx.t4") },
            {"asmx.cs", Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Templates\CSharp\DotNetService\Asmx.Cs.t4") }
        };

        public void BuildWebService()
        {
            try
            {
                const string nameSpace = "cService";
                const string serviceName = "cWebService";
                var asmxPath = String.Format(@"{0}\\ObjectBuilder\{1}.asmx",
                    HttpContext.Current.Request.PhysicalApplicationPath, serviceName);
                var asmxCsPath = String.Format(@"{0}\\ObjectBuilder\{1}.asmx.cs",
                    HttpContext.Current.Request.PhysicalApplicationPath, serviceName);

                IGenerator g = new Generator();
                g.GenerateToFile(_tpl["asmx"], asmxPath, new object[] {nameSpace, serviceName});
                g.GenerateToFile(_tpl["asmx.cs"], asmxCsPath, new object[] {nameSpace, serviceName});
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}