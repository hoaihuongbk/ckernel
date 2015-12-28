using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cModel;
using cService;

namespace CTool
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    var s = new S("112.213.84.113;database=FutaAgent;uid=huongvhh;pwd=huong@123;", false);
        //    var obj = new GCRequest()
        //    {
        //        _a = "Updatetbl_PT_User",
        //        _c = new Dictionary<string, object>()
        //        {
        //            {"Email", "hoaihuongvuonghuynh@gmail.com" }
        //        },
        //        _d = new Dictionary<string, object>()
        //       {
        //           {"Password", EncryptPassword("futa@123456")}
        //       }
        //    };

        //    var robj = s.P(obj);
        //    if (robj.Result.Equals(1) && robj.Records.Any())
        //    {
        //    }
        //}

        //protected string EncryptPassword(string sPassword)
        //{
        //    var md5Hasher = new MD5CryptoServiceProvider();
        //    var hashedDataBytes = md5Hasher.ComputeHash(System.Text.Encoding.UTF8.GetBytes(sPassword));
        //    var sEncryptPass = Convert.ToBase64String(hashedDataBytes);
        //    return sEncryptPass;
        //}
    }
}