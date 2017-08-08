using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTool.Builder.Db;
using System.IO;
using CTool.Builder.Javascript;

namespace CTool
{
    public partial class Default : Page
    {
        private readonly string _lbdir = HttpContext.Current.Server.MapPath("~/ObjectBuilder/");

        protected void Page_Load(object sender, EventArgs e)
        {
            
            _mapSessionData();
            Page.Response.Cache.SetCacheability(HttpCacheability.NoCache);
        }

        protected void btnBuildDBView_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var k = new DbBuilder(info);

                var selectTbl = _getSelectTable();

                k.BuildDBView(selectTbl);

                Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        protected void btnBuildDBProcedure_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var k = new DbBuilder(info);
                k.BuildStoreProcedure();
                Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        protected void btnBuildDBDict_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var ns = _getNamespace(); 
                var k = new DbBuilder(info, ns);

                var selectTbl = _getSelectTable();
                var selectV = _getSelectView();
                var selectSP = _getSelectSP();

                //Delete builder folder
                //var dir = new DirectoryInfo(_lbdir);
                //dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                //dir.Delete(true);
                //if (!Directory.Exists(_lbdir))
                //{
                //    Directory.CreateDirectory(_lbdir);
                //}

                k.BuildDBDictionary(selectTbl, selectV, selectSP);
                //Zip
                if (HttpContext.Current.Session["conStr"] != null)
                {
                    var zipFileName = "DBDict" + GetMd5Sum(HttpContext.Current.Session["conStr"].ToString());
                    var zipFilePath = k.ZipDBDict(zipFileName);
                    if (!String.IsNullOrEmpty(zipFilePath))
                    {
                        //var response = HttpContext.Current.Response;
                        //response.ClearContent();
                        //response.Clear();
                        //response.ContentType = "application/zip";
                        //response.AddHeader("Content-Disposition", "attachment; filename=" + zipFileName + ".zip;");
                        //response.TransmitFile(zipFilePath);
                        //response.Flush();
                        ////System.IO.File.Delete(zipFilePath);
                        //response.End();
                        Response.ContentType = "application/zip";
                        Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.zip;", zipFileName));
                        Response.WriteFile(zipFilePath);
                        Response.Flush();
                        File.Delete(zipFilePath);
                        Response.End();
                    }
                }

                Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        protected void btnBuildDBService_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var ns = _getNamespace();
                var k = new ServiceBuilder(info, ns);
                k.BuildDBService();

                //Zip
                if (HttpContext.Current.Session["conStr"] != null)
                {
                    var zipFileName = "DBService" + GetMd5Sum(HttpContext.Current.Session["conStr"].ToString());
                    var zipFilePath = k.ZipDBService(zipFileName);
                    if (!String.IsNullOrEmpty(zipFilePath))
                    {
                        //var response = HttpContext.Current.Response;
                        //response.ClearContent();
                        //response.Clear();
                        //response.ContentType = "application/zip";
                        //response.AddHeader("Content-Disposition", "attachment; filename=" + zipFileName + ".zip;");
                        //response.TransmitFile(zipFilePath);
                        ////System.IO.File.Delete(zipFilePath);
                        //response.Flush();
                        //response.End();

                        Response.ContentType = "application/zip";
                        Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.zip;", zipFileName));
                        Response.WriteFile(zipFilePath);
                        Response.Flush();
                        File.Delete(zipFilePath);
                        Response.End();
                    }
                }
                Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message3.Text = ex.Message;
                Message3.Style.Add("color", "red");
            }
        }

        private string _getDBConnectionString()
        {
            var result = new object[4];
            var string0 = Request.Form.GetValues("inputHost");
            if (string0 != null && !String.IsNullOrEmpty(string0[0]))
                result[0] = string0[0];
            else throw new Exception("Host name must be required");

            var string1 = Request.Form.GetValues("inputDBName");
            if (string1 != null && !String.IsNullOrEmpty(string1[0]))
                result[1] = string1[0];
            else throw new Exception("Database name must be required");

            var string2 = Request.Form.GetValues("inputUser");
            if (string2 != null && !String.IsNullOrEmpty(string2[0]))
                result[2] = string2[0];
            else throw new Exception("Username must be required");

            var string3 = Request.Form.GetValues("inputPassword");
            if (string3 != null && !String.IsNullOrEmpty(string3[0]))
                result[3] = string3[0];
            else throw new Exception("Password must be required");

            //Store result to session
            HttpContext.Current.Session["conStr"] = result;

            return String.Format("server={0};database={1};uid={2};password={3};", result);
        }

        private string _getNamespace()
        {
            var ns = String.Empty;
            var string0 = Request.Form.GetValues("inputNamespace");
            if (string0 != null && !String.IsNullOrEmpty(string0[0]))
                ns = string0[0];
            return ns;
        }

        private void _mapSessionData()
        {
            var conStr = Session["conStr"] as object[];
            if (conStr == null || conStr.Length != 4) return;
            inputHost.Text = Convert.ToString(conStr[0]);
            inputDBName.Text = Convert.ToString(conStr[1]);
            inputUser.Text = Convert.ToString(conStr[2]);
            inputPassword.Text = Convert.ToString(conStr[3]);
        }

        private string GetMd5Sum(string str)
        {
            // First we need to convert the string into bytes, which
            // means using a text encoder.
            var enc = Encoding.Unicode.GetEncoder();

            // Create a buffer large enough to hold the string
            var unicodeText = new byte[str.Length * 2];
            enc.GetBytes(str.ToCharArray(), 0, str.Length, unicodeText, 0, true);

            // Now that we have a byte array we can ask the CSP to hash it
            MD5 md5 = new MD5CryptoServiceProvider();
            var result = md5.ComputeHash(unicodeText);

            // Build the final string by converting each byte
            // into hex and appending it to a StringBuilder
            var sb = new StringBuilder();
            for (var i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("X2"));
            }

            // And return it
            return sb.ToString();
        }

        protected void btnBuildDBModel_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var ns = _getNamespace();
                var k = new DbBuilder(info, ns);
                k.BuildDBModel();

                //Zip
                if (HttpContext.Current.Session["conStr"] != null)
                {
                    var zipFileName = "DBModel" + GetMd5Sum(HttpContext.Current.Session["conStr"].ToString());
                    var zipFilePath = k.ZipDBModel(zipFileName);
                    if (!String.IsNullOrEmpty(zipFilePath))
                    {
                        //var response = HttpContext.Current.Response;
                        //response.ClearContent();
                        //response.Clear();
                        //response.ContentType = "application/zip";
                        //response.AddHeader("Content-Disposition", "attachment; filename=" + zipFileName + ".zip;");
                        //response.TransmitFile(zipFilePath);
                        //response.Flush();
                        ////System.IO.File.Delete(zipFilePath);
                        //response.End();

                        Response.ContentType = "application/zip";
                        Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.zip;", zipFileName));
                        Response.WriteFile(zipFilePath);
                        Response.Flush();
                        File.Delete(zipFilePath);
                        Response.End();

                    }
                }
                Response.Redirect(HttpContext.Current.Request.RawUrl);

                //Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        protected void btnDropViewExtendProperty_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var ns = _getNamespace();
                var k = new DbBuilder(info, ns);
                k.DropViewExtendProperties();

                Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        protected void btnLoadTblList_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var k = new DbBuilder(info);
                var lTbl = k.GetListDBTable();
                ListBox1.DataTextField = "text";
                ListBox1.DataValueField = "value";
                ListBox1.DataSource = lTbl;
                ListBox1.DataBind();
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        private List<ListItem> _getSelectTable()
        {
            return (from ListItem item in ListBox1.Items where item.Selected select new ListItem(item.Text, item.Value)).ToList();
        }

        protected void btnLoadViewList_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var k = new DbBuilder(info);
                var lTbl = k.GetListDBView();
                ListBox2.DataTextField = "text";
                ListBox2.DataValueField = "value";
                ListBox2.DataSource = lTbl;
                ListBox2.DataBind();
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        private List<ListItem> _getSelectView()
        {
            return (from ListItem item in ListBox2.Items where item.Selected select new ListItem(item.Text, item.Value)).ToList();
        }

        protected void btnLoadSPList_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var k = new DbBuilder(info);
                var lTbl = k.GetListDBSP();
                ListBox3.DataTextField = "text";
                ListBox3.DataValueField = "value";
                ListBox3.DataSource = lTbl;
                ListBox3.DataBind();
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        private List<ListItem> _getSelectSP()
        {
            return (from ListItem item in ListBox3.Items where item.Selected select new ListItem(item.Text, item.Value)).ToList();
        }

        protected void btnDropBuiltInView_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var ns = _getNamespace();
                var k = new DbBuilder(info, ns);
                k.DropBuildInView();

                Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        protected void btnBuildCRUD_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var k = new DbBuilder(info);

                var selectTbl = _getSelectTable();

                k.BuildDBCRUD(selectTbl);

                Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        protected void btnBuildJsModel_Click(object sender, EventArgs e)
        {
            try
            {
                var info = _getDBConnectionString();
                var k = new ModelBuilder(info);

                var selectTbl = _getSelectTable();
                var selectV = _getSelectView();

                k.BuildJsDictionary(selectTbl, selectV);

                //Zip
                if (HttpContext.Current.Session["conStr"] != null)
                {
                    var zipFileName = "JsDict" + GetMd5Sum(HttpContext.Current.Session["conStr"].ToString());
                    var zipFilePath = k.ZipJsDict(zipFileName);
                    if (!String.IsNullOrEmpty(zipFilePath))
                    {
                        Response.ContentType = "application/zip";
                        Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.zip;", zipFileName));
                        Response.WriteFile(zipFilePath);
                        Response.Flush();
                        File.Delete(zipFilePath);
                        Response.End();
                    }
                }

                Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception ex)
            {
                Message.Text = ex.Message;
                Message.Style.Add("color", "red");
            }
        }

        protected void btnBuildRepo_Click(object sender, EventArgs e)
        {
            try
            {
                DbBuilder dbBuilder = new DbBuilder(this._getDBConnectionString(), this._getNamespace());
                var selectTbl = _getSelectTable();

                dbBuilder.BuildDBRepo(selectTbl);
                if (HttpContext.Current.Session["conStr"] != null)
                {
                    string str = string.Concat("DBRepo", this.GetMd5Sum(HttpContext.Current.Session["conStr"].ToString()));
                    string str1 = dbBuilder.ZipDBModel(str);
                    if (!string.IsNullOrEmpty(str1))
                    {
                        base.Response.ContentType = "application/zip";
                        base.Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.zip;", str));
                        base.Response.WriteFile(str1);
                        base.Response.Flush();
                        File.Delete(str1);
                        base.Response.End();
                    }
                }
                base.Response.Redirect(HttpContext.Current.Request.RawUrl);
            }
            catch (Exception exception)
            {
                this.Message.Text = exception.Message;
                this.Message.Style.Add("color", "red");
            }
        }

        //protected void btnBuildRepoService_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ServiceBuilder serviceBuilder = new ServiceBuilder(this._getDBConnectionString(), this._getNamespace());
        //        serviceBuilder.BuildRepoService();
        //        if (HttpContext.Current.Session["conStr"] != null)
        //        {
        //            string str = string.Concat("RepoService", this.GetMd5Sum(HttpContext.Current.Session["conStr"].ToString()));
        //            string str1 = serviceBuilder.ZipRepoService(str);
        //            if (!string.IsNullOrEmpty(str1))
        //            {
        //                base.Response.ContentType = "application/zip";
        //                base.Response.AppendHeader("Content-Disposition", string.Format("attachment; filename={0}.zip;", str));
        //                base.Response.WriteFile(str1);
        //                base.Response.Flush();
        //                File.Delete(str1);
        //                base.Response.End();
        //            }
        //        }
        //        base.Response.Redirect(HttpContext.Current.Request.RawUrl);
        //    }
        //    catch (Exception exception)
        //    {
        //        this.Message3.Text = exception.Message;
        //        this.Message3.Style.Add("color", "red");
        //    }
        //}
    }
}