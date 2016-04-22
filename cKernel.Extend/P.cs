using cModel;
using cKernel;
using cDict;

namespace cKernel.Extend
{
    public class P
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId; 
		public P(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for tbl_PT_Permission
		public static void tbl_PT_Permission(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Module").Pc("Description").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PT_Group_Permission
		public static void tbl_PT_Group_Permission(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupId").Pc("PermissionId").Pc("Type").Pc("Code").Pc("Name").Pc("Description").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for lyt_PT_Manager
		public static void lyt_PT_Manager(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupId").Pc("Type").Pc("Code").Pc("UserName").Pc("Password").Pc("Name").Pc("FullName").Pc("PrimaryPhone").Pc("PrimaryEmail").Pc("Address").Pc("ProvinceId").Pc("AreaCode").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PT_Group
		public static void tbl_PT_Group(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Description").Pc("Color").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PaymentType
		public static void tbl_PaymentType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PaymentStatus
		public static void tbl_PaymentStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_TicketStatus
		public static void tbl_TicketStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Taxi_Type
		public static void tbl_Taxi_Type(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Ticket
		public static void tbl_Ticket(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustId").Pc("DriverId").Pc("Type").Pc("Code").Pc("Name").Pc("CustName").Pc("CustEmail").Pc("CustMobile").Pc("DriverName").Pc("DriverMobile").Pc("DepartureDate").Pc("DepatureTime").Pc("SrcLat").Pc("SrcLng").Pc("DestLat").Pc("DestLng").Pc("SrcAddr").Pc("DestAddr").Pc("TaxiType").Pc("Price").Pc("Distance").Pc("SubTotal").Pc("Discount").Pc("Surcharge").Pc("Total").Pc("PromoCode").Pc("Status").Pc("PaymentStatus").Pc("PaymentType").Pc("MailStatus").Pc("SMSStatus").Pc("SMSRefId").Pc("ExpiredTime").Pc("SessionId").Pc("ClientIP").Pc("ClientApp").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Driver
		public static void tbl_Driver(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("UserName").Pc("Password").Pc("FullName").Pc("PrimaryPhone").Pc("PrimaryEmail").Pc("Address").Pc("ProvinceId").Pc("CityId").Pc("TaxiType").Pc("Number").Pc("Latitude").Pc("Longitude").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}