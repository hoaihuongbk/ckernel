using cModel;
using cKernel;
using cDict;

namespace cKernel.Extend
{
    public class PE
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId;
		public PE(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for vw_tbl_DBTable
		public static void vw_tbl_DBTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("TenTV").Pc("GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_tbl_CanBo
		public static void vw_tbl_CanBo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("MaQuanLy").Pc("DiaBanId").Pc("NgaySinh").Pc("NoiSinh").Pc("DiaChi").Pc("DienThoai").Pc("TrinhDo").Pc("NgheNghiep").Pc("NoiLam").Pc("GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_tbl_Quyen
		public static void vw_tbl_Quyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_tbl_NhomQuyen
		public static void vw_tbl_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("DefaultPage")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_tbl_TaiKhoan
		public static void vw_tbl_TaiKhoan(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Username").Pc("Password").Pc("MaNhomQuyen").Pc("CanBoId").Pc("TenMaNhomQuyen").Pc("TenCanBoId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_tbl_Quyen_NhomQuyen
		public static void vw_tbl_Quyen_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MaNhomQuyen").Pc("MaQuyen").Pc("CoQuyen")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_tbl_Menu_CheckRight
		public static void vw_tbl_Menu_CheckRight(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Username").Pc("Id").Pc("Ten").Pc("Url").Pc("MenuCha").Pc("Hinh").Pc("IsEP").Pc("TenTA")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_TaiKhoan_Quyen
		public static void vw_TaiKhoan_Quyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Username").Pc("MaQuyen")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_TaiKhoan
		public static void vw_TaiKhoan(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DefaultPage").Pc("Ten").Pc("Id").Pc("Username").Pc("Password").Pc("MaNhomQuyen").Pc("CanBoId").Pc("TenNhomQuyen").Pc("DiaBanId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_PhanQuyen
		public static void vw_PhanQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Username").Pc("Ten").Pc("Xem").Pc("Them").Pc("Xoa").Pc("Sua")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_tbl_CPC_XE_OnlineSession
		public static void vw_tbl_CPC_XE_OnlineSession(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CurDate").Pc("total").Pc("totalSuccess").Pc("ticket").Pc("ticketSuccess").Pc("totalSuccessExternal").Pc("totalSuccessInternal").Pc("ticketSuccessExternal").Pc("ticketSuccessInternal")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Agent_View
		public static void tbl_CPC_XE_OnlineSession_Agent_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustName").Pc("CustMobile").Pc("CustMobile2").Pc("CustEmail").Pc("CustAddress").Pc("CustPickupType").Pc("CustPickup").Pc("CustPickupOfficeId").Pc("CustCMND").Pc("BookingNo").Pc("NumberOfTicket").Pc("TuyenDuongId").Pc("TuyenDuongName").Pc("NgayDi").Pc("GioDi").Pc("SessionId").Pc("Total").Pc("CurDate").Pc("Status").Pc("PayStatus").Pc("isPrgAccountId").Pc("isPrgInUse").Pc("isPrgCreateDate").Pc("isPrgWaitingConfirmStatus").Pc("isPrgbAdminDeleted").Pc("isPrgbUserDeleted").Pc("isPrgbShow").Pc("isPrgOrdered").Pc("isPrgVNKoDau").Pc("isPrgSmField").Pc("isPrgPartComp").Pc("isPrgEncriptData").Pc("isPrgDescriptData").Pc("PaymentType").Pc("Log").Pc("ClientIP").Pc("CanBoCapNhat").Pc("NgayCapNhat").Pc("NoiDungCapNhat").Pc("ClientApp").Pc("AgentId").Pc("AgentInfo").Pc("ConfirmCode").Pc("AgentProvinceId").Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gcTempData
		public static void gcTempData(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CustEmail").Pc("TuyenDuongId").Pc("NumBook").Pc("ROWNUM")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Agent_DayByDay_View
		public static void tbl_CPC_XE_OnlineSession_Agent_DayByDay_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CurDate").Pc("total").Pc("totalSuccess").Pc("ticket").Pc("ticketSuccess").Pc("totalSuccessExternal").Pc("totalSuccessInternal").Pc("ticketSuccessExternal").Pc("ticketSuccessInternal")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Agent_View_001
		public static void tbl_CPC_XE_OnlineSession_Agent_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustName").Pc("CustMobile").Pc("CustMobile2").Pc("CustEmail").Pc("CustAddress").Pc("CustPickupType").Pc("CustPickup").Pc("CustPickupOfficeId").Pc("CustCMND").Pc("BookingNo").Pc("NumberOfTicket").Pc("TuyenDuongId").Pc("TuyenDuongName").Pc("NgayDi").Pc("GioDi").Pc("SessionId").Pc("Total").Pc("CurDate").Pc("Status").Pc("PayStatus").Pc("isPrgAccountId").Pc("isPrgInUse").Pc("isPrgCreateDate").Pc("isPrgWaitingConfirmStatus").Pc("isPrgbAdminDeleted").Pc("isPrgbUserDeleted").Pc("isPrgbShow").Pc("isPrgOrdered").Pc("isPrgVNKoDau").Pc("isPrgSmField").Pc("isPrgPartComp").Pc("isPrgEncriptData").Pc("isPrgDescriptData").Pc("PaymentType").Pc("Log").Pc("ClientIP").Pc("CanBoCapNhat").Pc("NgayCapNhat").Pc("NoiDungCapNhat").Pc("ClientApp").Pc("AgentId").Pc("AgentInfo").Pc("ConfirmCode").Pc("AgentProvinceId").Pc("PromoCode").Pc("Discount").Pc("Surcharge").Pc("Commission").Pc("TotalMoney").Pc("RealTotalMoney").Pc("AreaCode").Pc("AgentExtendId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Agent_DayByDay_View_001
		public static void tbl_CPC_XE_OnlineSession_Agent_DayByDay_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AgentId").Pc("CurDate").Pc("total").Pc("totalSuccess").Pc("ticket").Pc("ticketSuccess").Pc("totalSuccessExternal").Pc("totalSuccessInternal").Pc("ticketSuccessExternal").Pc("ticketSuccessInternal")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Agent_View_002
		public static void tbl_CPC_XE_OnlineSession_Agent_View_002(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustName").Pc("CustMobile").Pc("CustMobile2").Pc("CustEmail").Pc("CustAddress").Pc("CustPickupType").Pc("CustPickup").Pc("CustPickupOfficeId").Pc("CustCMND").Pc("BookingNo").Pc("NumberOfTicket").Pc("TuyenDuongId").Pc("TuyenDuongName").Pc("NgayDi").Pc("GioDi").Pc("SessionId").Pc("Total").Pc("CurDate").Pc("Status").Pc("PayStatus").Pc("isPrgAccountId").Pc("isPrgInUse").Pc("isPrgCreateDate").Pc("isPrgWaitingConfirmStatus").Pc("isPrgbAdminDeleted").Pc("isPrgbUserDeleted").Pc("isPrgbShow").Pc("isPrgOrdered").Pc("isPrgVNKoDau").Pc("isPrgSmField").Pc("isPrgPartComp").Pc("isPrgEncriptData").Pc("isPrgDescriptData").Pc("PaymentType").Pc("Log").Pc("ClientIP").Pc("CanBoCapNhat").Pc("NgayCapNhat").Pc("NoiDungCapNhat").Pc("ClientApp").Pc("AgentId").Pc("AgentInfo").Pc("ConfirmCode").Pc("AgentProvinceId").Pc("PromoCode").Pc("Discount").Pc("Surcharge").Pc("Commission").Pc("TotalMoney").Pc("RealTotalMoney").Pc("BankCode").Pc("PaymentResult").Pc("PaymentRef").Pc("Msg").Pc("MailStatus").Pc("SMSStatus").Pc("SMSCountRef").Pc("PaymentIDRef").Pc("AreaCode").Pc("AgentExtendId").Pc("SearchKey")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_DayByDay_View
		public static void tbl_CPC_XE_OnlineSession_DayByDay_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CurDate").Pc("total").Pc("totalSuccess").Pc("ticket").Pc("ticketSuccess").Pc("totalSuccessExternal").Pc("totalSuccessInternal").Pc("ticketSuccessExternal").Pc("ticketSuccessInternal")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Customer_View
		public static void tbl_CPC_XE_OnlineSession_Customer_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustName").Pc("CustMobile").Pc("CustMobile2").Pc("CustEmail").Pc("CustAddress").Pc("CustPickupType").Pc("CustPickup").Pc("CustPickupOfficeId").Pc("CustCMND").Pc("BookingNo").Pc("NumberOfTicket").Pc("TuyenDuongId").Pc("TuyenDuongName").Pc("NgayDi").Pc("GioDi").Pc("SessionId").Pc("Total").Pc("CurDate").Pc("Status").Pc("PayStatus").Pc("isPrgAccountId").Pc("isPrgInUse").Pc("isPrgCreateDate").Pc("isPrgWaitingConfirmStatus").Pc("isPrgbAdminDeleted").Pc("isPrgbUserDeleted").Pc("isPrgbShow").Pc("isPrgOrdered").Pc("isPrgVNKoDau").Pc("isPrgSmField").Pc("isPrgPartComp").Pc("isPrgEncriptData").Pc("isPrgDescriptData").Pc("PaymentType").Pc("Log").Pc("ClientIP").Pc("CanBoCapNhat").Pc("NgayCapNhat").Pc("NoiDungCapNhat").Pc("ClientApp").Pc("AgentId").Pc("AgentInfo").Pc("ConfirmCode").Pc("AgentProvinceId").Pc("PromoCode").Pc("Discount").Pc("Surcharge").Pc("Commission").Pc("TotalMoney").Pc("RealTotalMoney").Pc("BankCode").Pc("PaymentResult").Pc("PaymentRef").Pc("Msg").Pc("MailStatus").Pc("SMSStatus").Pc("SMSCountRef").Pc("PaymentIDRef").Pc("AreaCode").Pc("SearchKey")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_CustMoney
		public static void vw_CustMoney(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CustEmail").Pc("NUM").Pc("MONEY")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_tbl_Route_Office
		public static void vw_tbl_Route_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteGroupId").Pc("RouteId").Pc("OfficeId").Pc("Note").Pc("Distance").Pc("Time").Pc("TenRouteGroupId").Pc("TenRouteId").Pc("TenOfficeId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Agent_Extend_DayByDay_View
		public static void tbl_CPC_XE_OnlineSession_Agent_Extend_DayByDay_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AgentId").Pc("AgentExtendId").Pc("CurDate").Pc("total").Pc("totalSuccess").Pc("ticket").Pc("ticketSuccess").Pc("totalSuccessExternal").Pc("totalSuccessInternal").Pc("ticketSuccessExternal").Pc("ticketSuccessInternal")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Customer_RouteHistory_View
		public static void tbl_CPC_XE_OnlineSession_Customer_RouteHistory_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CustEmail").Pc("TuyenDuongId").Pc("NumBook")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_DayByDay_PaymentConversion_View
		public static void tbl_CPC_XE_OnlineSession_DayByDay_PaymentConversion_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CurDate").Pc("total").Pc("totalSuccess").Pc("totalQuocTeSuccess").Pc("totalNoiDiaSuccess").Pc("totalChuyenKhoanSuccess").Pc("totalViFutaSuccess").Pc("totalDaiLySuccess")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_View
		public static void tbl_CPC_XE_OnlineSession_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustName").Pc("CustMobile").Pc("CustMobile2").Pc("CustEmail").Pc("CustAddress").Pc("CustPickupType").Pc("CustPickup").Pc("CustPickupOfficeId").Pc("CustCMND").Pc("BookingNo").Pc("NumberOfTicket").Pc("TuyenDuongId").Pc("TuyenDuongName").Pc("NgayDi").Pc("GioDi").Pc("SessionId").Pc("Total").Pc("CurDate").Pc("Status").Pc("PayStatus").Pc("isPrgAccountId").Pc("isPrgInUse").Pc("isPrgCreateDate").Pc("isPrgWaitingConfirmStatus").Pc("isPrgbAdminDeleted").Pc("isPrgbUserDeleted").Pc("isPrgbShow").Pc("isPrgOrdered").Pc("isPrgVNKoDau").Pc("isPrgSmField").Pc("isPrgPartComp").Pc("isPrgEncriptData").Pc("isPrgDescriptData").Pc("PaymentType").Pc("Log").Pc("ClientIP").Pc("CanBoCapNhat").Pc("NgayCapNhat").Pc("NoiDungCapNhat").Pc("ClientApp").Pc("AgentId").Pc("AgentInfo").Pc("ConfirmCode").Pc("AgentProvinceId").Pc("PromoCode").Pc("Discount").Pc("Surcharge").Pc("Commission").Pc("TotalMoney").Pc("RealTotalMoney").Pc("BankCode").Pc("PaymentResult").Pc("PaymentRef").Pc("Msg").Pc("MailStatus").Pc("SMSStatus").Pc("SMSCountRef").Pc("PaymentIDRef").Pc("AreaCode").Pc("isthisinh").Pc("country").Pc("state").Pc("Redeem").Pc("AgentExtendId").Pc("city").Pc("SMSIDRef").Pc("CustId").Pc("CustCode").Pc("ExpiredTime").Pc("CustBirthDay")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_View_001
		public static void tbl_CPC_XE_OnlineSession_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustName").Pc("CustMobile").Pc("CustMobile2").Pc("CustEmail").Pc("CustAddress").Pc("CustPickupType").Pc("CustPickup").Pc("CustPickupOfficeId").Pc("CustCMND").Pc("BookingNo").Pc("NumberOfTicket").Pc("TuyenDuongId").Pc("TuyenDuongName").Pc("NgayDi").Pc("GioDi").Pc("SessionId").Pc("Total").Pc("CurDate").Pc("Status").Pc("PayStatus").Pc("isPrgAccountId").Pc("isPrgInUse").Pc("isPrgCreateDate").Pc("isPrgWaitingConfirmStatus").Pc("isPrgbAdminDeleted").Pc("isPrgbUserDeleted").Pc("isPrgbShow").Pc("isPrgOrdered").Pc("isPrgVNKoDau").Pc("isPrgSmField").Pc("isPrgPartComp").Pc("isPrgEncriptData").Pc("isPrgDescriptData").Pc("PaymentType").Pc("Log").Pc("ClientIP").Pc("CanBoCapNhat").Pc("NgayCapNhat").Pc("NoiDungCapNhat").Pc("ClientApp").Pc("AgentId").Pc("AgentInfo").Pc("ConfirmCode").Pc("AgentProvinceId").Pc("PromoCode").Pc("Discount").Pc("Surcharge").Pc("Commission").Pc("TotalMoney").Pc("RealTotalMoney").Pc("BankCode").Pc("PaymentResult").Pc("PaymentRef").Pc("Msg").Pc("MailStatus").Pc("SMSStatus").Pc("SMSCountRef").Pc("PaymentIDRef").Pc("AreaCode").Pc("isthisinh").Pc("country").Pc("state").Pc("Redeem").Pc("AgentExtendId").Pc("city").Pc("SMSIDRef").Pc("CustId").Pc("CustCode").Pc("ExpiredTime").Pc("SearchKey")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for vw_Route_Branch
		public static void vw_Route_Branch(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDBranch").Pc("BranchName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TotalStatusTicketByDateByIDRoute_View
		public static void tbl_Report_TotalStatusTicketByDateByIDRoute_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("Date").Pc("TotalSchedule").Pc("TotalScheduleCancel").Pc("TotalBook").Pc("TotalEmpty").Pc("TotalLock").Pc("TotalPay").Pc("TotalPayOnline").Pc("TotalSeat").Pc("TotalMoneyPay").Pc("IDBranch").Pc("TotalTicketBranch").Pc("TotalMoneyBranch")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TotalStatusTicketByDate_View
		public static void tbl_Report_TotalStatusTicketByDate_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Date").Pc("TotalSchedule").Pc("TotalScheduleCancel").Pc("TotalBook").Pc("TotalEmpty").Pc("TotalLock").Pc("TotalPay").Pc("TotalPayOnline").Pc("TotalSeat").Pc("TotalMoneyPay")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TotalStatusTicketByDateByIDRoute_View_001
		public static void tbl_Report_TotalStatusTicketByDateByIDRoute_View_001(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("Year").Pc("Month").Pc("TotalSchedule").Pc("TotalPay").Pc("TotalSeat").Pc("TotalMoneyPay")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for TimeTalbe_GetByDate
		public static void TimeTalbe_GetByDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("DateStart")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Route_GetAllByIDUser
		public static void Route_GetAllByIDUser(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDOffice").Pc("Kind")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Price_GetListPriceOnline
		public static void Price_GetListPriceOnline(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Date")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Price_GetListByIDRoute
		public static void Price_GetListByIDRoute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("Date")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for PickupRoute_GetAll
		public static void PickupRoute_GetAll(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for OfficeRoute_GetListByIDRoute
		public static void OfficeRoute_GetListByIDRoute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Quyen
		public static void sp_Add_tbl_Quyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Ten").Pc("p_GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_NhomQuyen
		public static void sp_Add_tbl_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Ten").Pc("p_DefaultPage")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Menu
		public static void sp_Add_tbl_Menu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Ten").Pc("p_Url").Pc("p_MenuCha").Pc("p_Hinh").Pc("p_IsEP")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_DBTable
		public static void sp_Add_tbl_DBTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Ten").Pc("p_TenTV").Pc("p_GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_DBLog
		public static void sp_Add_tbl_DBLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Username").Pc("p_ThaoTac").Pc("p_ThoiDiem").Pc("p_TableName").Pc("p_RowId").Pc("p_FunctionFile")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_CPC_XE_OnlineSession_Detail
		public static void sp_Add_tbl_CPC_XE_OnlineSession_Detail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_OnlineSessionId").Pc("p_TicketId").Pc("p_TicketName").Pc("p_carBookingId").Pc("p_price").Pc("p_pass").Pc("p_Other").Pc("p_IsSubmited").Pc("p_IsCanPay").Pc("p_ReplaceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_CPC_XE_OnlineSession
		public static void sp_Add_tbl_CPC_XE_OnlineSession(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_CustName").Pc("p_CustMobile").Pc("p_CustMobile2").Pc("p_CustEmail").Pc("p_CustAddress").Pc("p_CustPickupType").Pc("p_CustPickup").Pc("p_CustPickupOfficeId").Pc("p_CustCMND").Pc("p_BookingNo").Pc("p_NumberOfTicket").Pc("p_TuyenDuongId").Pc("p_TuyenDuongName").Pc("p_NgayDi").Pc("p_GioDi").Pc("p_SessionId").Pc("p_Total").Pc("p_CurDate").Pc("p_Status").Pc("p_PayStatus").Pc("p_PaymentType").Pc("p_Log").Pc("p_ClientIP").Pc("p_IsPrgSmField")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_CanBo
		public static void sp_Add_tbl_CanBo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Ten").Pc("p_MaQuanLy").Pc("p_DiaBanId").Pc("p_NgaySinh").Pc("p_NoiSinh").Pc("p_DiaChi").Pc("p_DienThoai").Pc("p_TrinhDo").Pc("p_NgheNghiep").Pc("p_NoiLam").Pc("p_GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Point_GetAllEnd
		public static void Point_GetAllEnd(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDStageStart")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_SubMenu
		public static void sp_Add_tbl_SubMenu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Ten").Pc("p_Url").Pc("p_SubMenuCha").Pc("p_Hinh").Pc("p_MenuId").Pc("p_GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Quyen
		public static void sp_Delete_tbl_Quyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_NhomQuyen
		public static void sp_Delete_tbl_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Menu
		public static void sp_Delete_tbl_Menu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_DBTable
		public static void sp_Delete_tbl_DBTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_DBLog
		public static void sp_Delete_tbl_DBLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_CPC_XE_OnlineSession_Detail
		public static void sp_Delete_tbl_CPC_XE_OnlineSession_Detail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_CPC_XE_OnlineSession
		public static void sp_Delete_tbl_CPC_XE_OnlineSession(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_CanBo
		public static void sp_Delete_tbl_CanBo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Quyen
		public static void sp_Update_tbl_Quyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Ten").Pc("p_GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_NhomQuyen
		public static void sp_Update_tbl_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Ten").Pc("p_DefaultPage")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Menu
		public static void sp_Update_tbl_Menu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Ten").Pc("p_Url").Pc("p_MenuCha").Pc("p_Hinh").Pc("p_IsEP")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_DBTable
		public static void sp_Update_tbl_DBTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Ten").Pc("p_TenTV").Pc("p_GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_DBLog
		public static void sp_Update_tbl_DBLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Username").Pc("p_ThaoTac").Pc("p_ThoiDiem").Pc("p_TableName").Pc("p_RowId").Pc("p_FunctionFile")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession_Detail
		public static void sp_Update_tbl_CPC_XE_OnlineSession_Detail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_OnlineSessionId").Pc("p_TicketId").Pc("p_TicketName").Pc("p_carBookingId").Pc("p_price").Pc("p_pass").Pc("p_Other").Pc("p_IsSubmited").Pc("p_IsCanPay").Pc("p_ReplaceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession
		public static void sp_Update_tbl_CPC_XE_OnlineSession(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_CustName").Pc("p_CustMobile").Pc("p_CustMobile2").Pc("p_CustEmail").Pc("p_CustAddress").Pc("p_CustPickupType").Pc("p_CustPickup").Pc("p_CustPickupOfficeId").Pc("p_CustCMND").Pc("p_BookingNo").Pc("p_NumberOfTicket").Pc("p_TuyenDuongId").Pc("p_TuyenDuongName").Pc("p_NgayDi").Pc("p_GioDi").Pc("p_SessionId").Pc("p_Total").Pc("p_CurDate").Pc("p_Status").Pc("p_PayStatus").Pc("p_PaymentType").Pc("p_Log").Pc("p_ClientIP").Pc("p_IsPrgSmField")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CanBo
		public static void sp_Update_tbl_CanBo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Ten").Pc("p_MaQuanLy").Pc("p_DiaBanId").Pc("p_NgaySinh").Pc("p_NoiSinh").Pc("p_DiaChi").Pc("p_DienThoai").Pc("p_TrinhDo").Pc("p_NgheNghiep").Pc("p_NoiLam").Pc("p_GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_GetDT_tbl_CPC_XE_OnlineSession_by_BookingNoOrEmail
		public static void sp_GetDT_tbl_CPC_XE_OnlineSession_by_BookingNoOrEmail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Search")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Get_tbl_CPC_XE_OnlineSession_by_Id
		public static void sp_Get_tbl_CPC_XE_OnlineSession_by_Id(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Get_tbl_CPC_XE_OnlineSession_by_BookingNo
		public static void sp_Get_tbl_CPC_XE_OnlineSession_by_BookingNo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_BookingNo")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Get_Booking_Rerult_WithCondition
		public static void sp_Get_Booking_Rerult_WithCondition(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_BookingNo").Pc("p_CustName").Pc("p_CustMobile").Pc("p_CustEmail").Pc("p_CurDateFrom").Pc("p_CurDateTo").Pc("p_Page").Pc("p_PageSize")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_SubMenu
		public static void sp_Delete_tbl_SubMenu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_SubMenu
		public static void sp_Update_tbl_SubMenu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Ten").Pc("p_Url").Pc("p_SubMenuCha").Pc("p_Hinh").Pc("p_MenuId").Pc("p_GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Ticket_Submit2
		public static void Ticket_Submit2(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("IDOfficePickup").Pc("CustomerName").Pc("Birth").Pc("Phone").Pc("Street").Pc("CustomerInfo").Pc("Price").Pc("Note").Pc("PickUpStreet").Pc("IDCarBooking").Pc("Chair").Pc("IDMember")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Ticket_Submit
		public static void Ticket_Submit(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("IDOfficePickup").Pc("CustomerName").Pc("Birth").Pc("Phone").Pc("Street").Pc("CustomerInfo").Pc("Price").Pc("Note").Pc("PickUpStreet").Pc("IDCarBooking").Pc("Chair").Pc("IDMember")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Ticket_SetSelect
		public static void Ticket_SetSelect(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDMember")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Ticket_Pay
		public static void Ticket_Pay(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDMember").Pc("IDCarbooking").Pc("Chair")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Ticket_Cancel
		public static void Ticket_Cancel(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDMember")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Quyen_NhomQuyen
		public static void sp_Update_tbl_Quyen_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_MaNhomQuyen").Pc("p_MaQuyen").Pc("p_CoQuyen")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Quyen_Menu
		public static void sp_Update_tbl_Quyen_Menu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_QuyenId").Pc("p_MenuId").Pc("p_ChoPhep")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Quyen_ChiTiet
		public static void sp_Update_tbl_Quyen_ChiTiet(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_QuyenId").Pc("p_BangId").Pc("p_Xem").Pc("p_Them").Pc("p_Xoa").Pc("p_Sua")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Quyen_NhomQuyen
		public static void sp_Delete_tbl_Quyen_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Quyen_Menu
		public static void sp_Delete_tbl_Quyen_Menu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Quyen_ChiTiet
		public static void sp_Delete_tbl_Quyen_ChiTiet(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_TaiKhoan
		public static void sp_Update_tbl_TaiKhoan(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Username").Pc("p_Password").Pc("p_MaNhomQuyen").Pc("p_CanBoId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_TaiKhoan
		public static void sp_Delete_tbl_TaiKhoan(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_TaiKhoan
		public static void sp_Add_tbl_TaiKhoan(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Username").Pc("p_Password").Pc("p_MaNhomQuyen").Pc("p_CanBoId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Quyen_NhomQuyen
		public static void sp_Add_tbl_Quyen_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_MaNhomQuyen").Pc("p_MaQuyen").Pc("p_CoQuyen")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Quyen_Menu
		public static void sp_Add_tbl_Quyen_Menu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_QuyenId").Pc("p_MenuId").Pc("p_ChoPhep")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Quyen_ChiTiet
		public static void sp_Add_tbl_Quyen_ChiTiet(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_QuyenId").Pc("p_BangId").Pc("p_Xem").Pc("p_Them").Pc("p_Xoa").Pc("p_Sua")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CarBooking_GetDetailByID
		public static void CarBooking_GetDetailByID(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession_NhanVien
		public static void sp_Update_tbl_CPC_XE_OnlineSession_NhanVien(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_CustName").Pc("p_CustMobile").Pc("p_CustMobile2").Pc("p_CustEmail").Pc("p_CustAddress").Pc("p_CustPickupType").Pc("p_CustPickup").Pc("p_CustPickupOfficeId").Pc("p_CustCMND").Pc("p_BookingNo").Pc("p_NumberOfTicket").Pc("p_TuyenDuongId").Pc("p_TuyenDuongName").Pc("p_NgayDi").Pc("p_GioDi").Pc("p_SessionId").Pc("p_Total").Pc("p_CurDate").Pc("p_Status").Pc("p_PayStatus").Pc("p_PaymentType").Pc("p_Log").Pc("p_ClientIP").Pc("p_IsPrgSmField").Pc("p_CanBoCapNhat").Pc("p_NoiDungCapNhat")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_CPC_XE_OnlineSession_loc
		public static void sp_Add_tbl_CPC_XE_OnlineSession_loc(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_CustName").Pc("p_CustMobile").Pc("p_CustMobile2").Pc("p_CustEmail").Pc("p_CustAddress").Pc("p_CustPickupType").Pc("p_CustPickup").Pc("p_CustPickupOfficeId").Pc("p_CustCMND").Pc("p_BookingNo").Pc("p_NumberOfTicket").Pc("p_TuyenDuongId").Pc("p_TuyenDuongName").Pc("p_NgayDi").Pc("p_GioDi").Pc("p_SessionId").Pc("p_Total").Pc("p_CurDate").Pc("p_Status").Pc("p_PayStatus").Pc("p_PaymentType").Pc("p_Log").Pc("p_ClientIP").Pc("p_ClientApp")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_CPC_XE_OnlineSession_Detail_loc
		public static void sp_Add_tbl_CPC_XE_OnlineSession_Detail_loc(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_OnlineSessionId").Pc("p_TicketId").Pc("p_TicketName").Pc("p_carBookingId").Pc("p_price").Pc("p_pass").Pc("p_Other").Pc("p_IsSubmited").Pc("p_IsCanPay").Pc("p_ReplaceId").Pc("p_idStrib")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession_loc
		public static void sp_Update_tbl_CPC_XE_OnlineSession_loc(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_CustName").Pc("p_CustMobile").Pc("p_CustMobile2").Pc("p_CustEmail").Pc("p_CustAddress").Pc("p_CustPickupType").Pc("p_CustPickup").Pc("p_CustPickupOfficeId").Pc("p_CustCMND").Pc("p_BookingNo").Pc("p_NumberOfTicket").Pc("p_TuyenDuongId").Pc("p_TuyenDuongName").Pc("p_NgayDi").Pc("p_GioDi").Pc("p_SessionId").Pc("p_Total").Pc("p_CurDate").Pc("p_Status").Pc("p_PayStatus").Pc("p_PaymentType").Pc("p_Log").Pc("p_ClientIP").Pc("p_ClientApp")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession_Detail_loc
		public static void sp_Update_tbl_CPC_XE_OnlineSession_Detail_loc(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_OnlineSessionId").Pc("p_TicketId").Pc("p_TicketName").Pc("p_carBookingId").Pc("p_price").Pc("p_pass").Pc("p_Other").Pc("p_IsSubmited").Pc("p_IsCanPay").Pc("p_ReplaceId").Pc("p_idStrib")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession_Detail_Submit
		public static void sp_Update_tbl_CPC_XE_OnlineSession_Detail_Submit(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_OnlineSessionId").Pc("p_TicketId").Pc("p_IsSubmited")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Get_tbl_CPC_XE_OnlineSession_Detail_by_SessionId
		public static void sp_Get_tbl_CPC_XE_OnlineSession_Detail_by_SessionId(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Get_tbl_CPC_XE_OnlineSession_Detail_by_Id
		public static void sp_Get_tbl_CPC_XE_OnlineSession_Detail_by_Id(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for WEBSITE_PT_CREATEUSER
		public static void WEBSITE_PT_CREATEUSER(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Password").Pc("p_Email").Pc("p_HoTen").Pc("p_Phone").Pc("p_NgaySinh").Pc("p_GioiTinh").Pc("p_Avatar")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Get_tbl_CPC_XE_OnlineSession_by_AgentId
		public static void sp_Get_tbl_CPC_XE_OnlineSession_by_AgentId(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_AgentId").Pc("p_Page").Pc("p_NumItemPerPage")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession_ByCodeInCurrentSession
		public static void sp_Update_tbl_CPC_XE_OnlineSession_ByCodeInCurrentSession(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_BookingNo").Pc("p_SesstionId").Pc("p_mStatus").Pc("p_mPayStatus").Pc("p_mCanBoCapNhat").Pc("p_mNoiDungCapNhat")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession_ConfirmCode
		public static void sp_Update_tbl_CPC_XE_OnlineSession_ConfirmCode(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_BookingNo").Pc("p_SesstionId").Pc("p_mConfirmCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Get_tbl_CPC_XE_OnlineSession_BookingSummary
		public static void sp_Get_tbl_CPC_XE_OnlineSession_BookingSummary(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_AgentId").Pc("p_Commission")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_CPC_XE_OnlineSession_WithAgentInfo
		public static void sp_Add_tbl_CPC_XE_OnlineSession_WithAgentInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_CustName").Pc("p_CustMobile").Pc("p_CustMobile2").Pc("p_CustEmail").Pc("p_CustAddress").Pc("p_CustPickupType").Pc("p_CustPickup").Pc("p_CustPickupOfficeId").Pc("p_CustCMND").Pc("p_BookingNo").Pc("p_NumberOfTicket").Pc("p_TuyenDuongId").Pc("p_TuyenDuongName").Pc("p_NgayDi").Pc("p_GioDi").Pc("p_SessionId").Pc("p_Total").Pc("p_CurDate").Pc("p_Status").Pc("p_PayStatus").Pc("p_PaymentType").Pc("p_Log").Pc("p_ClientIP").Pc("p_IsPrgSmField").Pc("p_AgentId").Pc("p_AgentInfo").Pc("p_AgentProvinceId").Pc("p_Discount").Pc("p_Surcharge").Pc("p_TotalMoney").Pc("p_Commission").Pc("p_RealTotalMoney").Pc("p_AreaCode").Pc("p_PromoCode").Pc("p_AgentExtendId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gcGetPaginationData
		public static void gcGetPaginationData(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("table").Pc("column").Pc("sort").Pc("filter").Pc("index").Pc("numOfRow")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_GetAgentBookingDetailWithTotalSummary
		public static void sp_GetAgentBookingDetailWithTotalSummary(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_CPC_XE_OnlineSession_CustomerInfo
		public static void sp_Update_tbl_CPC_XE_OnlineSession_CustomerInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustName").Pc("CustEmail").Pc("CustMobile").Pc("CustCMND").Pc("CustPickup").Pc("CustPickupOfficeId").Pc("CanBoCapNhat").Pc("NoiDungCapNhat")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTotalTodayBooking
		public static void sgc_GetTotalTodayBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTotalTodaySuccessBooking
		public static void sgc_GetTotalTodaySuccessBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTotalTodayRealMoney
		public static void sgc_GetTotalTodayRealMoney(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTotalTodayCommission
		public static void sgc_GetTotalTodayCommission(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetLastWeekReportAsChart
		public static void sgc_GetLastWeekReportAsChart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetLastWeekReportAsTable
		public static void sgc_GetLastWeekReportAsTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTotalBooking
		public static void sgc_GetTotalBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTotalSuccessBooking
		public static void sgc_GetTotalSuccessBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTotalRealMoney
		public static void sgc_GetTotalRealMoney(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTotalCommission
		public static void sgc_GetTotalCommission(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetCurrentYearReportAsChart
		public static void sgc_GetCurrentYearReportAsChart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetCurrentYearCommisionPercentReportAsChart
		public static void sgc_GetCurrentYearCommisionPercentReportAsChart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetTop10RouteRevenueIn3MonthAsTable
		public static void sgc_GetTop10RouteRevenueIn3MonthAsTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for GetPaginationData
		public static void GetPaginationData(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("table").Pc("column").Pc("sort").Pc("filter").Pc("index").Pc("numOfRow")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetNumberWaitingAgentBooking
		public static void sgc_GetNumberWaitingAgentBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Cat_Cost
		public static void sp_Add_tbl_Cat_Cost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Code").Pc("p_Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Cat_Event
		public static void sp_Add_tbl_Cat_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Code").Pc("p_Name").Pc("p_Note").Pc("p_Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Cat_Route
		public static void sp_Add_tbl_Cat_Route(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Name").Pc("p_RouteGroupId").Pc("p_StartPointId").Pc("p_EndPointId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Cat_RouteGroup
		public static void sp_Add_tbl_Cat_RouteGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Name").Pc("p_Distance").Pc("p_QuantityOfCar").Pc("p_Price").Pc("p_BreakEvenPoint")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Route_Cost
		public static void sp_Add_tbl_Route_Cost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_RouteGroupId").Pc("p_RouteId").Pc("p_CostId").Pc("p_Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Route_Event
		public static void sp_Add_tbl_Route_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_RouteGroupId").Pc("p_RouteId").Pc("p_EventId").Pc("p_FromDate").Pc("p_ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Cat_Cost
		public static void sp_Update_tbl_Cat_Cost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Code").Pc("p_Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Cat_Event
		public static void sp_Update_tbl_Cat_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Code").Pc("p_Name").Pc("p_Note").Pc("p_Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Cat_Route
		public static void sp_Update_tbl_Cat_Route(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Name").Pc("p_RouteGroupId").Pc("p_StartPointId").Pc("p_EndPointId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Cat_RouteGroup
		public static void sp_Update_tbl_Cat_RouteGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Name").Pc("p_Distance").Pc("p_QuantityOfCar").Pc("p_Price").Pc("p_BreakEvenPoint")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Route_Cost
		public static void sp_Update_tbl_Route_Cost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_RouteGroupId").Pc("p_RouteId").Pc("p_CostId").Pc("p_Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Route_Event
		public static void sp_Update_tbl_Route_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_RouteGroupId").Pc("p_RouteId").Pc("p_EventId").Pc("p_FromDate").Pc("p_ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Cat_Cost
		public static void sp_Delete_tbl_Cat_Cost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Cat_Event
		public static void sp_Delete_tbl_Cat_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Cat_Route
		public static void sp_Delete_tbl_Cat_Route(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Cat_RouteGroup
		public static void sp_Delete_tbl_Cat_RouteGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Route_Cost
		public static void sp_Delete_tbl_Route_Cost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Route_Event
		public static void sp_Delete_tbl_Route_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTotalTodayBooking
		public static void slyt_GetTotalTodayBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTotalTodaySuccessBooking
		public static void slyt_GetTotalTodaySuccessBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTotalTodayBookingByPaymentType
		public static void slyt_GetTotalTodayBookingByPaymentType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PaymentType").Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTotalBooking
		public static void slyt_GetTotalBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTotalSuccessBooking
		public static void slyt_GetTotalSuccessBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTotalBookingByPaymentType
		public static void slyt_GetTotalBookingByPaymentType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PaymentType").Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetLastWeekReportAsChart
		public static void slyt_GetLastWeekReportAsChart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetLastWeekReportAsTable
		public static void slyt_GetLastWeekReportAsTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetCurrentYearReportAsChart
		public static void slyt_GetCurrentYearReportAsChart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTop10RouteRevenueIn3MonthAsTable
		public static void slyt_GetTop10RouteRevenueIn3MonthAsTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetNumberWaitingCustomerBooking
		public static void slyt_GetNumberWaitingCustomerBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Route_Company
		public static void sp_Add_tbl_Route_Company(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_RouteGroupId").Pc("p_RouteId").Pc("p_Name").Pc("p_Address").Pc("p_Phone").Pc("p_NumOfCar").Pc("p_Price")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Route_Company
		public static void sp_Update_tbl_Route_Company(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_RouteGroupId").Pc("p_RouteId").Pc("p_Name").Pc("p_Address").Pc("p_Phone").Pc("p_NumOfCar").Pc("p_Price")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Route_Company
		public static void sp_Delete_tbl_Route_Company(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Cat_Office
		public static void sp_Add_tbl_Cat_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Code").Pc("p_Name").Pc("p_Address").Pc("p_Phone").Pc("p_Manager").Pc("p_ManagerMobile")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Cat_Office
		public static void sp_Update_tbl_Cat_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_Code").Pc("p_Name").Pc("p_Address").Pc("p_Phone").Pc("p_Manager").Pc("p_ManagerMobile")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Cat_Office
		public static void sp_Delete_tbl_Cat_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Delete_tbl_Route_Office
		public static void sp_Delete_tbl_Route_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Add_tbl_Route_Office
		public static void sp_Add_tbl_Route_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_RouteGroupId").Pc("p_RouteId").Pc("p_OfficeId").Pc("p_Note").Pc("p_Distance").Pc("p_Time")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sp_Update_tbl_Route_Office
		public static void sp_Update_tbl_Route_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("p_Id").Pc("p_RouteGroupId").Pc("p_RouteId").Pc("p_OfficeId").Pc("p_Note").Pc("p_Distance").Pc("p_Time")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_GetNumberWaitingAgentBookingByAgentId
		public static void sgc_GetNumberWaitingAgentBookingByAgentId(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AgentId").Pc("AgentExtendId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sgc_CPC_GetAgentExtendReportTicketStatus
		public static void sgc_CPC_GetAgentExtendReportTicketStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AgentId").Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateReportTotalStatusTicketByDate
		public static void slyt_InsertOrUpdateReportTotalStatusTicketByDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Date").Pc("TotalSchedule").Pc("TotalScheduleCancel").Pc("TotalBook").Pc("TotalEmpty").Pc("TotalPay").Pc("TotalPayOnline").Pc("TotalSeat").Pc("TotalMoneyPay")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateReportTotalStatusTicketByDateAndIDRoute
		public static void slyt_InsertOrUpdateReportTotalStatusTicketByDateAndIDRoute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("Date").Pc("TotalSchedule").Pc("TotalScheduleCancel").Pc("TotalBook").Pc("TotalEmpty").Pc("TotalPay").Pc("TotalPayOnline").Pc("TotalSeat").Pc("TotalMoneyPay")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateRouteTimeTable
		public static void slyt_InsertOrUpdateRouteTimeTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("Number").Pc("FullName").Pc("FirstName").Pc("Phone").Pc("FullName2").Pc("FirstName2").Pc("Phone2").Pc("SeatBook")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTotalBookingByDevice
		public static void slyt_GetTotalBookingByDevice(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Device").Pc("DepartureDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetReportAsChartByYear
		public static void slyt_GetReportAsChartByYear(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("SelectYear")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_ReSubmitTicket
		public static void slyt_ReSubmitTicket(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("OnlineSessionId").Pc("TicketId").Pc("TicketName").Pc("carBookingId").Pc("price").Pc("Other").Pc("idStrib").Pc("CustName").Pc("CustMobile").Pc("CustCMND").Pc("OldId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetReportTotalStatusTicketAllRouteByDate
		public static void slyt_GetReportTotalStatusTicketAllRouteByDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Date")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_InsertOrUpdateReportTotalStatusTicketByDateAndIDRouteAndIDBranch
		public static void slyt_InsertOrUpdateReportTotalStatusTicketByDateAndIDRouteAndIDBranch(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("Date").Pc("TotalSchedule").Pc("TotalScheduleCancel").Pc("TotalBook").Pc("TotalEmpty").Pc("TotalPay").Pc("TotalPayOnline").Pc("TotalSeat").Pc("TotalMoneyPay").Pc("IDBranch").Pc("TotalTicketBranch").Pc("TotalMoneyBranch")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_CheckReportRouteTableMissingDate
		public static void slyt_CheckReportRouteTableMissingDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RouteId").Pc("startdate").Pc("enddate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetDayReport
		public static void slyt_GetDayReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Year").Pc("Month")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTop10DESCRouteReport
		public static void slyt_GetTop10DESCRouteReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Year").Pc("Month").Pc("N")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTop10ASCRouteReport
		public static void slyt_GetTop10ASCRouteReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Year").Pc("Month").Pc("N")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTop10RouteReport
		public static void slyt_GetTop10RouteReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Year").Pc("Month")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTop10DESCRouteReportByDateRange
		public static void slyt_GetTop10DESCRouteReportByDateRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("FromDate").Pc("ToDate").Pc("N")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetTop10ASCRouteReportByDateRange
		public static void slyt_GetTop10ASCRouteReportByDateRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("FromDate").Pc("ToDate").Pc("N")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_DeleteTotalStatusTicketByDateByIDRoute
		public static void slyt_DeleteTotalStatusTicketByDateByIDRoute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetReportAsChart
		public static void slyt_GetReportAsChart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Period")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for slyt_GetReportAsTable
		public static void slyt_GetReportAsTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Period")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}