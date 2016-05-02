using cModel;
using cKernel;
using cDict;

namespace cKernel.Extend
{
    public class P
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId; 
		public P(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for tbl_Quyen
		public static void tbl_Quyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_NhomQuyen
		public static void tbl_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("DefaultPage")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_DBTable
		public static void tbl_DBTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("TenTV").Pc("GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_DBLog
		public static void tbl_DBLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Username").Pc("ThaoTac").Pc("ThoiDiem").Pc("TableName").Pc("RowId").Pc("FunctionFile")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession
		public static void tbl_CPC_XE_OnlineSession(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustName").Pc("CustMobile").Pc("CustMobile2").Pc("CustEmail").Pc("CustAddress").Pc("CustPickupType").Pc("CustPickup").Pc("CustPickupOfficeId").Pc("CustCMND").Pc("BookingNo").Pc("NumberOfTicket").Pc("TuyenDuongId").Pc("TuyenDuongName").Pc("NgayDi").Pc("GioDi").Pc("SessionId").Pc("Total").Pc("CurDate").Pc("Status").Pc("PayStatus").Pc("isPrgAccountId").Pc("isPrgInUse").Pc("isPrgCreateDate").Pc("isPrgWaitingConfirmStatus").Pc("isPrgbAdminDeleted").Pc("isPrgbUserDeleted").Pc("isPrgbShow").Pc("isPrgOrdered").Pc("isPrgVNKoDau").Pc("isPrgSmField").Pc("isPrgPartComp").Pc("isPrgEncriptData").Pc("isPrgDescriptData").Pc("PaymentType").Pc("Log").Pc("ClientIP").Pc("CanBoCapNhat").Pc("NgayCapNhat").Pc("NoiDungCapNhat").Pc("ClientApp").Pc("AgentId").Pc("AgentInfo").Pc("ConfirmCode").Pc("AgentProvinceId").Pc("PromoCode").Pc("Discount").Pc("Surcharge").Pc("Commission").Pc("TotalMoney").Pc("RealTotalMoney").Pc("BankCode").Pc("PaymentResult").Pc("PaymentRef").Pc("Msg").Pc("MailStatus").Pc("SMSStatus").Pc("SMSCountRef").Pc("PaymentIDRef").Pc("AreaCode").Pc("isthisinh").Pc("country").Pc("state").Pc("Redeem").Pc("AgentExtendId").Pc("city").Pc("SMSIDRef").Pc("CustId").Pc("CustCode").Pc("ExpiredTime").Pc("CustBirthDay")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CanBo
		public static void tbl_CanBo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("MaQuanLy").Pc("DiaBanId").Pc("NgaySinh").Pc("NoiSinh").Pc("DiaChi").Pc("DienThoai").Pc("TrinhDo").Pc("NgheNghiep").Pc("NoiLam").Pc("GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Stage
		public static void Stage(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("Code").Pc("Name").Pc("Priority").Pc("Note").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for TicketLog
		public static void TicketLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDCarBooking").Pc("Kind").Pc("Chair").Pc("Phone").Pc("Price").Pc("Free").Pc("LogDetail").Pc("CreatedID").Pc("CreatedDate").Pc("IDUserBook").Pc("DateBook")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_SubMenu
		public static void tbl_SubMenu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("Url").Pc("SubMenuCha").Pc("Hinh").Pc("MenuId").Pc("GhiChu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Price
		public static void Price(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("IDStageStart").Pc("IDStageEnd").Pc("IDKind").Pc("Code").Pc("Name").Pc("Money").Pc("Priority").Pc("Note").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status").Pc("Discount").Pc("Commison").Pc("DateStart").Pc("DateEnd")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for OfficeRoute
		public static void OfficeRoute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDOffice").Pc("IDRoute").Pc("Kind")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Office
		public static void Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDSystem").Pc("Code").Pc("Name").Pc("Address").Pc("Phone").Pc("Fax").Pc("HeadOffice").Pc("BookReturn").Pc("SendTicket").Pc("Shipment").Pc("MesageSMS").Pc("Note").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Chair
		public static void Chair(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDCar").Pc("RowNo").Pc("ColumnNo").Pc("Name").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Customer
		public static void Customer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("Code").Pc("FullName").Pc("IDSystem").Pc("IDOffice").Pc("IDCardKind").Pc("IsPartner").Pc("CMND").Pc("Sex").Pc("Idea").Pc("DateContract").Pc("Address").Pc("IDStreet").Pc("IDTinh").Pc("Phone").Pc("Fax").Pc("Mobile").Pc("Email").Pc("CodeTax").Pc("BirthDay").Pc("NullBirthDay").Pc("Note").Pc("Status").Pc("CreatedID").Pc("CreatedDate").Pc("ChangedID").Pc("ChangedDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Category
		public static void Category(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("Code").Pc("Name").Pc("Note").Pc("CodeGroup").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CarBookingLog
		public static void CarBookingLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("CreatedID").Pc("CreatedDate").Pc("IDRoute").Pc("DateStart").Pc("TimeStart").Pc("LogDetail")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CarBooking
		public static void CarBooking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDCar").Pc("IDDriver").Pc("IDDriver2").Pc("IDGuide").Pc("IDRoute").Pc("DateStart").Pc("IDTimeStart").Pc("TimeCode").Pc("Note").Pc("Finish").Pc("IsStart").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status").Pc("LastUpdate").Pc("StartBusStation").Pc("BusEmpty").Pc("BusDelete")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Car
		public static void Car(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("Code").Pc("IDRoute").Pc("IDSystemUse").Pc("IDSystem").Pc("IDKind").Pc("IDFuel").Pc("Name").Pc("Number").Pc("NumberChair").Pc("Note").Pc("IsTemp").Pc("SoMay").Pc("SoKhung").Pc("NamSanXuat").Pc("NgayNhanXe").Pc("MauSon").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status").Pc("ChairMap")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for PickupRoute
		public static void PickupRoute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDPickup").Pc("IDRoute")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for PikupInfo
		public static void PikupInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("Street").Pc("IDOffice").Pc("Pickup").Pc("PickupStreet").Pc("Preparatory").Pc("Note").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for RoutePrice
		public static void RoutePrice(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("IDPrice").Pc("Online").Pc("FullRoute")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for RoutePoint
		public static void RoutePoint(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("IDStageStart").Pc("IDStageEnd")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for User
		public static void User(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDSystem").Pc("IDOffice").Pc("IDPosition").Pc("Code").Pc("UserName").Pc("FirstName").Pc("LastName").Pc("Gender").Pc("Address").Pc("Phone").Pc("Email").Pc("Password").Pc("AllSystem").Pc("IsSupper").Pc("Active").Pc("AccessWeb").Pc("Pay").Pc("Birthday").Pc("Extension").Pc("Note").Pc("Approve").Pc("Admin").Pc("ChooseOffice").Pc("Teleworker").Pc("DateLastLogin").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_TaiKhoan
		public static void tbl_TaiKhoan(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Username").Pc("Password").Pc("MaNhomQuyen").Pc("CanBoId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CarBookingDetail
		public static void CarBookingDetail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDCarBooking").Pc("IDRoute").Pc("IDPartner").Pc("IDOffice").Pc("IDOfficeSendTicket").Pc("IDOfficePickup").Pc("Chair").Pc("RowNo").Pc("ColumnNo").Pc("CustomerName").Pc("Phone").Pc("Street").Pc("CustomerInfo").Pc("Code").Pc("Price").Pc("MoneyOther").Pc("Free").Pc("Note").Pc("Lock").Pc("IDUserLock").Pc("DateLock").Pc("PickUpStreet").Pc("IsTicketAgent").Pc("SendTicket").Pc("IsCollect").Pc("IDSendTicket").Pc("DateSendTicket").Pc("CreatedID").Pc("ChangedID").Pc("CreatedDate").Pc("ChangedDate").Pc("Vip").Pc("IDMember").Pc("CodeMember").Pc("Birth").Pc("IDApprove").Pc("DateApprove").Pc("Fee").Pc("Status").Pc("IDUserDelete").Pc("IDOfficeDelete").Pc("DateDelete").Pc("WaitApprove").Pc("Commision").Pc("Discount").Pc("CodeDiscount").Pc("IDRelation").Pc("BillType").Pc("Arising").Pc("DatePickup").Pc("DateSetPickup")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Quyen_NhomQuyen
		public static void tbl_Quyen_NhomQuyen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MaNhomQuyen").Pc("MaQuyen").Pc("CoQuyen")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Quyen_Menu
		public static void tbl_Quyen_Menu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("QuyenId").Pc("MenuId").Pc("ChoPhep")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Quyen_ChiTiet
		public static void tbl_Quyen_ChiTiet(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("QuyenId").Pc("BangId").Pc("Xem").Pc("Them").Pc("Xoa").Pc("Sua")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_PT_User
		public static void tbl_PT_User(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserName").Pc("Password").Pc("Email").Pc("HoTen").Pc("Phone").Pc("NgaySinh").Pc("GioiTinh").Pc("Avatar").Pc("PwdQuestionCode").Pc("EncryptedAnswer").Pc("CreateUserID").Pc("CreateDate").Pc("UserType").Pc("PromoCode").Pc("CheckNo").Pc("Status").Pc("Space01").Pc("Space02").Pc("Space03").Pc("SpaceId").Pc("isPrgAccountId").Pc("isPrgInUse").Pc("isPrgCreateDate").Pc("isPrgWaitingConfirmStatus").Pc("isPrgbAdminDeleted").Pc("isPrgbUserDeleted").Pc("isPrgbShow").Pc("isPrgOrdered").Pc("isPrgVNKoDau").Pc("isPrgSmField").Pc("isPrgPartComp").Pc("isPrgEncriptData").Pc("isPrgDescriptData").Pc("isPrgAccountUpdateId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Menu
		public static void tbl_Menu(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Ten").Pc("TenTA").Pc("Url").Pc("MenuCha").Pc("Hinh").Pc("IsEP")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Cat_RouteGroup
		public static void tbl_Cat_RouteGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Distance").Pc("QuantityOfCar").Pc("Price").Pc("BreakEvenPoint")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Cat_Cost
		public static void tbl_Cat_Cost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Cat_Event
		public static void tbl_Cat_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Name").Pc("Note").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Cat_Route
		public static void tbl_Cat_Route(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("RouteGroupId").Pc("StartPointId").Pc("EndPointId").Pc("RouteId").Pc("Name2")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_Cost
		public static void tbl_Route_Cost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteGroupId").Pc("RouteId").Pc("CostId").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_Event
		public static void tbl_Route_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteGroupId").Pc("RouteId").Pc("EventId").Pc("FromDate").Pc("ToDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_TimeTable
		public static void tbl_Route_TimeTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("IDRoute").Pc("StartDate").Pc("Time").Pc("Number").Pc("FullName").Pc("FirstName").Pc("Phone").Pc("FullName2").Pc("FirstName2").Pc("Phone2").Pc("SeatBook")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TotalStatusTicketByDate
		public static void tbl_Report_TotalStatusTicketByDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Date").Pc("TotalSchedule").Pc("TotalScheduleCancel").Pc("TotalBook").Pc("TotalEmpty").Pc("TotalLock").Pc("TotalPay").Pc("TotalPayOnline").Pc("TotalSeat").Pc("TotalMoneyPay")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TotalStatusTicketByDateByIDRoute
		public static void tbl_Report_TotalStatusTicketByDateByIDRoute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("Date").Pc("TotalSchedule").Pc("TotalScheduleCancel").Pc("TotalBook").Pc("TotalEmpty").Pc("TotalLock").Pc("TotalPay").Pc("TotalPayOnline").Pc("TotalSeat").Pc("TotalMoneyPay").Pc("IDBranch").Pc("TotalTicketBranch").Pc("TotalMoneyBranch")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_thongtin_thisinh
		public static void tbl_thongtin_thisinh(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ten").Pc("sobaodanh").Pc("truong").Pc("tinh").Pc("huyen").Pc("sessionid").Pc("ghichu")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_Company
		public static void tbl_Route_Company(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteGroupId").Pc("RouteId").Pc("Name").Pc("Address").Pc("Phone").Pc("NumOfCar").Pc("Price")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Cat_Office
		public static void tbl_Cat_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Name").Pc("Address").Pc("Phone").Pc("Manager").Pc("ManagerMobile")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Route_Office
		public static void tbl_Route_Office(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RouteGroupId").Pc("RouteId").Pc("OfficeId").Pc("Note").Pc("Distance").Pc("Time")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_CPC_XE_OnlineSession_Detail
		public static void tbl_CPC_XE_OnlineSession_Detail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OnlineSessionId").Pc("TicketId").Pc("TicketName").Pc("carBookingId").Pc("price").Pc("pass").Pc("Other").Pc("IsSubmited").Pc("IsCanPay").Pc("ReplaceId").Pc("ReplaceName").Pc("idStrib").Pc("CustName").Pc("CustMobile").Pc("CustCMND").Pc("Discount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_OwnRouteBranch
		public static void tbl_Report_OwnRouteBranch(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("IDBranch").Pc("BranchName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_TotalStatusTicketByDateByIDRouteAndIDBranch
		public static void tbl_Report_TotalStatusTicketByDateByIDRouteAndIDBranch(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("IDRoute").Pc("Date").Pc("TotalSchedule").Pc("TotalScheduleCancel").Pc("TotalBook").Pc("TotalEmpty").Pc("TotalLock").Pc("TotalPay").Pc("TotalPayOnline").Pc("TotalSeat").Pc("TotalMoneyPay").Pc("IDBranch").Pc("TotalTicketBranch").Pc("TotalMoneyBranch")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for tbl_Report_ScheduleJob
		public static void tbl_Report_ScheduleJob(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FromDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}