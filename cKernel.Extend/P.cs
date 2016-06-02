using cModel;
using cKernel;
using cDict;

namespace cKernel.Extend
{
    public class P
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId; 
		public P(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for tbl_Departure
		public static void tbl_Departure(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("ValidStartDate").Pc("ValidEndDate").Pc("ValidStartDateOffset").Pc("MaxBookSeat").Pc("EmailTemplateName").Pc("SMSTemplateName").Pc("PrePaidEmailTemplateName").Pc("PrePaidSMSTemplateName").Pc("ReturnSuccessUrlFormat").Pc("ReturnErrorUrlFormat").Pc("App").Pc("Meta").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_Code
		public static void tbl_Route_Code(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteId").Pc("Type").Pc("Code").Pc("Name").Pc("OriginCode").Pc("OriginName").Pc("DestCode").Pc("DestName").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Bank
		public static void tbl_Bank(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("BankType").Pc("CssClass").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Area
		public static void tbl_Area(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("BaseId").Pc("Type").Pc("Code").Pc("Name").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_SoldOut
		public static void tbl_Route_SoldOut(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("RouteId").Pc("FromDate").Pc("ToDate").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PaymentType
		public static void tbl_PaymentType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Description").Pc("App").Pc("Priority").Pc("FromTime").Pc("ToTime").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PaymentType_Detail
		public static void tbl_PaymentType_Detail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PaymentTypeId").Pc("Type").Pc("Code").Pc("Name").Pc("Number").Pc("CssClass").Pc("Description").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PromotionCode
		public static void tbl_PromotionCode(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("ValidFromDate").Pc("ValidToDate").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Branch
		public static void tbl_Branch(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_AllBranchByDate
		public static void tbl_Report_AllBranchByDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("IDBranch").Pc("IDOffice").Pc("DateStart").Pc("TotalTicket").Pc("TotalMoney")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_Scheduler
		public static void tbl_Report_Scheduler(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FromDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_GA_DatetimeQuerry
		public static void tbl_GA_DatetimeQuerry(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Startdate").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_GA_UserLocationRegion
		public static void tbl_GA_UserLocationRegion(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("DatetimeQuerry").Pc("TypeName").Pc("AnGiang").Pc("BaRia_VungTau").Pc("BacGiang").Pc("BacKan").Pc("BacLieu").Pc("BacNinh").Pc("BenTre").Pc("BinhDinh").Pc("BinhPhuoc").Pc("BinhThuan").Pc("CaMau").Pc("CanTho").Pc("CaoBang").Pc("DaNang").Pc("DakNong").Pc("DienBien").Pc("DakLak").Pc("DongThap").Pc("DongNai").Pc("GiaLai").Pc("HaGiang").Pc("HaNam").Pc("HaTinh").Pc("HaiDuong").Pc("HaiPhong").Pc("HaNoi").Pc("HauGiang").Pc("HoChiMinh").Pc("HoaBinh").Pc("HungYen").Pc("KhanhHoa").Pc("KienGiang").Pc("KonTum").Pc("LaiChau").Pc("LamDong").Pc("LangSon").Pc("LaoCai").Pc("LongAn").Pc("NamDinh").Pc("NgheAn").Pc("NinhBinh").Pc("NinhThuan").Pc("PhuTho").Pc("PhuYen").Pc("QuangBinh").Pc("QuangNam").Pc("QuangNgai").Pc("QuangTri").Pc("SocTrang").Pc("SonLa").Pc("TayNinh").Pc("ThaiBinh").Pc("ThaiNguyen").Pc("ThanhHoa").Pc("ThuaThienHue").Pc("TienGiang").Pc("TraVinh").Pc("TuyenQuang").Pc("VinhLong").Pc("VinhPhuc").Pc("YenBai").Pc("BinhDuong").Pc("QuangNinh").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_GA_App
		public static void tbl_GA_App(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("DatetimeQuerry").Pc("AndroidUser").Pc("IosUser").Pc("ANewVisitor").Pc("AReturnVisitor").Pc("INewVisitor").Pc("IReturnVisitor").Pc("ACountDownload").Pc("ICountDownload").Pc("AAvgTime").Pc("IAvgTime").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_GA_Ecommerce
		public static void tbl_GA_Ecommerce(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("DatetimeQuerry").Pc("Transactions").Pc("Sessions").Pc("TotalRevenue").Pc("TransactionsPerSessions").Pc("RevenuePerTransacsions").Pc("ProductListViews").Pc("ProductAddsToCart").Pc("ProductCheckouts").Pc("ItemQuantity").Pc("QuantityAddsToCart").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId").Pc("Client")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_GA_TicketCount
		public static void tbl_GA_TicketCount(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("DatetimeQuerry").Pc("ProductCategory").Pc("ItemRevenue").Pc("ItemQuantity").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId").Pc("Client")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_GA_User
		public static void tbl_GA_User(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("DatetimeQuerry").Pc("TotalUser").Pc("DesktopUser").Pc("MobileUser").Pc("TabletUser").Pc("NewVisitor").Pc("ReturnVisitor").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId").Pc("Client")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Promotion
		public static void tbl_Promotion(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("Description").Pc("ValidFromDate").Pc("ValidToDate").Pc("Image").Pc("AndroidImage").Pc("IOSImage").Pc("Url").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TimeTableFullInfo
		public static void tbl_Report_TimeTableFullInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("Number").Pc("FullName").Pc("FirstName").Pc("Phone").Pc("FullName2").Pc("FirstName2").Pc("Phone2").Pc("SeatBook").Pc("TotalSeat")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_GA_CardCount
		public static void tbl_GA_CardCount(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("DatetimeQuerry").Pc("Client").Pc("CardCode").Pc("CardName").Pc("Sessions").Pc("Transactions").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_GA_Source
		public static void tbl_GA_Source(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("DatetimeQuerry").Pc("Client").Pc("Source").Pc("Transactions").Pc("ItemQuantity").Pc("ItemRevenue").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_Exclude
		public static void tbl_Route_Exclude(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteId").Pc("Type").Pc("Code").Pc("Name").Pc("DepartureDate").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_Stop
		public static void tbl_Route_Stop(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteId").Pc("OfficeId").Pc("Type").Pc("Code").Pc("Name").Pc("OrderNumber").Pc("Distance").Pc("Duration").Pc("ShuttleBefore").Pc("Note").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId").Pc("DepartureTime").Pc("DepartureDate").Pc("Address").Pc("Phone").Pc("Fax").Pc("Latitude").Pc("Longitude")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Branch_Office
		public static void tbl_Branch_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("BranchId").Pc("Type").Pc("Code").Pc("Name").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route
		public static void tbl_Route(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("OriginCode").Pc("OriginName").Pc("DestCode").Pc("DestName").Pc("Distance").Pc("Duration").Pc("Kind").Pc("TotalSchedule").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId").Pc("GroupId").Pc("ReturnId").Pc("StartWorkingDate").Pc("StopWorkingDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Stop
		public static void tbl_Stop(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteId").Pc("WayId").Pc("OfficeId").Pc("Type").Pc("Code").Pc("Name").Pc("Address").Pc("Phone").Pc("Fax").Pc("Latitude").Pc("Longitude").Pc("OrderNumber").Pc("Distance").Pc("Duration").Pc("Passing").Pc("ShuttleBefore").Pc("Note").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_ViFuta_Report
		public static void tbl_ViFuta_Report(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("LastReportTime").Pc("ReportTime").Pc("LastBalance").Pc("Balance").Pc("TotalBooking").Pc("TotalCharge").Pc("TotalWithDraw").Pc("TotalClose").Pc("Status").Pc("IsPrgCreatedDate").Pc("IsPrgUpdatedDate").Pc("IsPrgCreatedUserId").Pc("IsPrgUpdatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}