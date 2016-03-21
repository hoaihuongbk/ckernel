using cModel;
using cKernel;
using cDict;

namespace cKernel.Extend
{
    public class P
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId; 
		public P(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for tbl_PT_GmailAccount
		public static void tbl_PT_GmailAccount(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Email").Pc("Password").Pc("InUse").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PT_MailBox
		public static void tbl_PT_MailBox(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("To").Pc("CC").Pc("BCC").Pc("Subject").Pc("Body").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}