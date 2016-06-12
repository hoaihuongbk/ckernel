using CTool.Builder.Db;
using CTool.Builder.File;
using CTool.Model;
using ServiceStack.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace CTool.Builder.Javascript
{
    public class ModelBuilder
    {
        private readonly string _conStr;
        private readonly string _ns;
        private readonly string jsDir = HttpContext.Current.Server.MapPath("~/ObjectBuilder/Js/");

        public ModelBuilder(string connStr, string ns = "")
        {
            _conStr = connStr;
            _ns = !String.IsNullOrEmpty(ns) ? ns.Substring(0, 8).ToUpper() : String.Format("{0:X8}", connStr.GetHashCode()).ToUpper();

            JsConfig.EmitCamelCaseNames = true;
            JsConfig.EmitLowercaseUnderscoreNames = true;
        }

        public void BuildJsDictionary(List<ListItem> slTbl = null, List<ListItem> slV = null, List<ListItem> slSP = null)
        {
            try
            {
                var db = new Connection(_conStr);
                var fw = new FileWriter();

                //Create folder if not existing, clear all files and folder
                var di = Directory.CreateDirectory(jsDir);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

                #region table
                if (slTbl != null && slTbl.Any())
                {
                    for (var i = 0; i < slTbl.Count; i++)
                    {
                        var name = Convert.ToString(slTbl[i].Text);
                        var jo = new jObject()
                        {
                            Name = name,
                            Fields = new List<jField>()
                        };

                        var objId = Convert.ToInt32(slTbl[i].Value);
                        var t = db.GetObjectMetaData(objId);
                        if (t.Rows.Count > 0)
                        {
                            for (var j = 0; j < t.Rows.Count; j++)
                            {
                                var f = new jField()
                                {
                                    Field = Convert.ToString(t.Rows[j]["name"]),
                                    Name = Convert.ToString(t.Rows[j]["name"])
                                };
                                if (Convert.ToBoolean(t.Rows[j]["is_primary_key"]))
                                {
                                    f.Type = "hidden";
                                    f.Create = false;
                                } else
                                {
                                    f.Type = _sqlToSimpleType(Convert.ToString(t.Rows[j]["type_name"]));
                                }
                                jo.Fields.Add(f);
                            }
                        }

                        var filePath = HttpContext.Current.Server.MapPath(string.Format("~/ObjectBuilder/Js/{0}.json",name));
                            fw.WriteFile(filePath, JsonSerializer.SerializeToString(jo));
                    }
                }
                else
                {
                    var tables = db.GetAllTables();
                    for (var i = 0; i < tables.Rows.Count; i++)
                    {
                        var name = Convert.ToString(tables.Rows[i]["name"]);
                        var jo = new jObject()
                        {
                            Name = name,
                            Fields = new List<jField>()
                        };

                        var objId = Convert.ToInt32(tables.Rows[i]["object_id"]);
                        var t = db.GetObjectMetaData(objId);
                        if (t.Rows.Count > 0)
                        {
                            for (var j = 0; j < t.Rows.Count; j++)
                            {
                                var f = new jField()
                                {
                                    Field = Convert.ToString(t.Rows[j]["name"]),
                                    Name = Convert.ToString(t.Rows[j]["name"])
                                };
                                if (Convert.ToBoolean(t.Rows[j]["is_primary_key"]))
                                {
                                    f.Type = "hidden";
                                    f.Create = false;
                                }
                                else
                                {
                                    f.Type = _sqlToSimpleType(Convert.ToString(t.Rows[j]["type_name"]));
                                }
                                jo.Fields.Add(f);
                            }
                        }

                        var filePath = HttpContext.Current.Server.MapPath(string.Format("~/ObjectBuilder/Js/{0}.json", name));
                        fw.WriteFile(filePath, JsonSerializer.SerializeToString(jo));
                    }
                }
                #endregion table

                #region View
                if (slV != null && slV.Any())
                {
                    for (var i = 0; i < slV.Count; i++)
                    {
                        var vname = Convert.ToString(slV[i].Text);
                        var jo = new jObject()
                        {
                            Name = vname,
                            Fields = new List<jField>()
                        };

                        var objId = Convert.ToInt32(slV[i].Value);
                        var v = db.GetObjectMetaData(objId);

                        if (v.Rows.Count > 0)
                        {
                            for (var j = 0; j < v.Rows.Count; j++)
                            {
                                var f = new jField()
                                {
                                    Field = Convert.ToString(v.Rows[j]["name"]),
                                    Name = Convert.ToString(v.Rows[j]["name"])
                                };
                                if (Convert.ToBoolean(v.Rows[j]["is_primary_key"]))
                                {
                                    f.Type = "hidden";
                                    f.Create = false;
                                }
                                else
                                {
                                    f.Type = _sqlToSimpleType(Convert.ToString(v.Rows[j]["type_name"]));
                                }
                                jo.Fields.Add(f);
                            }
                        }

                        var filePath = HttpContext.Current.Server.MapPath(string.Format("~/ObjectBuilder/Js/{0}.json", vname));
                        fw.WriteFile(filePath, JsonSerializer.SerializeToString(jo));
                    }
                }
                else
                {
                    //Views
                    var views = db.GetAllExtendView();
                    for (var i = 0; i < views.Rows.Count; i++)
                    {
                        var vname = Convert.ToString(views.Rows[i]["name"]);
                        var jo = new jObject()
                        {
                            Name = vname,
                            Fields = new List<jField>()
                        };

                        var objId = Convert.ToInt32(views.Rows[i]["object_id"]);
                        var v = db.GetObjectMetaData(objId);

                        if (v.Rows.Count > 0)
                        {
                            for (var j = 0; j < v.Rows.Count; j++)
                            {
                                var f = new jField()
                                {
                                    Field = Convert.ToString(v.Rows[j]["name"]),
                                    Name = Convert.ToString(v.Rows[j]["name"])
                                };
                                if (Convert.ToBoolean(v.Rows[j]["is_primary_key"]))
                                {
                                    f.Type = "hidden";
                                    f.Create = false;
                                }
                                else
                                {
                                    f.Type = _sqlToSimpleType(Convert.ToString(v.Rows[j]["type_name"]));
                                }
                                jo.Fields.Add(f);
                            }
                        }

                        var filePath = HttpContext.Current.Server.MapPath(string.Format("~/ObjectBuilder/Js/{0}.json", vname));
                        fw.WriteFile(filePath, JsonSerializer.SerializeToString(jo));
                    }
                }

                #endregion View


                //Zip all files

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

        private static string _sqlToSimpleType(string type)
        {
            string result;
            switch (type)
            {
                case "text":
                case "ntext":
                    result = "textarea";
                    break;
                case "int":
                case "bigint":
                case "float":
                case "real":
                    result = "number";
                    break;
                case "datetime":
                    result = "datetime";
                    break;
                default:
                    result = string.Empty;
                    break;
            }
            return result;
        }

        public string ZipJsDict(string zipFileName)
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

                //Zip files
                ZipFile.CreateFromDirectory(jsDir, zipFilePath);

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