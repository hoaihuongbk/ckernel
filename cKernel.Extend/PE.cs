using cModel;
using cKernel;
using cDict;

namespace cKernel.Extend
{
    public class PE
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId;
		public PE(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for tbl_Driver_View_001
		public static void tbl_Driver_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("UserName").Pc("FullName").Pc("PrimaryPhone").Pc("PrimaryEmail").Pc("Address").Pc("ProvinceId").Pc("CityId").Pc("TaxiType").Pc("Number").Pc("Latitude").Pc("Longitude").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PT_Group_Permission_View_001
		public static void tbl_PT_Group_Permission_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("GroupId").Pc("PermissionId").Pc("Name").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for GetPermissionByGroupAndModule
		public static void GetPermissionByGroupAndModule(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("GroupId").Pc("Module")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for InsertOrUpdatePermission
		public static void InsertOrUpdatePermission(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("GroupId").Pc("PermissionId").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UpdateManager
		public static void UpdateManager(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Password").Pc("FullName").Pc("PrimaryPhone").Pc("Address").Pc("ProvinceId").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}