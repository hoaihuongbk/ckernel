using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Web;
using CTool.Lib;
using OMS.Ice.T4Generator;

namespace CTool.Builder.Db
{
    public class ServiceBuilder
    {
        private readonly string _conStr;
        private readonly string _ns;
        public ServiceBuilder(string connStr, string ns)
         {
             _conStr = connStr;
             _ns = !String.IsNullOrEmpty(ns) ? ns.Substring(0, 8).ToUpper() : String.Format("{0:X8}", connStr.GetHashCode()).ToUpper();
             _dddl = String.Format("{0}{1}.dll", _lbdir, _ns);
             _tdddl = String.Format("{0}{1}.dll", _tempDir, _ns);
             _scs = String.Format("{0}S.cs", _lbdir);
         }

        private readonly string _mddl = HttpContext.Current.Server.MapPath("~/ObjectBuilder/cModel.dll");
        private readonly string _kddl = HttpContext.Current.Server.MapPath("~/ObjectBuilder/cKernel.dll");
        private readonly string _dddl;
        

        private readonly string _tempDir = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DBService/");
        private readonly string _tmddl = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DBService/cModel.dll");
        private readonly string _tkddl = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DBService/cKernel.dll");
        private readonly string _tdddl;

        private readonly string _stpl = HttpContext.Current.Server.MapPath("~/Templates/CSharp/S.t4");
        private readonly string _scs;

        private readonly string _lbdir = HttpContext.Current.Server.MapPath("~/ObjectBuilder/");


        public void BuildDBService()
        {
            try
            {
                //Build service class
                IGenerator g = new Generator();
                g.GenerateToFile(_stpl, _scs
                    , new object[] { _ns });

                //Copy kernel lib to object builder
                System.IO.File.Copy(HttpContext.Current.Server.MapPath("~/bin/cModel.dll"), _mddl, true);
                System.IO.File.Copy( HttpContext.Current.Server.MapPath("~/bin/cKernel.dll"), _kddl, true);

                //Build dict and kernel extend dll
                var frameworkPath = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory();
                var cscPath = Path.Combine(frameworkPath, "csc.exe");

                var cmd = new CommandLine();

                var acs = String.Format("{0}*.cs", _lbdir);
                var dcmd = String.Format("/r:{0} /r:{1} /target:library /out:{2} {3}", _mddl, _kddl, _dddl, acs);
                cmd.ExecuteCommandSync(cscPath, dcmd);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        public string ZipDBService( string zipFileName )
        {
            try
            {
                var zipFilePath = HttpContext.Current.Server.MapPath(String.Format("~/ObjectBuilder/{0}.zip", zipFileName));
                
                // Create temp folder
                if (!Directory.Exists(_tempDir))
                {
                    Directory.CreateDirectory(_tempDir);
                }
                if (System.IO.File.Exists(zipFilePath))
                {
                    System.IO.File.Delete(zipFilePath);
                }
                //Copy DLL to temp folder
                System.IO.File.Copy(_mddl, _tmddl, true);
                System.IO.File.Copy(_kddl, _tkddl, true);
                System.IO.File.Copy(_dddl, _tdddl, true);

                //Zip files
                ZipFile.CreateFromDirectory(_tempDir, zipFilePath);

                return zipFilePath;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            return String.Empty;
        }
    }
}