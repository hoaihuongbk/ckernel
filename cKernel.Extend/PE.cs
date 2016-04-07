using cModel;
using cKernel;
using cDict;

namespace cKernel.Extend
{
    public class PE
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId;
		public PE(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for tbl_Route_Stop_Exclude_View
		public static void tbl_Route_Stop_Exclude_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteId").Pc("OfficeId").Pc("DepartureTime").Pc("DepartureDate").Pc("Type").Pc("Code").Pc("Name").Pc("Address").Pc("Phone").Pc("Fax").Pc("Latitude").Pc("Longitude").Pc("OrderNumber").Pc("Distance").Pc("Duration").Pc("Note").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_View_001
		public static void tbl_Route_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("OriginCode").Pc("OriginName").Pc("DestCode").Pc("DestName").Pc("Distance").Pc("Duration").Pc("TotalSchedule").Pc("Kind").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_AllBranchByDate_View_001
		public static void tbl_Report_AllBranchByDate_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("IDBranch").Pc("DateStart").Pc("TotalTicket").Pc("TotalMoney")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_AllBranchByDate_View_002
		public static void tbl_Report_AllBranchByDate_View_002(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDBranch").Pc("DateStart").Pc("TotalTicket").Pc("TotalMoney")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_AllBranchByDate_View_003
		public static void tbl_Report_AllBranchByDate_View_003(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDOffice").Pc("DateStart").Pc("TotalTicket").Pc("TotalMoney")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_AllBranchByDate_View_004
		public static void tbl_Report_AllBranchByDate_View_004(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("DateStart").Pc("TotalTicket").Pc("TotalMoney")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TimeTableFullInfo_View_001
		public static void tbl_Report_TimeTableFullInfo_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("TotalSeat").Pc("SeatBook").Pc("StartHour").Pc("StartMinute")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TimeTableFullInfo_View_002
		public static void tbl_Report_TimeTableFullInfo_View_002(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("TotalSeat").Pc("SeatBook").Pc("StartHour").Pc("StartMinute")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TimeTableFullInfo_View_003
		public static void tbl_Report_TimeTableFullInfo_View_003(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("StartDate").Pc("StartHour").Pc("StartMinute").Pc("TotalSeat").Pc("SeatBook").Pc("TotalTime")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TimeTableFullInfo_View_004
		public static void tbl_Report_TimeTableFullInfo_View_004(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("TotalSeat").Pc("SeatBook").Pc("TotalTime")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_AllBranchByDate_View_005
		public static void tbl_Report_AllBranchByDate_View_005(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("RouteName").Pc("DateStart").Pc("TotalTicket").Pc("TotalMoney")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TimeTableFullInfo_View_005
		public static void tbl_Report_TimeTableFullInfo_View_005(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("TotalSeat").Pc("SeatBook").Pc("TotalTime").Pc("RouteName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TimeTableFullInfo_View_001_1
		public static void tbl_Report_TimeTableFullInfo_View_001_1(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("TotalSeat").Pc("SeatBook").Pc("StartHour").Pc("FStartMinute").Pc("LStartMinute")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TimeTableFullInfo_View_006
		public static void tbl_Report_TimeTableFullInfo_View_006(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("Number").Pc("TotalSeat").Pc("SeatBook").Pc("RouteName").Pc("ReturnId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateReportAllBranchByDate
		public static void slyt_InsertOrUpdateReportAllBranchByDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("IDBranch").Pc("IDOffice").Pc("DateStart").Pc("TotalTicket").Pc("TotalMoney")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetOfficeReport
		public static void slyt_GetOfficeReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetBranchReport
		public static void slyt_GetBranchReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateRouteStop
		public static void slyt_InsertOrUpdateRouteStop(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Type").Pc("OfficeId").Pc("RouteId").Pc("Code").Pc("Name").Pc("Address").Pc("Phone").Pc("Fax")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateRouteTimeTable
		public static void slyt_InsertOrUpdateRouteTimeTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("Number").Pc("FullName").Pc("FirstName").Pc("Phone").Pc("FullName2").Pc("FirstName2").Pc("Phone2").Pc("TotalSeat").Pc("SeatBook")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetRouteTimeReport
		public static void slyt_GetRouteTimeReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RouteId").Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetRouteTimeDetailReport
		public static void slyt_GetRouteTimeDetailReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Time").Pc("RouteId").Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateRoute
		public static void slyt_InsertOrUpdateRoute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Name").Pc("Kind")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetRouteDepartureReport
		public static void slyt_GetRouteDepartureReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DepartureDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetListRouteForReport
		public static void slyt_GetListRouteForReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateBranch
		public static void slyt_InsertOrUpdateBranch(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateBranchOffice
		public static void slyt_InsertOrUpdateBranchOffice(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("BranchId").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_DeleteReportAllBranchByDate
		public static void slyt_DeleteReportAllBranchByDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}