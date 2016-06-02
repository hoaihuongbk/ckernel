using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.IO.Compression;
using System.Web.UI.WebControls;
using CTool.Builder.File;
using OMS.Ice.T4Generator;
using System.Data;

namespace CTool.Builder.Db
{
    public class DbBuilder
    {
        private readonly string _conStr;
        private readonly string _ns;

        private readonly string _d = HttpContext.Current.Server.MapPath("~/ObjectBuilder/D.cs");
        private readonly string _p = HttpContext.Current.Server.MapPath("~/ObjectBuilder/P.cs");
        private readonly string _de = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DE.cs");
        private readonly string _pe = HttpContext.Current.Server.MapPath("~/ObjectBuilder/PE.cs");
        
        
        private readonly string _tempDir = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DBDict/");
        private readonly string _td = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DBDict/D.cs");
        private readonly string _tp = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DBDict/P.cs");
        private readonly string _tde = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DBDict/DE.cs");
        private readonly string _tpe = HttpContext.Current.Server.MapPath("~/ObjectBuilder/DBDict/PE.cs");

        private readonly string _lbdir = HttpContext.Current.Server.MapPath("~/ObjectBuilder/");
        private readonly string _modelDir = HttpContext.Current.Server.MapPath("~/ObjectBuilder/Models/");

        public DbBuilder(string connStr, string ns = "")
        {
            _conStr = connStr;
            _ns = !String.IsNullOrEmpty(ns) ? ns.Substring(0,8).ToUpper() : String.Format("{0:X8}", connStr.GetHashCode()).ToUpper();
        }

        /// <summary>
        /// Build all dictionary files
        /// d: main dictionary, p: function dictionary, o: javascript dictionary
        /// </summary>
        public void BuildDBDictionary(List<ListItem> slTbl = null, List<ListItem> slV = null, List<ListItem> slSP = null)
        {
            try
            {
                //Get file format
                const string dScope =
                    "using System.Collections.Generic;\r\n namespace _{2}\r\n{{\r\n    public class D\r\n    {{\r\n        {0}\r\n        {1}\r\n    }}\r\n}}";
                const string aFormat =
                    "// 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function \r\n\t\tpublic static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  {{ \r\n{0}\t\t}};";
                const string aItemFormat =
                    "\t\t\t//{0}\r\n\t\t\t{{\"pGet{0}\"     , new[]{{\"P\", \"{2}\", \"{3}\" ,\"{0}\", \"{1}\", \"{0}\"}}}},\r\n\t\t\t{{\"fGet{0}\"     , new[]{{\"G\", \"{2}\", \"{3}\" ,\"{0}\", \"{1}\", \"{0}\"}}}},\r\n\t\t\t{{\"Insert{0}\"   , new[]{{\"I\", \"{2}\", \"{3}\" ,\"{0}\", \"{1}\", \"{0}\"}}}},\r\n\t\t\t{{\"Update{0}\"   , new[]{{\"U\", \"{2}\", \"{3}\" ,\"{0}\", \"{1}\", \"{0}\"}}}},\r\n\t\t\t{{\"Remove{0}\"   , new[]{{\"D\", \"{2}\", \"{3}\" ,\"{0}\", \"{1}\", \"{0}\"}}}},\r\n";

                const string fFormat =
                    "//[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]\r\n\t\tpublic static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> {{ \r\n{0}\t\t}};";
                const string fItemFormat = "\t\t\t{{{1}, new [] {{  //{2} - {3} columns  \r\n{0}\t\t\t}}}},\r\n";
                const string fItemInnerFormat =
                    "\t\t\t\t new []{{ \"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\" }},\r\n";

                const string pScope =
                    "using cModel;\r\nusing cKernel;\r\n namespace _{1}.Extend\r\n{{\r\n    public class P\r\n    {{\r\n        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId; \r\n\t\tpublic P(string cs, bool isDebug, int uid) {{ _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }}\r\n{0}\r\n    }}\r\n}}";
                const string pFormat =
                    "\t\t//for {0}\r\n\t\tpublic static void {0}(GCRequest obj, out GCResponse oo)\r\n\t\t{{\r\n\t\t    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);\r\n\t\t    var r = x.R().A(){1}._CC()._CF()._CO()._CLO().L().S().EX().G();\r\n\t\t    oo = new GCResponse {{ Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m }};\r\n\t\t}}\r\n";
                const string pCFormat = ".Pc(\"{0}\")";

                const string deScope =
                    "using System.Collections.Generic;\r\n namespace _{2}\r\n{{\r\n    public class DE\r\n    {{\r\n        {0}\r\n        {1}\r\n    }}\r\n}}";
                const string aeItemFormat =
                    "\t\t\t//{0}\r\n\t\t\t{{\"pGet{0}\"     , new[]{{\"P\", \"{2}\", \"{3}\" ,\"{0}\", \"{1}\", \"{0}\"}}}},\r\n\t\t\t{{\"fGet{0}\"     , new[]{{\"G\", \"{2}\", \"{3}\" ,\"{0}\", \"{1}\", \"{0}\"}}}},\r\n";
                const string asItemFormat =
                    "\t\t\t//{0}\r\n\t\t\t{{\"s{0}\"     , new[]{{\"S\", \"{2}\", \"{3}\" ,\"{0}\", \"{1}\", \"{0}\"}}}},\r\n";
                

                const string peScope =
                   "using cModel;\r\nusing cKernel;\r\n namespace _{1}.Extend\r\n{{\r\n    public class PE\r\n    {{\r\n        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId;\r\n\t\tpublic PE(string cs, bool isDebug, int uid) {{ _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }}\r\n{0}\r\n    }}\r\n}}";

                //D & P
                //Get tables list
                //var db = new Connection(ConfigurationManager.ConnectionStrings["bConStr"].ConnectionString);
                var db = new Connection(_conStr);
                //var dbNameSpace = String.Format("{0:X8}", _conStr.GetHashCode()).ToUpper();


                var currentIndex = 0;

                #region table
                
                //Build content
                var dBuilder = new StringBuilder();

                //Action builder
                var actBuilder = new StringBuilder();
                var actItemBuilder = new StringBuilder();
                var fBuilder = new StringBuilder();
                var fItemBuilder = new StringBuilder();

                var pBuilder = new StringBuilder();
                var pItemBuilder = new StringBuilder();
                
                if (slTbl != null && slTbl.Any())
                {
                    for (var i = 0; i < slTbl.Count; i++)
                    {
                        actItemBuilder.Append(String.Format(aItemFormat,
                            new object[]
                            {
                                Convert.ToString(slTbl[i].Text),
                                _getViewName(Convert.ToString(slTbl[i].Text)), i, i
                            }));
                        var objId = Convert.ToInt32(slTbl[i].Value);
                        var t = db.GetObjectMetaData(objId);
                        if (t.Rows.Count > 0)
                        {
                            var fItemInnerBuilder = new StringBuilder();
                            var pItemInnerBuilder = new StringBuilder();
                            for (var j = 0; j < t.Rows.Count; j++)
                            {
                                fItemInnerBuilder.Append(String.Format(fItemInnerFormat, new[]
                                {
                                    _sqlToSimpleType(Convert.ToString(t.Rows[j]["type_name"])),
                                    Convert.ToBoolean(t.Rows[j]["is_nullable"]) ? 1 : 0,
                                    Convert.ToBoolean(t.Rows[j]["is_primary_key"]) ? 1 : 0,
                                    t.Rows[j]["fcolumn"],
                                    t.Rows[j]["max_length"],
                                    t.Rows[j]["ftable"],
                                    t.Rows[j]["fcolumn"],
                                    t.Rows[j]["name"]
                                }));

                                pItemInnerBuilder.Append(String.Format(pCFormat, t.Rows[j]["name"]));
                            }
                            fItemBuilder.Append(String.Format(fItemFormat, new object[]
                            {
                                fItemInnerBuilder, i, slTbl[i].Text, t.Rows.Count
                            }));
                            pItemBuilder.Append(String.Format(pFormat, new object[]
                            {
                                slTbl[i].Text, pItemInnerBuilder
                            }));
                        }
                    }

                    currentIndex = slTbl.Count;
                }
                else
                {
                    var tables = db.GetAllTables();

                    for (var i = 0; i < tables.Rows.Count; i++)
                    {
                        actItemBuilder.Append(String.Format(aItemFormat,
                            new object[]
                            {
                                Convert.ToString(tables.Rows[i]["name"]),
                                _getViewName(Convert.ToString(tables.Rows[i]["name"])), i, i
                            }));
                        var objId = Convert.ToInt32(tables.Rows[i]["object_id"]);
                        var t = db.GetObjectMetaData(objId);

                        if (t.Rows.Count > 0)
                        {
                            var fItemInnerBuilder = new StringBuilder();
                            var pItemInnerBuilder = new StringBuilder();
                            for (var j = 0; j < t.Rows.Count; j++)
                            {
                                fItemInnerBuilder.Append(String.Format(fItemInnerFormat, new[]
                                {
                                    _sqlToSimpleType(Convert.ToString(t.Rows[j]["type_name"])),
                                    Convert.ToBoolean(t.Rows[j]["is_nullable"]) ? 1 : 0,
                                    Convert.ToBoolean(t.Rows[j]["is_primary_key"]) ? 1 : 0,
                                    t.Rows[j]["fcolumn"],
                                    t.Rows[j]["max_length"],
                                    t.Rows[j]["ftable"],
                                    t.Rows[j]["fcolumn"],
                                    t.Rows[j]["name"]
                                }));

                                pItemInnerBuilder.Append(String.Format(pCFormat, t.Rows[j]["name"]));
                            }
                            fItemBuilder.Append(String.Format(fItemFormat, new[]
                            {
                                fItemInnerBuilder, i, tables.Rows[i]["name"], t.Rows.Count
                            }));
                            pItemBuilder.Append(String.Format(pFormat, new[]
                            {
                                tables.Rows[i]["name"], pItemInnerBuilder
                            }));
                        }
                    }

                    currentIndex = tables.Rows.Count;
                }

                actBuilder.Append(String.Format(aFormat, actItemBuilder));
                fBuilder.Append(String.Format(fFormat, fItemBuilder));

                dBuilder.Append(String.Format(dScope, actBuilder, fBuilder, _ns));
                pBuilder.Append(String.Format(pScope, pItemBuilder, _ns));

                //Write content to file
                var fw = new FileWriter();
                fw.WriteFile(_d, dBuilder.ToString());
                fw.WriteFile(_p, pBuilder.ToString());

                #endregion table

                #region View & SP

                //DE & PE
                //Build content
                var deBuilder = new StringBuilder();

                //Action builder
                var aectBuilder = new StringBuilder();
                var aectItemBuilder = new StringBuilder();
                var feBuilder = new StringBuilder();
                var feItemBuilder = new StringBuilder();

                var peBuilder = new StringBuilder();
                var peItemBuilder = new StringBuilder();

                if (slV != null && slV.Any())
                {
                    for (var i = 0; i < slV.Count; i++)
                    {
                        var vname = Convert.ToString(slV[i].Text);
                        aectItemBuilder.Append(String.Format(aeItemFormat,
                           new object[] { vname, vname, i + currentIndex, i + currentIndex }));

                        var objId = Convert.ToInt32(slV[i].Value);
                        var v = db.GetObjectMetaData(objId);

                        if (v.Rows.Count > 0)
                        {

                            var feItemInnerBuilder = new StringBuilder();
                            var peItemInnerBuilder = new StringBuilder();
                            for (var j = 0; j < v.Rows.Count; j++)
                            {
                                feItemInnerBuilder.Append(String.Format(fItemInnerFormat, new[]
                                {
                                    _sqlToSimpleType(Convert.ToString(v.Rows[j]["type_name"])),
                                    Convert.ToBoolean(v.Rows[j]["is_nullable"]) ? 1 : 0,
                                    Convert.ToBoolean(v.Rows[j]["is_primary_key"]) ? 1 : 0,
                                    v.Rows[j]["fcolumn"],
                                    v.Rows[j]["max_length"],
                                    v.Rows[j]["ftable"],
                                    v.Rows[j]["fcolumn"],
                                    v.Rows[j]["name"]
                                }));

                                peItemInnerBuilder.Append(String.Format(pCFormat, v.Rows[j]["name"]));
                            }
                            feItemBuilder.Append(String.Format(fItemFormat, new object[]
                            {
                                feItemInnerBuilder, i + currentIndex, vname, v.Rows.Count
                            }));
                            peItemBuilder.Append(String.Format(pFormat, new object[]
                            {
                                vname, peItemInnerBuilder
                            }));
                        }
                    }
                    currentIndex += slV.Count;
                }
                else
                {
                    //Views
                    var views = db.GetAllExtendView();
                    for (var i = 0; i < views.Rows.Count; i++)
                    {
                        var vname = Convert.ToString(views.Rows[i]["name"]);
                        aectItemBuilder.Append(String.Format(aeItemFormat,
                            new object[] { vname, vname, i + currentIndex, i + currentIndex }));

                        var objId = Convert.ToInt32(views.Rows[i]["object_id"]);
                        var v = db.GetObjectMetaData(objId);

                        if (v.Rows.Count > 0)
                        {

                            var feItemInnerBuilder = new StringBuilder();
                            var peItemInnerBuilder = new StringBuilder();
                            for (var j = 0; j < v.Rows.Count; j++)
                            {
                                feItemInnerBuilder.Append(String.Format(fItemInnerFormat, new[]
                                {
                                    _sqlToSimpleType(Convert.ToString(v.Rows[j]["type_name"])),
                                    Convert.ToBoolean(v.Rows[j]["is_nullable"]) ? 1 : 0,
                                    Convert.ToBoolean(v.Rows[j]["is_primary_key"]) ? 1 : 0,
                                    v.Rows[j]["fcolumn"],
                                    v.Rows[j]["max_length"],
                                    v.Rows[j]["ftable"],
                                    v.Rows[j]["fcolumn"],
                                    v.Rows[j]["name"]
                                }));

                                peItemInnerBuilder.Append(String.Format(pCFormat, v.Rows[j]["name"]));
                            }
                            feItemBuilder.Append(String.Format(fItemFormat, new object[]
                            {
                                feItemInnerBuilder, i + currentIndex, vname, v.Rows.Count
                            }));
                            peItemBuilder.Append(String.Format(pFormat, new object[]
                            {
                                vname, peItemInnerBuilder
                            }));
                        }
                    }

                    currentIndex += views.Rows.Count;

                    
                }

                #region SP

                if (slSP != null && slSP.Any())
                {
                    for (var i = 0; i < slSP.Count; i++)
                    {
                        var vname = Convert.ToString(slSP[i].Text);
                        aectItemBuilder.Append(String.Format(asItemFormat,
                            new object[] { vname, vname, i + currentIndex, i + currentIndex }));

                        var objId = Convert.ToInt32(slSP[i].Value);
                        //var v = db.GetObjectMetaData(objId);

                        var v = db.GetParameterMetaData(objId);
                        if (v.Rows.Count > 0)
                        {

                            var feItemInnerBuilder = new StringBuilder();
                            var peItemInnerBuilder = new StringBuilder();
                            for (var j = 0; j < v.Rows.Count; j++)
                            {
                                feItemInnerBuilder.Append(String.Format(fItemInnerFormat, new[]
                                {
                                    _sqlToSimpleType(Convert.ToString(v.Rows[j]["type_name"])),
                                    0,
                                    0,
                                    String.Empty,
                                    v.Rows[j]["max_length"],
                                    String.Empty,
                                    String.Empty,
                                    v.Rows[j]["name"]
                                }));

                                peItemInnerBuilder.Append(String.Format(pCFormat, v.Rows[j]["name"]));
                            }
                            feItemBuilder.Append(String.Format(fItemFormat, new object[]
                            {
                                feItemInnerBuilder, i + currentIndex, vname, v.Rows.Count
                            }));
                            peItemBuilder.Append(String.Format(pFormat, new object[]
                            {
                                vname, peItemInnerBuilder
                            }));
                        }
                    }
                }
                else
                {
                    //Stored procedure
                    var sp = db.GetAllExtendStoredProcedure();
                    for (var i = 0; i < sp.Rows.Count; i++)
                    {
                        var vname = Convert.ToString(sp.Rows[i]["name"]);
                        aectItemBuilder.Append(String.Format(asItemFormat,
                            new object[] { vname, vname, i + currentIndex, i + currentIndex }));

                        var objId = Convert.ToInt32(sp.Rows[i]["object_id"]);
                        //var v = db.GetObjectMetaData(objId);

                        var v = db.GetParameterMetaData(objId);
                        if (v.Rows.Count > 0)
                        {

                            var feItemInnerBuilder = new StringBuilder();
                            var peItemInnerBuilder = new StringBuilder();
                            for (var j = 0; j < v.Rows.Count; j++)
                            {
                                feItemInnerBuilder.Append(String.Format(fItemInnerFormat, new[]
                                {
                                    _sqlToSimpleType(Convert.ToString(v.Rows[j]["type_name"])),
                                    0,
                                    0,
                                    String.Empty,
                                    v.Rows[j]["max_length"],
                                    String.Empty,
                                    String.Empty,
                                    v.Rows[j]["name"]
                                }));

                                peItemInnerBuilder.Append(String.Format(pCFormat, v.Rows[j]["name"]));
                            }
                            feItemBuilder.Append(String.Format(fItemFormat, new object[]
                            {
                                feItemInnerBuilder, i + currentIndex, vname, v.Rows.Count
                            }));
                            peItemBuilder.Append(String.Format(pFormat, new object[]
                            {
                                vname, peItemInnerBuilder
                            }));
                        }
                    }
                }
                #endregion SP


                aectBuilder.Append(String.Format(aFormat, aectItemBuilder));
                feBuilder.Append(String.Format(fFormat, feItemBuilder));

                deBuilder.Append(String.Format(deScope, aectBuilder, feBuilder, _ns));
                peBuilder.Append(String.Format(peScope, peItemBuilder, _ns));

                //var fw = new FileWriter();
                fw.WriteFile(_de, deBuilder.ToString());
                fw.WriteFile(_pe, peBuilder.ToString());

                #endregion View & SP
                

                //Zip all files

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }



        public void BuildDBView(List<ListItem> slTbl = null )
        {
            try
            {
                //Get tables list
                //var db = new Connection(ConfigurationManager.ConnectionStrings["bConStr"].ConnectionString);
                var db = new Connection(_conStr);
                if (slTbl != null && slTbl.Any())
                {
                    for (var i = 0; i < slTbl.Count; i++)
                    {
                        var tname = Convert.ToString(slTbl[i].Text);
                        var objId = Convert.ToInt32(slTbl[i].Value);
                        var t = db.GetObjectMetaData(objId);
                        var columns = new List<string>();
                        for (var j = 0; j < t.Rows.Count; j++)
                        {
                            columns.Add(Convert.ToString(t.Rows[j]["name"]));
                        }
                        db.GenerateView(tname, _getViewName(tname), columns);
                    }
                }
                else
                {

                    var tables = db.GetAllTables();
                    for (var i = 0; i < tables.Rows.Count; i++)
                    {
                        var tname = Convert.ToString(tables.Rows[i]["name"]);
                        var objId = Convert.ToInt32(tables.Rows[i]["object_id"]);
                        var t = db.GetObjectMetaData(objId);
                        var columns = new List<string>();
                        for (var j = 0; j < t.Rows.Count; j++)
                        {
                            columns.Add(Convert.ToString(t.Rows[j]["name"]));
                        }
                        db.GenerateView(tname, _getViewName(tname), columns);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }



        public void DropDBView()
        {
            try
            {
                //Get tables list
                //var db = new Connection(ConfigurationManager.ConnectionStrings["bConStr"].ConnectionString);
                var db = new Connection(_conStr);
                var tables = db.GetAllTables();
                for (var i = 0; i < tables.Rows.Count; i++)
                {
                    db.DropView(_getViewName(Convert.ToString(tables.Rows[i]["name"])));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void BuildStoreProcedure()
        {
            try
            {
                var sp =
                    System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("Templates/Db/StoredProcedure.sql"));
                //var db = new Connection(ConfigurationManager.ConnectionStrings["bConStr"].ConnectionString);
                var db = new Connection(_conStr);
                db.GenerateStoredProcedure(sp);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        private static string _getViewName(string tableName)
        {
            return String.Format("{0}_View", tableName);
        }

        private static int _sqlToSimpleType(string type)
        {
            int result;
            switch (type)
            {
                case "char":
                    result = (int)SqlDbType.Char;
                    break;
                case "nchar":
                    result = (int)SqlDbType.NChar;
                    break;
                case "varchar":
                    result = (int)SqlDbType.VarChar;
                    break;
                case "nvarchar":
                    result = (int)SqlDbType.NVarChar;
                    break;
                case "text":
                    result = (int)SqlDbType.Text;
                    break;
                case "ntext":
                    result = (int)SqlDbType.NText;
                    break;
                case "int":
                    result = (int)SqlDbType.Int;
                    break;
                case "bigint":
                    result = (int)SqlDbType.BigInt;
                    break;
                case "float":
                    result = (int)SqlDbType.Float;
                    break;
                case "real":
                    result = (int)SqlDbType.Real;
                    break;
                case "datetime":
                    result = (int)SqlDbType.DateTime;
                    break;
                case "bit":
                    result = (int)SqlDbType.Bit;
                    break;
                case "image":
                    result = (int)SqlDbType.Image;
                    break;
                case "varbinary":
                    result = (int)SqlDbType.VarBinary;
                    break;
                case "binary":
                    result = (int)SqlDbType.Binary;
                    break;
                case "tinyint":
                    result = (int)SqlDbType.TinyInt;
                    break;
                case "smallint":
                    result = (int)SqlDbType.SmallInt;
                    break;
                default:
                    result = (int)SqlDbType.NVarChar;
                    break;
            }
            return result;
        }


        private string _sqlToModelType(string type)
        {
            switch (type)
            {
                case "char":
                    return "string";
                case "nchar":
                    return "string";

                case "varchar":
                    return "string";

                case "nvarchar":
                    return "string";

                case "text":
                    return "string";

                case "ntext":
                    return "string";

                case "int":
                    return "int";

                case "bigint":
                    return "long";

                case "double":
                    return "double";

                case "float":
                    return "float";

                case "real":
                    return "float";

                case "numeric":
                    return "int";

                case "datetime":
                    return "DateTime";

                case "bit":
                    return "bool";

                case "image":
                    return "string";

                case "tinyint":
                    return "int";

                case "byte":
                    return "byte";

                case "smallint":
                    return "int";
            }
            return "string";
        }

        //public void BuildDBService()
        //{
        //    //Copy kernel lib to object builder
        //    System.IO.File.Copy(String.Format(@"{0}\\bin\cKernel.dll", HttpContext.Current.Request.PhysicalApplicationPath),
        //        _kddl, true);

        //    System.IO.File.Copy(String.Format(@"{0}\\bin\cService.dll", HttpContext.Current.Request.PhysicalApplicationPath),
        //       _sddl, true);

        //    //Build dict and kernel extend dll
        //    var frameworkPath = System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory();
        //    var cscPath = Path.Combine(frameworkPath, "csc.exe");

        //    var cmd = new CommandLine();

        //    var dcmd = String.Format("/target:library /out:{0} {1} {2}", _dddl, _d, _de);
        //    var pcmd = String.Format("/r:{0} /target:library /out:{1} {2} {3}", _kddl, _pddl, _p, _pe);
        //    cmd.ExecuteCommandSync(cscPath, dcmd);
        //    cmd.ExecuteCommandSync(cscPath, pcmd);
        //}

        public void DropAll()
        {
            try
            {
                var sp =
                    System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("Templates/Db/DropAll.sql"));
                //var db = new Connection(ConfigurationManager.ConnectionStrings["bConStr"].ConnectionString);
                var db = new Connection(_conStr);
                db.DropAll(sp);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public string ZipDBDict(string zipFileName)
        {
            try
            {
                //var zipFilePath = String.Format(@"{0}\\ObjectBuilder\\{1}.zip", HttpContext.Current.Request.PhysicalApplicationPath, zipFileName);
                var zipFilePath = HttpContext.Current.Server.MapPath(String.Format("~/ObjectBuilder/{0}.zip", zipFileName));

                // Remove old files
                if (System.IO.File.Exists(zipFilePath))
                {
                    System.IO.File.Delete(zipFilePath);
                }
                // Create temp folder
                if (!Directory.Exists(_tempDir))
                {
                    Directory.CreateDirectory(_tempDir);
                }
                //Remove all olds files in temp folder
                Array.ForEach(Directory.GetFiles(_tempDir), System.IO.File.Delete);

                //Copy DLL to temp folder
                System.IO.File.Copy(_d, _td, true);
                System.IO.File.Copy(_de, _tde, true);
                System.IO.File.Copy(_p, _tp, true);
                System.IO.File.Copy(_pe, _tpe, true);

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

        public void BuildDBModel()
        {
            try
            {
                var stpl = HttpContext.Current.Server.MapPath("~/Templates/CSharp/Model.t4");
                var lbdir = HttpContext.Current.Server.MapPath("~/ObjectBuilder/Models/");

                //Create folders
                if (!Directory.Exists(lbdir))
                {
                    Directory.CreateDirectory(lbdir);
                }
                //Remove all olds files in temp folder
                Array.ForEach(Directory.GetFiles(lbdir), System.IO.File.Delete);

                var db = new Connection(_conStr);
                var dbNameSpace = _ns;

                //Tables
                var tables = db.GetAllTables();

                IGenerator g = new Generator();
                for (var i = 0; i < tables.Rows.Count; i++)
                {
                    var objId = Convert.ToInt32(tables.Rows[i]["object_id"]);
                    var t = db.GetObjectMetaData(objId);
                    if (t.Rows.Count > 0)
                    {
                        var fields = new List<object[]>();
                        for (var j = 0; j < t.Rows.Count; j++)
                        {
                            fields.Add(new []{ _sqlToModelType(Convert.ToString(t.Rows[j]["type_name"])), t.Rows[j]["name"] });
                        }
                        var scs = String.Format("{0}\\{1}.cs", lbdir, tables.Rows[i]["name"]);
                        g.GenerateToFile(stpl, scs
                        , new object[] { dbNameSpace, Convert.ToString(tables.Rows[i]["name"]), fields });
                    }
                }


                //Views
                var views = db.GetAllExtendView();
                for (var i = 0; i < views.Rows.Count; i++)
                {
                    var objId = Convert.ToInt32(views.Rows[i]["object_id"]);
                    var v = db.GetObjectMetaData(objId);

                    if (v.Rows.Count > 0)
                    {
                        var fields = new List<object[]>();
                        for (var j = 0; j < v.Rows.Count; j++)
                        {
                            fields.Add(new[] { _sqlToModelType(Convert.ToString(v.Rows[j]["type_name"])), v.Rows[j]["name"] });
                        }
                        var scs = String.Format("{0}\\{1}.cs", lbdir, views.Rows[i]["name"]);
                        g.GenerateToFile(stpl, scs
                        , new object[] { dbNameSpace, Convert.ToString(views.Rows[i]["name"]), fields });

                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void DropViewExtendProperties()
        {
            try
            {
                //Get tables list
                //var db = new Connection(ConfigurationManager.ConnectionStrings["bConStr"].ConnectionString);
                var db = new Connection(_conStr);
                var tables = db.GetAllTables();
                for (var i = 0; i < tables.Rows.Count; i++)
                {
                    var tname = Convert.ToString(tables.Rows[i]["name"]);
                    db.DropViewExtendProperty(_getViewName(tname));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public List<ListItem> GetListDBTable()
        {
            var result = new List<ListItem>();
            var db = new Connection(_conStr);
            var tables = db.GetAllTables();
            for (var i = 0; i < tables.Rows.Count; i++)
            {
                result.Add(new ListItem(Convert.ToString(tables.Rows[i]["name"]),
                    Convert.ToString(tables.Rows[i]["object_id"])));
            }
            return result;
        }

        public List<ListItem> GetListDBView()
        {
             var result = new List<ListItem>();
            var db = new Connection(_conStr);
            var tables = db.GetAllExtendView();
            for (var i = 0; i < tables.Rows.Count; i++)
            {
                result.Add(new ListItem(Convert.ToString(tables.Rows[i]["name"]),
                    Convert.ToString(tables.Rows[i]["object_id"])));
            }
            return result;
        }

        public List<ListItem> GetListDBSP()
        {
            var result = new List<ListItem>();
            var db = new Connection(_conStr);
            var tables = db.GetAllExtendStoredProcedure();
            for (var i = 0; i < tables.Rows.Count; i++)
            {
                result.Add(new ListItem(Convert.ToString(tables.Rows[i]["name"]),
                    Convert.ToString(tables.Rows[i]["object_id"])));
            }
            return result;
        }

        public void DropBuildInView()
        {
            try
            {
                //Get tables list
                //var db = new Connection(ConfigurationManager.ConnectionStrings["bConStr"].ConnectionString);
                var db = new Connection(_conStr);
                var tables = db.GetAllBuildInView();
                for (var i = 0; i < tables.Rows.Count; i++)
                {
                    var tname = Convert.ToString(tables.Rows[i]["name"]);
                    db.DropView(tname);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public void BuildDBCRUD(List<ListItem> slTbl)
        {
            try
            {
                //Get tables list
                //var db = new Connection(ConfigurationManager.ConnectionStrings["bConStr"].ConnectionString);
                var db = new Connection(_conStr);
                var sql = new StringBuilder();
                if (slTbl != null && slTbl.Any())
                {
                    for (var i = 0; i < slTbl.Count; i++)
                    {
                        var tname = Convert.ToString(slTbl[i].Text);
                        var objId = Convert.ToInt32(slTbl[i].Value);
                        var t = db.GetObjectMetaData(objId);
                        var columns = new List<object[]>();
                        for (var j = 0; j < t.Rows.Count; j++)
                        {
                            if (!t.Rows[j]["name"].Equals("Id"))
                            {
                                var obj = new[]
                                {
                                    t.Rows[j]["name"], t.Rows[j]["type_name"], 0
                                };

                                switch (Convert.ToString(t.Rows[j]["type_name"]))
                                {
                                    case "nchar":
                                    case "nvarchar":
                                        obj[2] = Convert.ToInt32(t.Rows[j]["max_length"])/2;
                                        break;
                                    case "char":
                                    case "varchar":
                                        obj[2] = t.Rows[j]["max_length"];
                                        break;
                                    default:
                                        obj[2] = 0;
                                        break;
                                }
                                columns.Add(obj);
                            }
                        }
                        
                        sql.Append(db.GenerateCRUD(tname, columns));
                        sql.Append(Environment.NewLine);
                    }
                }
                else
                {

                    var tables = db.GetAllTables();
                    for (var i = 0; i < tables.Rows.Count; i++)
                    {
                        var tname = Convert.ToString(tables.Rows[i]["name"]);
                        var objId = Convert.ToInt32(tables.Rows[i]["object_id"]);
                        var t = db.GetObjectMetaData(objId);
                        var columns = new List<object[]>();
                        for (var j = 0; j < t.Rows.Count; j++)
                        {
                            if (!t.Rows[j]["name"].Equals("Id"))
                            {
                                var obj = new[]
                                {
                                    t.Rows[j]["name"], t.Rows[j]["type_name"], 0
                                };

                                switch (Convert.ToString(t.Rows[j]["type_name"]))
                                {
                                    case "nchar":
                                    case "nvarchar":
                                        obj[2] = Convert.ToInt32(t.Rows[j]["max_length"]) / 2;
                                        break;
                                    case "char":
                                    case "varchar":
                                        obj[2] = t.Rows[j]["max_length"];
                                        break;
                                    default:
                                        obj[2] = 0;
                                        break;
                                }
                                columns.Add(obj);
                            }
                        }
                        sql.Append(db.GenerateCRUD(tname, columns));
                        sql.Append(Environment.NewLine);
                    }
                }
                var esql = sql.ToString();
                if (!String.IsNullOrEmpty(esql))
                {
                    db.GenerateStoredProcedure(esql);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        public string ZipDBModel(string zipFileName)
        {
            try
            {
                //var zipFilePath = String.Format(@"{0}\\ObjectBuilder\\{1}.zip", HttpContext.Current.Request.PhysicalApplicationPath, zipFileName);
                var zipFilePath = HttpContext.Current.Server.MapPath(String.Format("~/ObjectBuilder/{0}.zip", zipFileName));

                // Create temp folder
                if (System.IO.File.Exists(zipFilePath))
                {
                    System.IO.File.Delete(zipFilePath);
                }
                //Zip files
                ZipFile.CreateFromDirectory(_modelDir, zipFilePath);

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