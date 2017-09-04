using cModel;
using cDict;
 namespace cKernel.Extend
{
    public class P
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId; 
		public P(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for Country
		public static void Country(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CountryID").Pc("Name").Pc("AllowsRegistration").Pc("AllowsBilling").Pc("AllowsShipping").Pc("TwoLetterISOCode").Pc("ThreeLetterISOCode").Pc("NumericISOCode").Pc("Published").Pc("DisplayOrder").Pc("LanguageCode").Pc("IsAppDefault").Pc("IsAppFullSupport").Pc("ApiLink").Pc("MediaLink").Pc("PaymentLink").Pc("AppHomeBackground")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PromotionType
		public static void Res_PromotionType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PromotionTypeID").Pc("Name").Pc("Code")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_FavouriteRestaurant
		public static void Res_FavouriteRestaurant(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserID").Pc("RestaurantID").Pc("CreatedOn").Pc("DisplayOrder").Pc("FacebookActionId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_SubDomain
		public static void Res_SubDomain(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("SubDomainID").Pc("RestaurantID").Pc("SubDomain").Pc("GoogleMapApiKey").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_BookType
		public static void Res_BookType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("TypeID").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_BookCommision
		public static void Res_BookCommision(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CommisionID").Pc("BookID").Pc("Commision").Pc("StartTime").Pc("EndTime")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Promotion_Bak
		public static void Res_Promotion_Bak(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PromotionID").Pc("RestaurantID").Pc("PromotionType").Pc("Title").Pc("Short").Pc("Description").Pc("MetaKeywords").Pc("ImageURL").Pc("StartDate").Pc("EndDate").Pc("ShowDate").Pc("Price").Pc("TotalView").Pc("IsShowHome").Pc("IsActive").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_ReviewComment
		public static void Res_ReviewComment(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CommentID").Pc("CommentID").Pc("ReviewID").Pc("ReviewID").Pc("UserID").Pc("Comment").Pc("CreatedOn").Pc("Trash").Pc("Trash").Pc("UpdatedOn").Pc("UpdatedByID").Pc("IsOwnerResponse").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Booking
		public static void Res_Booking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("BookID").Pc("TypeID").Pc("RestaurantID").Pc("Name").Pc("ImageURL").Pc("DiscountValue").Pc("StartDate").Pc("ExpiryDate").Pc("ShowDate").Pc("MaxAdult").Pc("MaxChildren").Pc("MaxTable").Pc("OpenTime").Pc("Holiday").Pc("Short").Pc("Description").Pc("Category").Pc("TotalView").Pc("IsActive").Pc("IsSpecial").Pc("RangeTime").Pc("DiscountRangeTime").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_BookRange
		public static void Res_BookRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RankID").Pc("BookID").Pc("RangePerHead1").Pc("RangePerHead2").Pc("Discount").Pc("Commision").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantMeeting
		public static void Res_RestaurantMeeting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("MeetingID").Pc("RestaurantID").Pc("ContactID").Pc("MeetingDate").Pc("Note").Pc("UserID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_BookOrder
		public static void Res_BookOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("OrderID").Pc("BookID").Pc("UserID").Pc("UpdateUserID").Pc("FullName").Pc("OrderDate").Pc("OrderTime").Pc("CreateOn").Pc("NAdult").Pc("NChildren").Pc("NTable").Pc("Phone").Pc("Email").Pc("Note").Pc("Status").Pc("Payment")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_DishType_Mapping
		public static void Res_Restaurant_DishType_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantID").Pc("TypeID").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_KeywordHistory
		public static void Res_KeywordHistory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordID").Pc("Keyword").Pc("IsActive").Pc("CreateOn").Pc("UserID").Pc("Total").Pc("Priority").Pc("ProvinceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_Property_Mapping
		public static void Res_Restaurant_Property_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantID").Pc("PropertyID").Pc("Note")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_Dining_Mapping
		public static void Res_Restaurant_Dining_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantID").Pc("DiningID").Pc("Flag")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PriceRange
		public static void Res_PriceRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PriceRangeID").Pc("PriceFrom").Pc("PriceTo").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_Purpose_Mapping
		public static void Res_Restaurant_Purpose_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantID").Pc("RestaurantID").Pc("PurposeID").Pc("PurposeID").Pc("Flag")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PriceOption
		public static void Res_PriceOption(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PriceOptionID").Pc("RestaurantID").Pc("PriceMin").Pc("PriceMax").Pc("Title")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_TimeRange
		public static void Res_TimeRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RangeID").Pc("RestaurantID").Pc("StartTime").Pc("EndTime").Pc("Title")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_District_Area_Mapping
		public static void Res_District_Area_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DistrictID").Pc("AreaID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Category_Purpose_Mapping
		public static void Res_Category_Purpose_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryID").Pc("PurposeID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Category_Property_Mapping
		public static void Res_Category_Property_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryID").Pc("PropertyID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Category_DishCategory_Mapping
		public static void Res_Category_DishCategory_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryID").Pc("DishCategoryID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_DishCategory_Mapping
		public static void Res_Restaurant_DishCategory_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantID").Pc("RestaurantID").Pc("DishCategoryID").Pc("DishCategoryID").Pc("Flag")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Category_Area_Mapping
		public static void Res_Category_Area_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryID").Pc("AreaID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Dining
		public static void Res_Dining(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DiningID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("UrlRewriteName").Pc("NameEn").Pc("IsPopular").Pc("HitCount").Pc("Icon")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_BrandAddress
		public static void Res_BrandAddress(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AddressID").Pc("Address").Pc("Phone").Pc("Fax").Pc("BrandID").Pc("DistrictID").Pc("CityID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Language
		public static void Language(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("LanguageCulture").Pc("UniqueSeoCode").Pc("FlagImageFileName").Pc("Rtl").Pc("Published").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _PermissionRecord
		public static void _PermissionRecord(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("SystemName").Pc("Category")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _NewsLetterSubscription
		public static void _NewsLetterSubscription(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("NewsLetterSubscriptionGuid").Pc("Email").Pc("Active").Pc("CreatedOnUtc")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MailChimpEventQueueRecord
		public static void _MailChimpEventQueueRecord(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Email").Pc("IsSubscribe").Pc("CreatedOnUtc")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Picture
		public static void _Picture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Id").Pc("PictureBinary").Pc("MimeType").Pc("SeoFilename").Pc("IsNew").Pc("Type").Pc("Picture")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Setting
		public static void Setting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _ActivityLogType
		public static void _ActivityLogType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("SystemKeyword").Pc("Name").Pc("Enabled")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for PermissionRecord_Role_Mapping
		public static void PermissionRecord_Role_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PermissionRecord_Id").Pc("CustomerRole_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for LocalizedProperty
		public static void LocalizedProperty(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("EntityId").Pc("LanguageId").Pc("LocaleKeyGroup").Pc("LocaleKey").Pc("LocaleValue")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for LocaleStringResource
		public static void LocaleStringResource(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("LanguageId").Pc("ResourceName").Pc("ResourceValue")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Log
		public static void Log(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("LogLevelId").Pc("ShortMessage").Pc("FullMessage").Pc("IpAddress").Pc("CustomerId").Pc("PageUrl").Pc("ReferrerUrl").Pc("CreatedOnUtc").Pc("Type").Pc("ServerIP").Pc("ServerName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _ExternalAuthenticationRecord
		public static void _ExternalAuthenticationRecord(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("Email").Pc("ExternalIdentifier").Pc("ExternalDisplayIdentifier").Pc("OAuthToken").Pc("OAuthAccessToken").Pc("ProviderSystemName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CustomerContent
		public static void _CustomerContent(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("IpAddress").Pc("IsApproved").Pc("CreatedOnUtc").Pc("UpdatedOnUtc")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PredefineAlbum
		public static void Res_PredefineAlbum(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PredefineAlbumID").Pc("Name").Pc("DisplayOrder").Pc("DefaultImageUrl").Pc("UrlRewriteName").Pc("IsActive").Pc("NameEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Keyword
		public static void Res_Keyword(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordID").Pc("Keyword").Pc("IsActive").Pc("CreateOn").Pc("Total").Pc("Priority")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_ReviewFavourite
		public static void Res_ReviewFavourite(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserID").Pc("ReviewID").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Tier
		public static void Res_Tier(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("TierID").Pc("Name").Pc("Description").Pc("ReviewPoint").Pc("CommentPoint").Pc("LikePoint").Pc("AlbumPoint").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_SuggestTitle
		public static void Res_SuggestTitle(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("SuggestTitleID").Pc("Name").Pc("Type").Pc("DisplayOrder").Pc("ASCIIName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_KeywordMapping
		public static void Res_KeywordMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ObjectId").Pc("Name").Pc("AsciiName").Pc("Type").Pc("DisplayOrder").Pc("Point")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PromotionCategory
		public static void Res_PromotionCategory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryID").Pc("GroupID").Pc("Name").Pc("NameEN").Pc("Link").Pc("DisplayOrder").Pc("IsActive").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PromotionGroup
		public static void Res_PromotionGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("GroupID").Pc("Name").Pc("NameEN").Pc("NameUrl").Pc("IsActive").Pc("DisplayOrder").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Topic
		public static void Topic(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("SystemName").Pc("IncludeInSitemap").Pc("IsPasswordProtected").Pc("Password").Pc("Title").Pc("Body").Pc("MetaKeywords").Pc("MetaDescription").Pc("MetaTitle").Pc("TitleEn").Pc("BodyEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantAlbum
		public static void Res_RestaurantAlbum(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AlbumID").Pc("AlbumID").Pc("UserID").Pc("RestaurantID").Pc("Name").Pc("Description").Pc("CreatedOn").Pc("IsActive").Pc("IsFeatured").Pc("IsDraft").Pc("UpdatedOn").Pc("ReviewId").Pc("CheckinId").Pc("IsProfessional").Pc("DeviceType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Purpose_Mapping
		public static void _KeywordTemplate_Purpose_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("PurposeId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Property_Mapping
		public static void _KeywordTemplate_Property_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("PropertyId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Price_Mapping
		public static void _KeywordTemplate_Price_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("KeywordId").Pc("PriceMin").Pc("PriceMax").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_District_Mapping
		public static void _KeywordTemplate_District_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("DistrictId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_DishCategory_Mapping
		public static void _KeywordTemplate_DishCategory_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("DishCategoryId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Dining_Mapping
		public static void _KeywordTemplate_Dining_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("DiningId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Cuisine_Mapping
		public static void _KeywordTemplate_Cuisine_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("CuisineId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Category_Mapping
		public static void _KeywordTemplate_Category_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("CategoryId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Area_Mapping
		public static void _KeywordTemplate_Area_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("AreaId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordPart
		public static void _KeywordPart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("KeywordId").Pc("Name").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for StreetMapAlias
		public static void StreetMapAlias(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AliasID").Pc("StreetMapID").Pc("Alias").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for StreetMap
		public static void StreetMap(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("StreetMapID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Street_Mapping
		public static void _KeywordTemplate_Street_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("StreetId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Restaurant_Mapping
		public static void _KeywordTemplate_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("RestaurantId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate_Province_Mapping
		public static void _KeywordTemplate_Province_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("ProvinceId").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for District_Street_Mapping
		public static void District_Street_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DistrictID").Pc("StreetID").Pc("OriginalAddress")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _PreDefineKeyword
		public static void _PreDefineKeyword(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("ASCIIName").Pc("Type").Pc("Boost").Pc("OccurType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantCheckedIn
		public static void Res_RestaurantCheckedIn(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("ID").Pc("UserID").Pc("UserID").Pc("RestaurantID").Pc("RestaurantID").Pc("CreatedOn").Pc("DeviceType").Pc("DisplayOrder").Pc("Comment").Pc("IsActive").Pc("IsAllowComment")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_ReportError
		public static void Res_ReportError(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReportID").Pc("RestaurantID").Pc("UserID").Pc("IPAddress").Pc("Url").Pc("CreatedOn").Pc("ReportType").Pc("Title").Pc("Description").Pc("IsResolved").Pc("IsTrue").Pc("Email")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Promotion
		public static void Res_Promotion(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PromotionID").Pc("GroupID").Pc("CategoryID").Pc("RestaurantID").Pc("Title").Pc("Short").Pc("Description").Pc("MetaKeywords").Pc("ImageURL").Pc("Link").Pc("StartDate").Pc("EndDate").Pc("ShowDate").Pc("Price").Pc("TotalView").Pc("IsShowHome").Pc("IsFeatured").Pc("IsActive").Pc("DisplayOrder").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedById").Pc("UpdatedById").Pc("ClassSuffix").Pc("ImageDesc").Pc("IsPromotion").Pc("IsMobileSpecial").Pc("MobileContent")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for LoginSession
		public static void LoginSession(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("Token").Pc("CreatedOnUtc").Pc("ExpireDate").Pc("DeviceId").Pc("IsActive").Pc("UpdatedOnUtc").Pc("Type").Pc("SocialType").Pc("SocialToken").Pc("DeviceType").Pc("DeviceName").Pc("AppType").Pc("AppVersion").Pc("DeviceUniqueId").Pc("Latitude").Pc("Longitude").Pc("UserAgent").Pc("IpAddress").Pc("CityId").Pc("NotiStatus").Pc("ParentId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_ReviewReportError
		public static void Res_ReviewReportError(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReportID").Pc("ReviewID").Pc("UserID").Pc("IPAddress").Pc("Url").Pc("CreatedOn").Pc("Title").Pc("Description").Pc("IsResolved").Pc("IsTrue").Pc("IsOwnerReport").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantProperty
		public static void Res_RestaurantProperty(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PropertyID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("UrlRewriteName").Pc("NameEn").Pc("HitCount").Pc("Icon")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantPurpose
		public static void Res_RestaurantPurpose(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PurposeID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("IsActive").Pc("IsFeatured").Pc("UrlRewriteName").Pc("NameEn").Pc("IsPopular").Pc("HitCount").Pc("Icon")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordAd
		public static void _KeywordAd(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("AsciiName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordAd_Restaurant_Mapping
		public static void _KeywordAd_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordAdId").Pc("RestaurantId").Pc("DisplayOrder").Pc("StartDate").Pc("EndDate").Pc("IsExact").Pc("IsActive").Pc("ShowInSearchResult")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_PointConfig
		public static void Rwd_PointConfig(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Tier").Pc("Description").Pc("ReviewMaxPoints").Pc("PhotoMaxPoints").Pc("PhotoRatioBaseReview").Pc("CommentMaxPoints").Pc("CommentRatioBaseReview").Pc("LikeMaxPoints").Pc("LikeRatioBaseReview").Pc("VideoMaxPoints")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_PointLevel
		public static void Rwd_PointLevel(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("LevelName").Pc("MinPoint").Pc("MaxPoint").Pc("LevelNameEn").Pc("ImageUrl")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_PointTypes
		public static void Rwd_PointTypes(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("TypeId").Pc("Description").Pc("DisplayName").Pc("DisplayNameEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserBalance
		public static void Rwd_UserBalance(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserId").Pc("Balance").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserBalanceChangeLogs
		public static void Rwd_UserBalanceChangeLogs(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("LogId").Pc("UserId").Pc("OldValue").Pc("NewValue").Pc("Reason").Pc("ReferenceId").Pc("CreatedOn").Pc("ModifiedUserId").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserPoints
		public static void Rwd_UserPoints(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserId").Pc("TotalPoints").Pc("TotalPendingPoints").Pc("RedeemedPoints").Pc("RemainingPoints").Pc("IsActive").Pc("PointLevelId").Pc("UnitPrice").Pc("AvailableBalance").Pc("Rank")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserRedeemChangeLogs
		public static void Rwd_UserRedeemChangeLogs(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("LogId").Pc("UserId").Pc("RedeemPoints").Pc("CreatedOn").Pc("ModifiedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CouponPrice
		public static void _CouponPrice(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CouponPriceId").Pc("Price")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_PointPolicy
		public static void Rwd_PointPolicy(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("ReductionPoint").Pc("IsPercent")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserPointTransactions
		public static void Rwd_UserPointTransactions(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("RestaurantId").Pc("EarnedId").Pc("Tier").Pc("Type").Pc("PointsEarned").Pc("ParentId").Pc("IsActive").Pc("PointRatio").Pc("CreatedOn").Pc("IsApproved").Pc("Description").Pc("UpdatedOn").Pc("ReferenceId").Pc("RedeemStatus").Pc("CampaignId").Pc("ApproveBy").Pc("DenyBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _API_UploadTransactions
		public static void _API_UploadTransactions(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReviewId").Pc("BeginDate").Pc("EndDate").Pc("FileSize").Pc("FileName").Pc("Title").Pc("SessionKey").Pc("Success").Pc("Message").Pc("ReferredId").Pc("Tick").Pc("CheckinId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserPointTransactionChangeLogs
		public static void Rwd_UserPointTransactionChangeLogs(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("LogId").Pc("TransactionId").Pc("OldPoints").Pc("NewPoints").Pc("Reason").Pc("ModifiedUserId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CouponItem
		public static void _CouponItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CouponItemID").Pc("CouponID").Pc("RestaurantID").Pc("PublicCode").Pc("PrivateCode").Pc("Price").Pc("Point").Pc("IsActive").Pc("IsUsed").Pc("IsRedeemed").Pc("CreatedOn").Pc("EndDate").Pc("RedeemedDate").Pc("UsedDate").Pc("UserId").Pc("UpdatedBy").Pc("ReferredBy").Pc("Token").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CouponShippingMethod
		public static void _CouponShippingMethod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("IsActive").Pc("Note").Pc("NameEn").Pc("NoteEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CouponType
		public static void _CouponType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CouponShippingInfo
		public static void _CouponShippingInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Name").Pc("Phone").Pc("Address").Pc("CityId").Pc("DistrictId").Pc("Email").Pc("Note").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_BalanceType
		public static void Rwd_BalanceType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DisplayName").Pc("Description").Pc("IsNegative").Pc("DisplayNameEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Coupon_TypeShippingMethod_Mapping
		public static void _Coupon_TypeShippingMethod_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CouponTypeId").Pc("CouponShippingMethodId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CouponOrderStatus
		public static void _CouponOrderStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Coupon_OrderItem_Mapping
		public static void _Coupon_OrderItem_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CouponOrderId").Pc("CouponItemId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_ActivityType
		public static void Social_ActivityType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("ActionId").Pc("ObjectId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_ReviewOfDay
		public static void Rwd_ReviewOfDay(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReviewId").Pc("Name").Pc("Type").Pc("CreatedOn").Pc("CreatedBy").Pc("StartDate").Pc("EndDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_FriendShipStatus
		public static void Social_FriendShipStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_IgnoredNotification
		public static void Social_IgnoredNotification(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("IgnoredUserId").Pc("Type").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for __Social_UserFriend
		public static void __Social_UserFriend(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("FriendId").Pc("CreatedOn").Pc("UpdatedOn").Pc("StatusId").Pc("UpdatedBy").Pc("IsActive").Pc("ViaSocialType").Pc("IsIgnored")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_NotificationType
		public static void Social_NotificationType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("ActionId").Pc("ObjectId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Like
		public static void Like(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReferenceId").Pc("Type").Pc("UserId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Article_Purpose_Mapping
		public static void _Article_Purpose_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ArticleId").Pc("PurposeId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Article
		public static void _Article(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Short").Pc("Description").Pc("MetaTitle").Pc("MetaDescription").Pc("MetaKeywords").Pc("ImageURL").Pc("StartDate").Pc("EndDate").Pc("TotalViews").Pc("IsFeatured").Pc("IsActive").Pc("DisplayOrder").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedById").Pc("UpdatedById").Pc("MobileContent").Pc("CategoryGroupId").Pc("UrlRewrite")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_UserActivity
		public static void Social_UserActivity(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("CreatedOn").Pc("IsActive").Pc("IsPublic").Pc("Type").Pc("ReferenceId").Pc("IsNotify").Pc("AffectedUsers").Pc("GroupId").Pc("ActionId").Pc("ObjectId").Pc("FounderId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CustomerAttributeSetting
		public static void CustomerAttributeSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("AttributeKey").Pc("PublishedType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CustomerAttributePublishedType
		public static void _CustomerAttributePublishedType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PublishedType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Comment
		public static void Comment(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Comment").Pc("ReferenceId").Pc("Type").Pc("CreatedOn").Pc("UpdatedOn").Pc("UpdatedById").Pc("Trash")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Article_Location_Mapping
		public static void _Article_Location_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ArticleId").Pc("LocationId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_WantedList
		public static void Res_WantedList(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserID").Pc("RestaurantID").Pc("CreatedOn").Pc("DeviceType").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Ads
		public static void Ads(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ProviderId").Pc("RestaurantId").Pc("Title").Pc("Description").Pc("Link").Pc("Hits").Pc("IsActive").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedById").Pc("UpdatedById").Pc("IsFeatured").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Customer_Eating_Preference_Mapping
		public static void Customer_Eating_Preference_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("ReferenceId").Pc("Type").Pc("CreatedOn").Pc("IsSystemSuggest").Pc("SelectedOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Eating_Preference_Type
		public static void _Eating_Preference_Type(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_WishListItem
		public static void Res_WishListItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ListId").Pc("RestaurantId").Pc("UserId").Pc("CreatedOn").Pc("DisplayOrder").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_WishlistItemNote
		public static void Res_WishlistItemNote(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("UserId").Pc("ListId").Pc("ListName").Pc("Description").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_EatingHabit
		public static void Res_EatingHabit(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("IsPopular")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Subscribe
		public static void Subscribe(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReferenceId").Pc("Type").Pc("UserId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_WishList
		public static void Res_WishList(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Name").Pc("Description").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn").Pc("UpdatedByUserId").Pc("DisplayOrder").Pc("IsPublic").Pc("IsCore").Pc("IsFeatured").Pc("IsEditorPick").Pc("IsShowHome").Pc("Img").Pc("LastActivity").Pc("TotalViews").Pc("TotalComments").Pc("TotalLikes").Pc("TotalSubscribers").Pc("Type").Pc("OldUrlRewriteName").Pc("TotalItems")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_Notification_Action
		public static void Social_Notification_Action(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Action").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_Notification_Object
		public static void Social_Notification_Object(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Object").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Tip
		public static void Tip(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("TitleEn").Pc("Description").Pc("DescriptionEn").Pc("Link").Pc("Img").Pc("Scope").Pc("IsActive").Pc("CreatedOn").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantViewer
		public static void Res_RestaurantViewer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Id").Pc("RestaurantId").Pc("RestaurantId").Pc("UserId").Pc("UserId").Pc("UserName").Pc("IPAddress").Pc("DeviceType").Pc("CreatedOn").Pc("LastActivity").Pc("LastActivity").Pc("IsActive").Pc("SessionId").Pc("SessionId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_FeaturePicture
		public static void Res_FeaturePicture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PictureId").Pc("AlbumId").Pc("PredefineAlbumId").Pc("ReviewId").Pc("UserId").Pc("RestaurantId").Pc("CityId").Pc("Name").Pc("Description").Pc("PhotoUrl").Pc("PostedByDevice").Pc("OriginalWidth").Pc("OriginalHeight").Pc("IsActive").Pc("IsFeatured").Pc("DisplayOrder").Pc("CreatedOn").Pc("UpdatedOn").Pc("Type").Pc("StartDate").Pc("EndDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_LastActivity
		public static void Res_LastActivity(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("LastActivity")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Plan_Feature_Mapping
		public static void _Biz_Plan_Feature_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PlanId").Pc("PlanFeatureId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_PlanPrice
		public static void _Biz_PlanPrice(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PlanId").Pc("Price").Pc("Unit").Pc("Amount").Pc("Currency")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Plan
		public static void _Biz_Plan(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("DisplayOrder").Pc("PricePerMonth").Pc("PricePerYear").Pc("IsActive").Pc("IsCore").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Owner
		public static void Res_Owner(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("UserId").Pc("Role").Pc("ReferenceUserId").Pc("Status").Pc("CreatedDate").Pc("UpdatedDate").Pc("PlanId").Pc("StartDate").Pc("EndDate").Pc("OrderId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_App_Request
		public static void Social_App_Request(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("RequestId").Pc("SocialSenderId").Pc("SocialRecipientId").Pc("SocialType").Pc("CreatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Customer_Social_Link
		public static void Customer_Social_Link(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Token").Pc("ProviderType").Pc("IsActive").Pc("ExpiredDate").Pc("IsSync")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_MicrositeTemplate
		public static void Res_MicrositeTemplate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsActive").Pc("Path").Pc("CssSuffix").Pc("ImageURL").Pc("Price")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealItem
		public static void _DealItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DealId").Pc("PublicCode").Pc("PrivateCode").Pc("IsActive").Pc("CreatedOn").Pc("EndDate").Pc("UsedDate").Pc("UserId").Pc("UpdatedBy").Pc("IsReused").Pc("TotalItems").Pc("Status").Pc("PaymentExpiredDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealType
		public static void _DealType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsActive").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealSubItem
		public static void _DealSubItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DealItemId").Pc("Description").Pc("UserId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DayOfWeek
		public static void DayOfWeek(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Deal_DayOfWeek
		public static void _Deal_DayOfWeek(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DealId").Pc("DayId").Pc("StartTime").Pc("EndTime")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealShippingMethod
		public static void _DealShippingMethod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("IsActive").Pc("Note").Pc("NameEn").Pc("NoteEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealType_ShippingMethod
		public static void _DealType_ShippingMethod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DealTypeId").Pc("DealShippingMethodId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealOrder_Item
		public static void _DealOrder_Item(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DealItemId").Pc("DealOrderId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Deal_Restaurant
		public static void _Deal_Restaurant(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DealId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _OrderStatus
		public static void _OrderStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_PlanOrderContact
		public static void _Biz_PlanOrderContact(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerName").Pc("Email").Pc("Phone").Pc("Address").Pc("OrderId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _AdvanceSearch
		public static void _AdvanceSearch(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Purpose").Pc("Areas").Pc("Time").Pc("People").Pc("Price").Pc("More").Pc("Phone").Pc("Email").Pc("IsSubscribe").Pc("IsPublic").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_MonthlyReport
		public static void _Biz_MonthlyReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MonthlyReportMonth").Pc("MonthlyReportYear").Pc("ReportTypeId").Pc("MonthlyReportTarget").Pc("MonthlyReportActual")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantViewer_Archive
		public static void Res_RestaurantViewer_Archive(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("UserId").Pc("UserName").Pc("IPAddress").Pc("DeviceType").Pc("CreatedOn").Pc("LastActivity").Pc("IsActive").Pc("SessionId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PhotoReport
		public static void Res_PhotoReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantPictureId").Pc("UserId").Pc("IPAddress").Pc("Url").Pc("CreatedOn").Pc("Title").Pc("Description").Pc("IsResolved").Pc("IsOwnerReport").Pc("ResolvedDated")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Contacts_From_Social
		public static void _Contacts_From_Social(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("SocialId").Pc("Email").Pc("Name").Pc("Type").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_WeeklyReport
		public static void _Biz_WeeklyReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("WeekStart").Pc("WeekEnd").Pc("ReportTypeId").Pc("WeeklyReportTarget").Pc("WeeklyReportActual")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_CampaignReport
		public static void _Biz_CampaignReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MonthlyReportMonth").Pc("MonthlyReportYear").Pc("ReportTypeId").Pc("MonthlyReportTarget").Pc("MonthlyReportActual").Pc("CampaignReportBudget")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Company
		public static void _Company(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("ContactName").Pc("Description").Pc("Address").Pc("Phone").Pc("Fax").Pc("TaxCode").Pc("Website").Pc("BankName").Pc("BankHolderName").Pc("BankAccountId").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_ReportType
		public static void _Biz_ReportType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReportTypeKey").Pc("ReportTypeName").Pc("ReportTypeDesc").Pc("DisplayOrder").Pc("IsActive").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MarketingEmail
		public static void _MarketingEmail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Email").Pc("Name").Pc("UserId").Pc("Type").Pc("IsActive").Pc("IsSubscribe").Pc("CreatedOn").Pc("UpdatedOn").Pc("UseForTest").Pc("StateProvinceId").Pc("IsSystem")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MarketingEmailQuery
		public static void _MarketingEmailQuery(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Query").Pc("CreatedOn").Pc("CreatedBy").Pc("EmailTemplateId").Pc("Type").Pc("CityId").Pc("Total").Pc("Status").Pc("LastId").Pc("UpdatedOn").Pc("MaxId").Pc("InviteNewUser").Pc("Top").Pc("StartDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Feedback
		public static void _Biz_Feedback(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Email").Pc("Title").Pc("MessageContent").Pc("Note").Pc("ModComment").Pc("IsResolved").Pc("CreatedOn").Pc("UpdatedOn").Pc("ResolvedOn").Pc("CreatedById").Pc("UpdatedById")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_CampaignType
		public static void _Biz_CampaignType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CampaignTypeName").Pc("CampaignTypeDesc").Pc("DisplayOrder").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Reward
		public static void _Biz_Reward(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("Quantity").Pc("Price").Pc("TotalAmount").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Campaign
		public static void _Biz_Campaign(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReportTypeKey").Pc("ReportTypeName").Pc("ReportTypeDesc").Pc("CampaignParentId").Pc("CampaignTypeId").Pc("DisplayOrder").Pc("IsActive").Pc("CreatedOn").Pc("utm_source").Pc("utm_medium").Pc("utm_term").Pc("utm_content")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Ads
		public static void _Biz_Ads(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PlatformId").Pc("PlatformName").Pc("PLatformLink").Pc("PlatformLinkDesc").Pc("ServiceName").Pc("ServiceNameEN").Pc("Navigation").Pc("NavigationEN").Pc("Description").Pc("DescriptionEN").Pc("Demo").Pc("Limit").Pc("Amount").Pc("Unit").Pc("Price").Pc("IsPublish").Pc("DisplayOrder").Pc("IconUrl").Pc("Price_HN").Pc("Price_DNG")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_Promotion_Mapping
		public static void Res_Restaurant_Promotion_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PromotionId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for EmailAccount
		public static void EmailAccount(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Email").Pc("DisplayName").Pc("Host").Pc("Port").Pc("Username").Pc("Password").Pc("EnableSsl").Pc("UseDefaultCredentials")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MarketingEmailQueryStatus
		public static void _MarketingEmailQueryStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Template_Mapping
		public static void Res_Template_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantId").Pc("TemplateId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_CustomerSentMails
		public static void Res_CustomerSentMails(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("To").Pc("Subject").Pc("Content").Pc("Date").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Biz_ProjectFeature
		public static void Biz_ProjectFeature(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ProjectFeatureName").Pc("ProjectFeatureTitle").Pc("ProjectFeatureDescr").Pc("ProjectFeatureLink").Pc("ProjectFeatureIcon").Pc("ProjectFeatureParentId").Pc("ProjectId").Pc("IsDisplayOnNav").Pc("DisplayOrder").Pc("IsActive").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Biz_CustomerRole_ProjectFeature_Mapping
		public static void Biz_CustomerRole_ProjectFeature_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerRoleId").Pc("ProjectFeatureId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_District
		public static void Res_District(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DistrictID").Pc("DistrictID").Pc("StateProvinceID").Pc("Name").Pc("NameUrl").Pc("NameEn").Pc("NameEnUrl").Pc("Sort").Pc("UrlRewriteName").Pc("Latitude").Pc("Longitude").Pc("MapData").Pc("CoverImage").Pc("Description").Pc("MetaTitle").Pc("MetaKeywords").Pc("MetaDescription").Pc("Published")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Area
		public static void Res_Area(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("AreaID").Pc("AreaID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("IsFeatured").Pc("StateProvinceID").Pc("CategoryID").Pc("UrlRewriteName").Pc("NameEn").Pc("HitCount").Pc("Latitude").Pc("Longitude").Pc("MapData").Pc("CoverImage").Pc("Description").Pc("MetaTitle").Pc("MetaKeywords").Pc("MetaDescription")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Deal
		public static void Deal(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("Title").Pc("Description").Pc("Total").Pc("Value").Pc("Cost").Pc("DisplayOrder").Pc("ImageThumb").Pc("Image").Pc("IsFeature").Pc("IsActive").Pc("StartDate").Pc("EndDate").Pc("ShowDate").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedBy").Pc("UpdatedBy").Pc("TotalRemaining").Pc("TotalUsed").Pc("TotalPending").Pc("UrlRewriteName").Pc("Type").Pc("ShowBefore").Pc("UniqueOffer").Pc("LimitPerUser").Pc("UseForMobile").Pc("CanPrint").Pc("NotRedeemForCash").Pc("IsPublic").Pc("Code").Pc("HoursInUse")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CustomerVerifyKey
		public static void CustomerVerifyKey(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("KeyName").Pc("Percent").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CustomerVerifying
		public static void CustomerVerifying(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("KeyId").Pc("IsVerified").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealShippingInfo
		public static void _DealShippingInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Name").Pc("Phone").Pc("Address").Pc("CityId").Pc("DistrictId").Pc("Email").Pc("Note").Pc("CreatedOn").Pc("UpdatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealItemStatus
		public static void _DealItemStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _HomeTag
		public static void _HomeTag(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("HomeTagKeyword").Pc("HomeTagLink").Pc("DisplayOrder").Pc("IsActive").Pc("StateProvinceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Street
		public static void Street(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("StreetID").Pc("CityID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("IsActived").Pc("UrlRewriteName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_TemplateOrder
		public static void _Biz_TemplateOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("TemplateId").Pc("RestaurantId").Pc("CreatedDate").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _InviteFriend_SentEmail
		public static void _InviteFriend_SentEmail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("ToEmail").Pc("ToFullName").Pc("InviteFriendType").Pc("Status").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_FoodyStat
		public static void _Biz_FoodyStat(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Key").Pc("Name").Pc("Value").Pc("BonusValue").Pc("StoreProc")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Apr_ResApproval
		public static void _Apr_ResApproval(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Type").Pc("IsApproved").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_LayoutEmail
		public static void _Biz_LayoutEmail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("ImageUrl").Pc("Body").Pc("PlainText").Pc("DisplayOrder").Pc("IsActive").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_EmailTemplate
		public static void _Biz_EmailTemplate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("BccEmailAddresses").Pc("Subject").Pc("Body").Pc("PlainText").Pc("IsActive").Pc("EmailAccountId").Pc("LayoutEmailId").Pc("CampaignId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_LogEmail
		public static void _Biz_LogEmail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Email").Pc("EmailTemplateId").Pc("IsOpened").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CustomerMessageSetting
		public static void _CustomerMessageSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("MessageType").Pc("IsSubscribe").Pc("IsSubscribeNotify")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Apr_ResLogItem
		public static void _Apr_ResLogItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Key").Pc("OldValue").Pc("NewValue").Pc("IsApproved").Pc("LogId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Video_Category_Mapping
		public static void Video_Category_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("VideoId").Pc("CategoryId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Video_Restaurant_Mapping
		public static void Video_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("VideoId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DeviceLog
		public static void _DeviceLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ClientType").Pc("ClientVersion").Pc("DeviceName").Pc("OSVersion").Pc("ErrorCode").Pc("ErrorLog").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Keyword
		public static void Keyword(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("AsciiName").Pc("HitsCount").Pc("Approved").Pc("IsHashtag")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordType
		public static void _KeywordType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _RelatedKeyword
		public static void _RelatedKeyword(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId1").Pc("KeywordId2").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Keyword_Restaurant_Mapping
		public static void _Keyword_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("RestaurantId").Pc("MappingType").Pc("Approved").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Keyword_Review_Mapping
		public static void _Keyword_Review_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("ReviewId").Pc("MappingType").Pc("Approved").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Keyword_RestaurantPicture_Mapping
		public static void _Keyword_RestaurantPicture_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("PictureId").Pc("MappingType").Pc("Approved").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Keyword_Article_Mapping
		public static void _Keyword_Article_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("ArticleId").Pc("MappingType").Pc("Approved").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for VideoProducer
		public static void VideoProducer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Logo").Pc("Link").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Video
		public static void Video(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("TitleUrl").Pc("Descr").Pc("YouTubeCode").Pc("ReviewId").Pc("CustomerId").Pc("ProducerId").Pc("TotalViews").Pc("IsFeatured").Pc("Image").Pc("IsActive").Pc("CreatedOn").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RewardSetting
		public static void Res_RewardSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("BannerId").Pc("MaxTotalTries").Pc("RewardTimePeriod").Pc("MaxTotalRewards").Pc("WinStep")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_SameBrand_Mapping
		public static void Res_SameBrand_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantId").Pc("SameBrandRestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RewardUserTransaction
		public static void Res_RewardUserTransaction(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("ResRewardId").Pc("BannerId").Pc("IPAddress").Pc("IsAcquired").Pc("CreatedOn").Pc("IsApproved").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Reward
		public static void Res_Reward(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Descr").Pc("BannerId").Pc("TotalRewards").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy").Pc("IsActive").Pc("CanWin").Pc("QuizId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RewardWinner
		public static void Res_RewardWinner(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("TransactionId").Pc("Status").Pc("CreatedOn").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantProccess
		public static void Res_RestaurantProccess(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Note").Pc("Time").Pc("Proccess")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PRArticle
		public static void Res_PRArticle(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Summary").Pc("Body").Pc("IsActive").Pc("RestaurantId").Pc("ImageURL")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_HomeKeyword
		public static void _Biz_HomeKeyword(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Link").Pc("StartDate").Pc("EndDate").Pc("StateProvinceId").Pc("RestaurantId").Pc("DisplayOrder").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_KeywordHistory_Archive
		public static void Res_KeywordHistory_Archive(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordID").Pc("Keyword").Pc("IsActive").Pc("CreateOn").Pc("UserID").Pc("Total").Pc("Priority").Pc("ProvinceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_TaskComment
		public static void Sale_TaskComment(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("TaskId").Pc("SaleId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_TaskLog
		public static void Sale_TaskLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TaskId").Pc("Description").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_Contact
		public static void Sale_Contact(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("SaleCustomerId").Pc("Name").Pc("Mobile").Pc("Phone").Pc("Email").Pc("Title").Pc("Gender").Pc("Age").Pc("Note").Pc("IsActive").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_Task
		public static void Sale_Task(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("SaleCustomerId").Pc("Assigner").Pc("SaleId").Pc("TypeId").Pc("Summary").Pc("CreatedOn").Pc("UpdatedOn").Pc("Status").Pc("Priority").Pc("Estimate").Pc("Description").Pc("IsDelete")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_Contract
		public static void Sale_Contract(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TotalValue").Pc("PaymentValue").Pc("StartDate").Pc("EndDate").Pc("ReferOrderId").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy").Pc("Note")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _QA_Answer
		public static void _QA_Answer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Content").Pc("Point").Pc("QuestionId").Pc("AnswerParentId").Pc("IsActive").Pc("CreatedOn").Pc("CreatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _QA_PointTransaction
		public static void _QA_PointTransaction(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("IsVoteUp").Pc("ReferenceId").Pc("ReferenceType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _QA_Category
		public static void _QA_Category(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Descr").Pc("NameEn").Pc("DescrEn").Pc("UrlRewriteName").Pc("DisplayOrder").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealPaymentMethod
		public static void _DealPaymentMethod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("IsActive").Pc("Note").Pc("NameEn").Pc("NoteEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealOrderStatus
		public static void _DealOrderStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _EventType
		public static void _EventType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for QA_Question
		public static void QA_Question(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Content").Pc("Point").Pc("TotalViews").Pc("CategoryId").Pc("StateProvinceId").Pc("IsActive").Pc("CreatedOn").Pc("CreatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Keyword_KeywordType_Mapping
		public static void Keyword_KeywordType_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("KeywordTypeId").Pc("LinkedObjectId").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Event
		public static void _Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("ShortDescription").Pc("Description").Pc("Image").Pc("RestaurantId").Pc("StartDate").Pc("EventDate").Pc("EndDate").Pc("IsActive").Pc("Type").Pc("DisplayOrder").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn").Pc("TotalReviewsRequired").Pc("QuizId").Pc("IsFeatured").Pc("TotalViews")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _EventUser
		public static void _EventUser(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("EventId").Pc("UserId").Pc("JoinDate").Pc("IsSelected").Pc("IsAttended").Pc("QuizPoolId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Keyword_QAQuestion_Mapping
		public static void _Keyword_QAQuestion_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("QuestionId").Pc("MappingType").Pc("Approved").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DealOrder
		public static void _DealOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("DealId").Pc("Count").Pc("UnitPrice").Pc("ShippingMethodId").Pc("ShippingInfoId").Pc("Note").Pc("IsActive").Pc("CreatedOn").Pc("Status").Pc("TotalAmount").Pc("PaymentMethodId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Keyword_QAAnswer_Mapping
		public static void _Keyword_QAAnswer_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("AnswerId").Pc("MappingType").Pc("Approved").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Keyword_List_Mapping
		public static void _Keyword_List_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("KeywordId").Pc("ListId").Pc("MappingType").Pc("Approved").Pc("Strength")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Apr_ResChangeLog
		public static void _Apr_ResChangeLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("ApprovalId").Pc("RestaurantId").Pc("CreatedOn").Pc("Type").Pc("Action").Pc("UserId").Pc("IsViewed")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Quiz_UserAnswer
		public static void _Quiz_UserAnswer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserPoolId").Pc("QuestionId").Pc("AnswerId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Quiz_Type
		public static void _Quiz_Type(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Quiz_User
		public static void _Quiz_User(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("QuizId").Pc("CreatedOn").Pc("TotalQuestion").Pc("TotalCorrect").Pc("MinimumPassed").Pc("IsConfirmed").Pc("IsPassed")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Quiz_Question
		public static void _Quiz_Question(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("QuizId").Pc("Content").Pc("CreatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_ReviewNotification
		public static void Res_ReviewNotification(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("SenderId").Pc("ReceiverId").Pc("ReviewId").Pc("CommentId").Pc("QAId").Pc("Type").Pc("IsSent").Pc("CreatedOn").Pc("QueuedEmailId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_Notification
		public static void Social_Notification(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Id").Pc("Id").Pc("Id").Pc("Id").Pc("SenderId").Pc("ReceiverId").Pc("ReceiverId").Pc("ReceiverId").Pc("ViewDate").Pc("Type").Pc("Type").Pc("Type").Pc("SenderActivityId").Pc("CreatedOn").Pc("CreatedOn").Pc("IsActive").Pc("IsActive").Pc("IsActive").Pc("UpdatedOn").Pc("UpdatedBy").Pc("Token").Pc("ReferenceId").Pc("GroupId").Pc("GroupId").Pc("RestaurantId").Pc("GroupOwnerId").Pc("ActionId").Pc("ActionId").Pc("ObjectId").Pc("ObjectId").Pc("EmailSentId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Quiz_Answer
		public static void _Quiz_Answer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("QuestionId").Pc("Content").Pc("AnswerLetter").Pc("IsCorrect").Pc("CreatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Quiz
		public static void _Quiz(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("RestaurantId").Pc("CreatedOn").Pc("Description").Pc("IsActive").Pc("MaxTotalQuestionPerPool").Pc("MinimumPassed").Pc("Type").Pc("ReferenceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _ManageToolIntro
		public static void _ManageToolIntro(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Body").Pc("Body_En").Pc("TypeId").Pc("TypeName").Pc("TypeName_En").Pc("DisplayOrder").Pc("IsChart")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordActivity
		public static void _KeywordActivity(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("KeywordHistoryId").Pc("ActivityType").Pc("ObjectId").Pc("ActionPageUrl").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MicrositeAds_ResAds_Mapping
		public static void _MicrositeAds_ResAds_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MicrositeAdsId").Pc("RestaurantId").Pc("Title").Pc("Descr").Pc("Link")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MicrositeAds_Res_Mapping
		public static void _MicrositeAds_Res_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MicrositeAdsId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MicrositeAds
		public static void _MicrositeAds(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("DisplayName").Pc("Descr").Pc("Type").Pc("DisplayOrder").Pc("IsActive").Pc("StartDate").Pc("EndDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MicrositeAds_ResCategory_Mapping
		public static void _MicrositeAds_ResCategory_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MicrositeAdsId").Pc("ResCategoryId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Notification
		public static void _Biz_Notification(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Description").Pc("Description_En").Pc("Link").Pc("CreatedOn").Pc("IsViewed").Pc("CustomerId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MemberCard
		public static void MemberCard(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Code").Pc("CardTypeId").Pc("StartDate").Pc("EndDate").Pc("CreatedOn").Pc("IsActive").Pc("IsPurchased").Pc("Price").Pc("PurchaseType").Pc("RedeemOrderId").Pc("Year")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MemberCardType
		public static void MemberCardType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("Level").Pc("IsActive").Pc("Price")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_SystemNotificationQuery
		public static void Social_SystemNotificationQuery(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("WhereClause").Pc("CreatedOn").Pc("CreatedBy").Pc("SystemNotificationId").Pc("Status").Pc("CityId").Pc("TopRank").Pc("Total").Pc("MaxId").Pc("LastId").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Place
		public static void _Place(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ApiId").Pc("ApiReference").Pc("Name").Pc("Address").Pc("Website").Pc("Latitude").Pc("Longitude").Pc("PhotoReference").Pc("PhotoUrl").Pc("Phone").Pc("Types").Pc("IsActive").Pc("SourceType").Pc("QueryId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _PlaceSearchQuery
		public static void _PlaceSearchQuery(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Latitude").Pc("Longitude").Pc("Radius").Pc("Name").Pc("Keyword").Pc("Status").Pc("CreatedOn").Pc("Sensor").Pc("RadarSearch").Pc("AreaDesc").Pc("UpdatedOn").Pc("SearchResponse").Pc("ErrorMsg").Pc("Total")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CustomerAvatar
		public static void _CustomerAvatar(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Avatar").Pc("UserId").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_ContractFeedback
		public static void _Biz_ContractFeedback(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("CreatedOn").Pc("UserId").Pc("OrderId").Pc("OrderType").Pc("IsResolved")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_Customer
		public static void Sale_Customer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("Address").Pc("Phone").Pc("DistrictId").Pc("StateProvinceId").Pc("Assigner").Pc("SaleId").Pc("IsVerified").Pc("SaleStatus").Pc("ProjectStatus").Pc("CreatedOn").Pc("IsDeleted").Pc("CustomerType").Pc("LinkFileContact")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MemberCard_Restaurant_Mapping
		public static void MemberCard_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CardTypeId").Pc("RestaurantId").Pc("Description").Pc("DiscountPercent").Pc("StartDate").Pc("EndDate").Pc("CreatedOn").Pc("Note").Pc("VerifyCode").Pc("NoteEn").Pc("DiscountText")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_AssgineeChangesLog
		public static void Sale_AssgineeChangesLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("SaleCustomerId").Pc("Assignee").Pc("ChangedBy").Pc("ChangedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DefaultSuggestion
		public static void _DefaultSuggestion(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ObjectId").Pc("ProvinceId").Pc("Type").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_ResAdsGroup
		public static void _Biz_ResAdsGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Key").Pc("Descr").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_ResAds
		public static void _Biz_ResAds(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Title").Pc("Link").Pc("Image").Pc("Descr").Pc("StateProvinceId").Pc("GroupId").Pc("StartDate").Pc("EndDate").Pc("DisplayOrder").Pc("IsActive").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _ManageToolStaticInfo
		public static void _ManageToolStaticInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Title").Pc("Title_En").Pc("Body").Pc("Body_En")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DefaultKeyword_Restaurant_Mapping
		public static void _DefaultKeyword_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DefaultKeywordId").Pc("RestaurantId").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DefaultKeyword
		public static void _DefaultKeyword(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Hits").Pc("DisplayOrder").Pc("Published")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DeviceMessageQueue
		public static void _DeviceMessageQueue(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeviceId").Pc("DeviceOSType").Pc("MessageId").Pc("DeviceToken").Pc("UserId").Pc("Message").Pc("Status").Pc("CreatedOnUtc").Pc("SentOnUtc").Pc("SentTries").Pc("Uri").Pc("TrackId").Pc("IsViewed").Pc("IsPush").Pc("MessageType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_UserInfo
		public static void Reservation_UserInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("FullName").Pc("Phone").Pc("Email").Pc("IsActive").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_BookTime
		public static void Reservation_BookTime(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Time").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_TimeRange
		public static void Reservation_TimeRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReservationResId").Pc("DayOfWeek").Pc("CustomDate").Pc("Type").Pc("StartTime").Pc("EndTime").Pc("IsDayOff")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for SearchType
		public static void SearchType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordTemplate
		public static void _KeywordTemplate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("KeywordId").Pc("SearchTypeId").Pc("ProvinceId").Pc("LuceneQueryCached").Pc("NeedRebuildQuery").Pc("TemplateType").Pc("IsActived")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordHistory
		public static void _KeywordHistory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("KeywordId").Pc("SearchTypeId").Pc("ProvinceId").Pc("UserId").Pc("Source").Pc("SearchTime").Pc("ResultCount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Provider
		public static void Provider(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("Image").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MemberCard_PromoCode_Mapping
		public static void _MemberCard_PromoCode_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("MemberCardId").Pc("PromoCodeId").Pc("CreatedOn").Pc("DeviceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserAnnualPoints
		public static void Rwd_UserAnnualPoints(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserId").Pc("Year").Pc("TotalPoints").Pc("TotalPendingPoints").Pc("PointLevelId").Pc("Rank")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserAnnualPointsYear
		public static void Rwd_UserAnnualPointsYear(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Year").Pc("ImageUrl")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _PromoCode
		public static void _PromoCode(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Type").Pc("Value").Pc("UserId").Pc("Status").Pc("CreatedOn").Pc("UpdatedOn").Pc("StartDate").Pc("EndDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MemberCardType_PromoCode_Mapping
		public static void _MemberCardType_PromoCode_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CardTypeId").Pc("PromoCodeId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_PlanOrderItem
		public static void _Biz_PlanOrderItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("PlanId").Pc("UserId").Pc("RestaurantId").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedById").Pc("UpdatedById").Pc("Status").Pc("Comment").Pc("Price").Pc("FinalPrice").Pc("Unit").Pc("Amount").Pc("SubTotal").Pc("StartDate").Pc("EndDate").Pc("SaleCustomerId").Pc("FileReport").Pc("IsNotPublishItem").Pc("CalendarNotSureStatus").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MemberCard_Verify_History
		public static void _MemberCard_Verify_History(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("ResId").Pc("CardTypeId").Pc("DiscountPercent").Pc("CreatedOn").Pc("ClientType").Pc("MemberCardId").Pc("DeviceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _LikeDislike
		public static void _LikeDislike(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReferenceId").Pc("Type").Pc("UserId").Pc("CreatedOn").Pc("IsLiked")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CustomerPreferenceStatistic
		public static void _CustomerPreferenceStatistic(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Type").Pc("IsSystemUpdated").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _FacebookLikePost
		public static void _FacebookLikePost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FacebookUrl").Pc("FoodyUrl").Pc("StartDate").Pc("EndDate").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _PushSettingCategory
		public static void _PushSettingCategory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupType").Pc("Name").Pc("NameEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _PushSettingGroup
		public static void _PushSettingGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantNotification
		public static void Res_RestaurantNotification(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Notification").Pc("PublishedOn").Pc("IsActive").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishCategory
		public static void Res_DishCategory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DishCategoryID").Pc("Name").Pc("NameUrl").Pc("ParentID").Pc("DisplayOrder").Pc("IsActive").Pc("IsFeatured").Pc("UrlRewriteName").Pc("NameEn").Pc("IsPopular").Pc("HitCount").Pc("Icon")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for __Social_UserFollow
		public static void __Social_UserFollow(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("FollowingUserId").Pc("CreatedOn").Pc("IsDenied").Pc("IsActive").Pc("UpdatedOn").Pc("UpdatedBy").Pc("ViaSocialType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _ArticleDetail
		public static void _ArticleDetail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ArticleId").Pc("Title").Pc("Content").Pc("RestaurantId").Pc("IsActive").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for StateProvinceTemp
		public static void StateProvinceTemp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Published").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _PushSettingGroupActionMapping
		public static void _PushSettingGroupActionMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupId").Pc("Action")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserReceivePushSetting
		public static void UserReceivePushSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("GroupId").Pc("Categories")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DeviceReceivePushSetting
		public static void _DeviceReceivePushSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeviceId").Pc("GroupId").Pc("Categories")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Restaurant_TargetAudience_Mapping
		public static void Restaurant_TargetAudience_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantId").Pc("TargetAudienceId").Pc("RelatedPercent")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_TaskType
		public static void Sale_TaskType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Duration").Pc("TargetQuantity").Pc("TargetImportance").Pc("TargetScore").Pc("Note").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _NotificationGroup
		public static void _NotificationGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Id").Pc("ReceiverId").Pc("ActionType").Pc("ObjectType").Pc("ObjectId").Pc("ObjectOwnerId").Pc("PageType").Pc("PageId").Pc("Status").Pc("IsActive").Pc("CreatedOn").Pc("LatestUpdatedOn").Pc("LatestViewDate").Pc("LatestActivityDate").Pc("ViewToken").Pc("TotalSenders").Pc("Message").Pc("PushStatus").Pc("MessageEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ResAds_RelatedRes_Mapping
		public static void ResAds_RelatedRes_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ResAdsId").Pc("RelatedResId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _GeneralNote
		public static void _GeneralNote(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Subject").Pc("Content").Pc("Type").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_RestaurantInfo
		public static void Reservation_RestaurantInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("ShortDescription").Pc("Description").Pc("CreatedOn").Pc("StartDate").Pc("EndDate").Pc("ShowDate").Pc("ImageURL").Pc("DiscountValue").Pc("MaxAdult").Pc("MaxChildren").Pc("MaxTable").Pc("DisplayOrder").Pc("IsActive").Pc("Note").Pc("IsDeleted").Pc("Commission").Pc("ReviewWidget").Pc("IsFeature").Pc("Email")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CustomerAvatar_Bak
		public static void _CustomerAvatar_Bak(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CustomerId").Pc("Avatar")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MemberCardRes_Order_Mapping
		public static void _MemberCardRes_Order_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("MemberCardResMappingId").Pc("OrderId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DeviceToken
		public static void _DeviceToken(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Token").Pc("Type").Pc("IsActive").Pc("DeviceName").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn").Pc("CityId").Pc("IsTest").Pc("ReceivePush").Pc("UniqueId").Pc("LanguageId").Pc("Latitude").Pc("Longtitude")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_User_OrderDetails
		public static void Res_User_OrderDetails(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ResUserOrderId").Pc("UserId").Pc("ResId").Pc("SystemDishId").Pc("Price").Pc("Qty").Pc("TotalPrice").Pc("CreatedDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_User_Order
		public static void Res_User_Order(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("ResId").Pc("AmtPrice").Pc("AmtQty").Pc("Status").Pc("FullName").Pc("Mobile").Pc("Address").Pc("PaymentType").Pc("CreatedDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Article_ArticleCategory_Mapping
		public static void _Article_ArticleCategory_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ArticleId").Pc("ArticleCategoryId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_PlanOrder
		public static void _Biz_PlanOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Amount").Pc("CreatedOn").Pc("UpdatedOn").Pc("UpdatedById").Pc("CreatedById").Pc("Status").Pc("Comment").Pc("PaymentMethod").Pc("SubTotal").Pc("Type").Pc("RestaurantDescription").Pc("RestaurantDescriptionUrl").Pc("RequireInvoice").Pc("IsTrash").Pc("VerifyRestaurant").Pc("IsCreatedInBusiness").Pc("CityId").Pc("ContractNumber").Pc("AllowedEdit").Pc("ReservedOnCalendar").Pc("IsFullTrial").Pc("IsPOSOnly")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for SystemListType
		public static void SystemListType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("Description").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _App_Banner_GoLink
		public static void _App_Banner_GoLink(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Key").Pc("Link")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CategoryAd_Restaurant_Mapping
		public static void _CategoryAd_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CategoryId").Pc("RestaurantId").Pc("DisplayOrder").Pc("StartDate").Pc("EndDate").Pc("IsActive").Pc("ShowInSearchResult")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _MemCardRestaurantOwner
		public static void _MemCardRestaurantOwner(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_PlanOrderItemTimeLine
		public static void _Biz_PlanOrderItemTimeLine(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("StartDate").Pc("EndDate").Pc("OrderItemId").Pc("IsSpecial").Pc("SpecialId").Pc("SpectialTitle")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CouponPaymentMethod
		public static void _CouponPaymentMethod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("IsActive").Pc("Note").Pc("NameEn").Pc("NoteEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Creative
		public static void _Biz_Creative(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ServiceName").Pc("ServiceNameEN").Pc("Description").Pc("DescriptionEN").Pc("Limit").Pc("Amount").Pc("Unit").Pc("Price").Pc("IsPublish").Pc("DisplayOrder").Pc("IconUrl").Pc("Price_HN").Pc("Price_DNG")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordSourceToken
		public static void _KeywordSourceToken(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ObjectId").Pc("ObjectName").Pc("Name").Pc("AsciiName").Pc("ProvinceId").Pc("ParentId").Pc("Type").Pc("KeywordSourceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordSource
		public static void _KeywordSource(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Priority").Pc("BonusMark").Pc("BoostFactor").Pc("SearchTerm")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _KeywordSourceModify
		public static void _KeywordSourceModify(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("AsciiName").Pc("Type").Pc("KeywordSourceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Coupon_MemberCardType_Discount
		public static void _Coupon_MemberCardType_Discount(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CouponId").Pc("MemberCardType").Pc("Discount").Pc("Price").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_CalendarTimeline
		public static void _Biz_CalendarTimeline(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("StartDate").Pc("EndDate").Pc("CalendarId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CouponOrder
		public static void _CouponOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("CouponId").Pc("Count").Pc("UnitPrice").Pc("ShippingMethodId").Pc("ShippingInfoId").Pc("PaymentMethodId").Pc("Note").Pc("IsActive").Pc("CreatedOn").Pc("Status").Pc("TotalAmount").Pc("MemberCardId").Pc("QtyDiscount").Pc("UnitDiscount").Pc("TotalDiscount").Pc("DiscountTransactionId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DeviceMessageQuery
		public static void _DeviceMessageQuery(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Message").Pc("UserId").Pc("Status").Pc("DeviceType").Pc("IsActive").Pc("CreatedOn").Pc("UpdatedOn").Pc("LastId").Pc("CityId").Pc("Uri").Pc("TestOnly").Pc("ExpiredDate").Pc("TrackId").Pc("Img").Pc("CustomWhereClause").Pc("StartTime").Pc("StateProvinceIds").Pc("TestUserIds").Pc("UriAction").Pc("UriId").Pc("WebUrl").Pc("Type").Pc("SystemMessageId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Message_DeviceType_Mapping
		public static void _Message_DeviceType_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DeviceType").Pc("MessageId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _ReadMessage
		public static void _ReadMessage(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("MessageId").Pc("Token").Pc("UserId").Pc("ViewDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Ecard_Restaurant_User_Mapping
		public static void _Ecard_Restaurant_User_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantId").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_CategoryGroup_Mapping
		public static void Res_Restaurant_CategoryGroup_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("CategoryGroupId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserActivity
		public static void UserActivity(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("ActionType").Pc("ObjectType").Pc("ObjectId").Pc("ObjectOwnerId").Pc("ResultType").Pc("ResultId").Pc("PageType").Pc("PageId").Pc("IsActive").Pc("RelatedUsers").Pc("CreatedOn").Pc("NotiStatus").Pc("DeviceType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _NotificationSender
		public static void _NotificationSender(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("NotificationGroupId").Pc("SenderId").Pc("ActivityId").Pc("CreatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CategoryStatistic
		public static void _CategoryStatistic(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryId").Pc("ProvinceId").Pc("RestaurantCount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CategoryGroupStatistic
		public static void _CategoryGroupStatistic(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryGroupId").Pc("ProvinceId").Pc("RestaurantCount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_RechargeService
		public static void _Biz_RechargeService(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("CustomerId").Pc("TotalValue").Pc("PaymentValue").Pc("RemainValue")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Wifi
		public static void Res_Wifi(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("Password").Pc("UserId").Pc("CreatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _FacebookLikeStateProvince
		public static void _FacebookLikeStateProvince(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FacebookUrl").Pc("StateProvinceId").Pc("IsActive").Pc("CategoryGroupId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _ActivityLog
		public static void _ActivityLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ActivityLogTypeId").Pc("CustomerId").Pc("ObjectKey").Pc("SecondaryObjectKey").Pc("ActivitySource").Pc("ActivityUrl").Pc("AditionInfo").Pc("SessionKey").Pc("IpAddress").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _HomeSection
		public static void _HomeSection(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("AppCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Coupon
		public static void _Coupon(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CouponID").Pc("RestaurantID").Pc("CouponPriceID").Pc("Name").Pc("ShortDesc").Pc("Description").Pc("TotalAmount").Pc("DisplayTotalAmount").Pc("LimitPerUser").Pc("Price").Pc("Value").Pc("Point").Pc("Discount").Pc("DisplayOrder").Pc("ImageThumbUrl").Pc("ImageUrl").Pc("IsFeature").Pc("IsFree").Pc("IsActive").Pc("StartDate").Pc("EndDate").Pc("ShowDate").Pc("FromDate").Pc("ToDate").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedBy").Pc("UpdatedBy").Pc("TotalRemaining").Pc("TotalUsed").Pc("UrlRewriteName").Pc("Type").Pc("QRCodeImageUrl").Pc("Duration").Pc("NextCouponId").Pc("TotalViews").Pc("CampaignId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserBalanceTransactions
		public static void Rwd_UserBalanceTransactions(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Type").Pc("ChangedBalance").Pc("CreatedOn").Pc("ReferenceId").Pc("OrderId").Pc("Description").Pc("IsActive").Pc("IsPublic").Pc("PointTransactionId").Pc("CampaignId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_SubCategory_Mapping
		public static void Reservation_SubCategory_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReservationResId").Pc("SubCategoryId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_CategoryGroup
		public static void Res_CategoryGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("IsActive").Pc("DisplayOrder").Pc("GroupKey").Pc("RestaurantCount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Rwd_UserBalanceCampaign
		public static void Rwd_UserBalanceCampaign(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Balance").Pc("IsActive").Pc("CampaignId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_CategoryGroup_DiscoveryBoxSetting
		public static void Res_CategoryGroup_DiscoveryBoxSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CountryId").Pc("CityId").Pc("GroupCategoryId").Pc("Type").Pc("Categories").Pc("Name").Pc("NameEn").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_CategoryGroup_HomeSection_Mapping
		public static void Res_CategoryGroup_HomeSection_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CountryId").Pc("CityId").Pc("CategoryGroupId").Pc("SectionId").Pc("Type").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Country_City_CategoryGroup_Mapping
		public static void _Country_City_CategoryGroup_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CountryId").Pc("CityId").Pc("CategoryGroupId").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_Calendar
		public static void _Biz_Calendar(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("CategoryGroup").Pc("Location").Pc("Type").Pc("ServiceId").Pc("Status").Pc("SaleId").Pc("OrderId").Pc("PaymentValue").Pc("RestaurantInfo")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_CalendarTimelineTemp
		public static void _Biz_CalendarTimelineTemp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("StartDate").Pc("EndDate").Pc("CalendarId").Pc("CategoryGroup")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DeviceSystemMessageSchedule
		public static void _DeviceSystemMessageSchedule(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Message").Pc("Repeat").Pc("DeviceTypes").Pc("CityIds").Pc("TrackId").Pc("UriAction").Pc("UriId").Pc("StartTime").Pc("CustomQuery")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_SubCategory
		public static void Reservation_SubCategory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("RootCategoryId").Pc("IsActive").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for User_StampItem_Mapping
		public static void User_StampItem_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("StampItemId").Pc("CreatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Stamp
		public static void Res_Stamp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("RestaurantId").Pc("IsActive").Pc("Description").Pc("CreatedOn").Pc("StartDate").Pc("EndDate").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_StampAward
		public static void Res_StampAward(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("Description").Pc("Discount").Pc("Img")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for BankCard
		public static void BankCard(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("BankId").Pc("Name").Pc("IsActive").Pc("Img").Pc("Discount").Pc("Policy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for RestaurantDish
		public static void RestaurantDish(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("SystemDishId").Pc("PhotoUrl").Pc("Name").Pc("NameUrl").Pc("NameEn").Pc("Price").Pc("Description").Pc("CategoryId").Pc("TypeId").Pc("IsFeatured").Pc("IsActive").Pc("IsGlobal").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishPicture
		public static void Res_DishPicture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DishId").Pc("RestaurantPictureId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_StampItem
		public static void Res_StampItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("StampId").Pc("Order").Pc("AwardId").Pc("IsActive").Pc("Code").Pc("Description").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryTimeRange
		public static void DeliveryTimeRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("DayOfWeek").Pc("CustomDate").Pc("TimeOpen").Pc("TimeClose").Pc("IsDayOff").Pc("Title")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryManStatus
		public static void DeliveryManStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderStatusLog
		public static void DeliveryOrderStatusLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryOrderId").Pc("Assign_UserId").Pc("Assign_RestaurantId").Pc("StatusId").Pc("CreatedOn").Pc("CreatedUserId").Pc("Note")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ShortenUrlMapping
		public static void ShortenUrlMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Url").Pc("Code").Pc("CreatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Bank
		public static void Bank(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("Img").Pc("IsDelete")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderConnect
		public static void DeliveryOrderConnect(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("OrderId").Pc("ConnectId").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrder_ResDish_Mapping
		public static void DeliveryOrder_ResDish_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryOrderId").Pc("ResDishId").Pc("StartDate").Pc("EndDate").Pc("Status").Pc("CreatedOn").Pc("CreatedUserId").Pc("UpdatedOn").Pc("UpdatedUserId").Pc("VersionNo")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Category_Mapping
		public static void Delivery_Category_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DeliveryId").Pc("CategoryId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCollectionItem
		public static void DeliveryCollectionItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CollectionId").Pc("RestaurantId").Pc("CreatedBy").Pc("CreatedOn").Pc("DisplayOrder").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserSocialPushSetting
		public static void UserSocialPushSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("CategoryId").Pc("Time").Pc("IsActive").Pc("LatestPush")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryManDetail
		public static void DeliveryManDetail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryManId").Pc("DeliveryOrderId").Pc("DeliveryShippingInfoId").Pc("RestaurantId").Pc("UserId").Pc("DeliveredTime").Pc("EstimateTime").Pc("CreatedOn").Pc("HasReAssigned").Pc("StatusId").Pc("Printable").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_Printer_Mapping
		public static void DeliveryMan_Printer_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryManId").Pc("DeliveryPrinterId").Pc("CreatedOn").Pc("CreatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPrinterLog
		public static void DeliveryPrinterLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryPrinterId").Pc("DeliveryOrderId").Pc("DeliveryPrinterLogType").Pc("Status").Pc("Note").Pc("LogTime").Pc("CreadtedOn").Pc("CreatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for SearchDocument_PredefineKeyword
		public static void SearchDocument_PredefineKeyword(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ProvinceId").Pc("Level").Pc("Priority").Pc("CategoryId").Pc("CategoryName").Pc("CategoryAsciiName").Pc("AreaId").Pc("AreaName").Pc("AreaAsciiName").Pc("DistrictId").Pc("DistrictName").Pc("DistrictAsciiName").Pc("StreetId").Pc("StreetName").Pc("StreetAsciiName").Pc("PurposeId").Pc("PurposeName").Pc("PurposeAsciiName").Pc("DiningId").Pc("DiningName").Pc("DiningAsciiName").Pc("CuisineId").Pc("CuisineName").Pc("CuisineAsciiName").Pc("PropertyId").Pc("PropertyName").Pc("PropertyAsciiName").Pc("DishCategoryId").Pc("DishCategoryName").Pc("DishCategoryAsciiName").Pc("DishId").Pc("DishName").Pc("DishAsciiName").Pc("Type").Pc("ResultCount").Pc("IndexUpdatedOn").Pc("IndexCreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for __SearchDocument_Restaurant
		public static void __SearchDocument_Restaurant(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AreaId").Pc("DistrictId").Pc("CityId").Pc("Name").Pc("AsciiName").Pc("Phone").Pc("UrlRewriteName").Pc("Address").Pc("Area").Pc("District").Pc("City").Pc("Location").Pc("SpecialDesc").Pc("TotalReview").Pc("TotalView").Pc("TotalFavourite").Pc("AvgRating").Pc("PicturePath").Pc("CreatedOn").Pc("Latitude").Pc("Longitude").Pc("MetaKeywords").Pc("PriceMin").Pc("PriceMax").Pc("MobileImageUrl").Pc("Promotions").Pc("Dishes").Pc("Purposes").Pc("Cuisines").Pc("Categories").Pc("DeliveryCategories").Pc("ReservationCategories").Pc("CategoryGroups").Pc("Properties").Pc("DishCategories").Pc("Dinings").Pc("BrandName").Pc("BrandAsciiName").Pc("IsHeadBrand").Pc("Status").Pc("SpecialOrder").Pc("Keywords").Pc("StreetId").Pc("StreetName").Pc("StreetAsciiName").Pc("BrandId").Pc("MetaTitle").Pc("TierID").Pc("Ads").Pc("Boost").Pc("HasCoupon").Pc("HasPromotion").Pc("TotalCheckins").Pc("KeywordAds").Pc("HasCard").Pc("HasBooking").Pc("HasDelivery").Pc("HasStamp").Pc("HasBankCard").Pc("IndexUpdatedOn").Pc("IndexCreatedOn").Pc("DeliveryShowDate").Pc("DeliveryEndDate").Pc("DeliveryDistrictIds").Pc("DeliveryOrderCount").Pc("BookingShowDate").Pc("BookingEndDate").Pc("BookingOrderCount").Pc("BookingDiscount").Pc("BookingDisplayOrder").Pc("DeliveryDisplayOrder").Pc("BankCardIds")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishRating
		public static void Res_DishRating(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DishId").Pc("UserId").Pc("Point").Pc("Comment").Pc("IsActive").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PromotionPicture
		public static void Res_PromotionPicture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PictureID").Pc("PromotionID").Pc("RestaurantID").Pc("PhotoUrl").Pc("Name").Pc("CreatedOn").Pc("UserID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_BankCard
		public static void Res_BankCard(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("RestaurantId").Pc("CardId").Pc("Discount").Pc("Policy").Pc("Description").Pc("Img").Pc("IsActive").Pc("CreatedOn").Pc("StartDate").Pc("EndDate").Pc("DisplayOrder").Pc("Url")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PRArticlePicture
		public static void Res_PRArticlePicture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PictureID").Pc("PRArticleID").Pc("RestaurantID").Pc("PhotoUrl").Pc("Name").Pc("CreatedOn").Pc("UserID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Sale_CustomerType_Mapping
		public static void Sale_CustomerType_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("SaleCustomerId").Pc("CustomerTypeId").Pc("SaleId").Pc("CreatedOn").Pc("ExpiredOn").Pc("ExpireStatus")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_CustomerType
		public static void _Biz_CustomerType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryShippingInfoLog
		public static void DeliveryShippingInfoLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FieldName").Pc("FieldValue").Pc("FieldValue_Old").Pc("CreatedOn").Pc("CreatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for StateProvince_Facebook_Mapping
		public static void StateProvince_Facebook_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FacebookCityId").Pc("FoodyCityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_AreaTable
		public static void _Pos_AreaTable(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("Name").Pc("MaxTable").Pc("Description").Pc("DisplayOrder").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("BackgroundColor").Pc("AreaBackgroundId").Pc("Code")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_RawMaterialType
		public static void _Pos_RawMaterialType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("Name").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("IdTypeSystem")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Regency
		public static void _Pos_Regency(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Salarylevels
		public static void _Pos_Salarylevels(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("EmployeeID").Pc("Salary").Pc("FromDate").Pc("ToDate").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Unit
		public static void _Pos_Unit(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ParentId").Pc("Name").Pc("Ratio").Pc("Description").Pc("Conversion").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_WorkTime
		public static void _Pos_WorkTime(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("EmployeeID").Pc("WorkDate").Pc("WorkTime").Pc("Salary").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("RegencyID").Pc("Summary")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliverySuggestion
		public static void DeliverySuggestion(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("SuggestCount").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_OrderStatusLog
		public static void Reservation_OrderStatusLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("StatusId").Pc("CreatedOn").Pc("CreatedUserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Bank_Country_Mapping
		public static void _Bank_Country_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CountryId").Pc("BankId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPromotion
		public static void DeliveryPromotion(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Percent").Pc("StartDate").Pc("EndDate").Pc("StartTime").Pc("EndTime").Pc("CreatedOn").Pc("CreatedUserId").Pc("UpdatedOn").Pc("UpdateUserId").Pc("IsDeleted")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Dish_RawMaterial_Mapping
		public static void _Pos_Dish_RawMaterial_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RawMaterialId").Pc("DishId").Pc("RestaurantID").Pc("EstimatesQty").Pc("UnitId").Pc("Ratio").Pc("UnitPrice").Pc("TotalPrice").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_District_Mapping
		public static void Delivery_District_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("DistrictId").Pc("Time").Pc("Cost").Pc("IsActive").Pc("OnlyShowCS")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCampaignItems
		public static void DeliveryCampaignItems(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CampaignId").Pc("RestaurantId").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_RawMaterial
		public static void _Pos_RawMaterial(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("GroupId").Pc("UnitId").Pc("Name").Pc("OldUnitPrice").Pc("NewUnitPrice").Pc("InventoryPrice").Pc("LastQty").Pc("Qty").Pc("UsedQty").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("LastPurchaseDate").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("Owner")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_OrderItem
		public static void _Pos_OrderItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderID").Pc("DishID").Pc("Qty").Pc("UnitPrice").Pc("Status").Pc("Description").Pc("Note").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("GroupName").Pc("KitchenId").Pc("DiscountPercent").Pc("DiscountCost").Pc("Type").Pc("DiscountValue").Pc("TotalAmount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryLog
		public static void DeliveryLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("Description").Pc("ImageUrl").Pc("MinimumOrderAmount").Pc("ShowDate").Pc("StartDate").Pc("EndDate").Pc("CreatedOn").Pc("UpdatedOn").Pc("IsActive").Pc("DisplayOrder").Pc("Service").Pc("IsFoodyDelivery").Pc("IsFeature").Pc("IsDeleted").Pc("ComsDeliveryByFoody").Pc("ComsDeliveryByRes").Pc("VAT").Pc("HasContract").Pc("PayType").Pc("Email").Pc("UserIdCreated").Pc("UserIdChanged").Pc("ChangedOn").Pc("ComsDeliveryByUser")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for temp
		public static void temp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("Verified_UserId").Pc("Assign_UserId").Pc("StatusId").Pc("ReceivedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Purchase
		public static void _Pos_Purchase(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("OrderId").Pc("Name").Pc("ServicePercent").Pc("ServiceCost").Pc("VATPercent").Pc("VATCost").Pc("SubPrice").Pc("DiscountPercent").Pc("DiscountCost").Pc("Description").Pc("DeliveryStatus").Pc("PayStatus").Pc("PurchaseDate").Pc("Type").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("SupplierId").Pc("Owner").Pc("TotalPrice")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Expense
		public static void _Pos_Expense(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("Cost").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_ExpenseLog
		public static void _Pos_ExpenseLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("ExpenseId").Pc("Cost").Pc("ExpenseDate").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_PurchaseItem
		public static void _Pos_PurchaseItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("id").Pc("PurchaseId").Pc("RawMaterialId").Pc("UnitId").Pc("OrderId").Pc("Qty").Pc("UnitPrice").Pc("TotalPrice").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_ActionGroup
		public static void _Pos_ActionGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Keys").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_ActionItems
		public static void _Pos_ActionItems(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupId").Pc("Keys").Pc("Name").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Employee_ActionItems_Mapping
		public static void _Pos_Employee_ActionItems_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ActionItemId").Pc("EmployeeId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPrinterOrderDetail
		public static void DeliveryPrinterOrderDetail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryOrderId").Pc("CodePrinter").Pc("StatusId").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPrinter
		public static void DeliveryPrinter(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Status").Pc("IsAtCompany")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCampaign
		public static void DeliveryCampaign(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("ShortDescription").Pc("Description").Pc("IconName").Pc("DiscountPrice").Pc("DiscountService").Pc("DiscountShipping").Pc("AutoApprove").Pc("UrlRewrite").Pc("ShowDate").Pc("StartDate").Pc("EndDate").Pc("CreatedBy").Pc("UpdatedBy").Pc("IsActive").Pc("IsDeleted")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishReportError
		public static void Res_DishReportError(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ResId").Pc("DishId").Pc("UserId").Pc("IPAddress").Pc("Url").Pc("CreatedOn").Pc("ReportType").Pc("Title").Pc("Description").Pc("IsResolved").Pc("Email")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _RequestLog
		public static void _RequestLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Username").Pc("HttpMethod").Pc("Url").Pc("ReferalUrl").Pc("ServerIp").Pc("ClientIp").Pc("UserAgent").Pc("ExecutionTime").Pc("LoggedOn").Pc("MoreInfo")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryManLocationLog
		public static void DeliveryManLocationLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryManId").Pc("CreatedOn").Pc("Latitude").Pc("Longitude").Pc("VersionApp").Pc("DeviceInfo")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_DeviceToken
		public static void Delivery_DeviceToken(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Token").Pc("Type").Pc("IsActive").Pc("DeviceName").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn").Pc("CityId").Pc("UniqueId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_DeviceMessageQueue
		public static void Delivery_DeviceMessageQueue(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeviceId").Pc("MessageId").Pc("UserId").Pc("Status").Pc("CreatedOnUtc").Pc("SentOnUtc").Pc("SentTries").Pc("Uri").Pc("TrackId").Pc("IsViewed").Pc("TypePush")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_WorkPeriod
		public static void _Pos_WorkPeriod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("StartingEmployeeId").Pc("StartingUserId").Pc("EndingEmployeeId").Pc("EndingUserId").Pc("ReceivedMoney").Pc("TransferedMoney").Pc("Description").Pc("StartDate").Pc("EndDate").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Supplier
		public static void _Pos_Supplier(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("Telephone").Pc("Email").Pc("Fax").Pc("MobilePhone").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_AddressSupplier
		public static void _Pos_AddressSupplier(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("SupplierId").Pc("Address").Pc("IsMain")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_DeviceMessageQuery
		public static void Delivery_DeviceMessageQuery(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Message").Pc("CreatedBy").Pc("Status").Pc("DeviceType").Pc("IsActive").Pc("CreatedOn").Pc("UpdatedOn").Pc("LastId").Pc("Uri").Pc("TrackId").Pc("Img").Pc("StartTime").Pc("CityIds").Pc("UserIds").Pc("UriAction").Pc("UriId").Pc("TypePush").Pc("Lat").Pc("Lng").Pc("PushTries")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _ArticleCategory
		public static void _ArticleCategory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("IsActive").Pc("UrlRewriteName").Pc("NameEn").Pc("CategoryGroupId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Table
		public static void _Pos_Table(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("AreaId").Pc("Name").Pc("SeatQty").Pc("Top").Pc("Left").Pc("Type").Pc("Description").Pc("DisplayOrder").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("Width").Pc("Height").Pc("Angle").Pc("AreaBackgroundId").Pc("MaxSplit")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_OrderUserInfo
		public static void _Pos_OrderUserInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("FullName").Pc("Phone").Pc("Address").Pc("Email").Pc("CreatedOn").Pc("UpdatedOn").Pc("TypeMember").Pc("ProvinceId").Pc("RestaurantID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_AreaBackground
		public static void _Pos_AreaBackground(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("Title").Pc("ImageUrl").Pc("Description").Pc("IsActive").Pc("Type").Pc("IsDelete")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_AreaObject
		public static void _Pos_AreaObject(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AreaId").Pc("Top").Pc("Left").Pc("Width").Pc("Height").Pc("IsActive").Pc("Angle").Pc("RestaurantId").Pc("AreaBackgroundId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserPromotion
		public static void UserPromotion(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("TitleEn").Pc("Description").Pc("PlaceId").Pc("IsActive").Pc("StartDate").Pc("EndDate").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserPromotionPicture
		public static void UserPromotionPicture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionId").Pc("Title").Pc("FileName").Pc("UserId").Pc("CreatedOn").Pc("OriginalWidth").Pc("OriginalHeight")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_ReservationOrder_Table_Mapping
		public static void _Pos_ReservationOrder_Table_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReservationOrderId").Pc("TableId").Pc("RestaurantId").Pc("CreatedBy").Pc("CreatedOn").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserPromotionType
		public static void UserPromotionType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserPromotionInputTypeOption
		public static void UserPromotionInputTypeOption(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("InputTypeId").Pc("Name").Pc("NameEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserPromotionInputType
		public static void UserPromotionInputType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("NameEn").Pc("InputType").Pc("PlaceHolder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for UserPromotionValues
		public static void UserPromotionValues(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionId").Pc("Type").Pc("InputType").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_PlanFeatureType
		public static void _Biz_PlanFeatureType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Name_EN")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Biz_PlanFeature
		public static void _Biz_PlanFeature(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("Description").Pc("DisplayOrder").Pc("Price").Pc("KeyName").Pc("IsActive").Pc("SupportLink").Pc("SuffixClass").Pc("FeatureOrder").Pc("FeatureType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserBalanceType
		public static void Delivery_UserBalanceType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DisplayName").Pc("DisplayNameEn").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantRelatedPicture
		public static void Res_RestaurantRelatedPicture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantRelatedId").Pc("PhotoUrl").Pc("Link").Pc("LinkTarget").Pc("Description").Pc("DisplayOrder").Pc("IsActive").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantRelatedMapping
		public static void Res_RestaurantRelatedMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantRelatedId").Pc("RestaurantId").Pc("IsActive").Pc("DisplayOrder").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_OrderItem_Kitchen
		public static void _Pos_OrderItem_Kitchen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("OrderId").Pc("DishId").Pc("DishName").Pc("TableName").Pc("Qty").Pc("OrderDate").Pc("Note").Pc("Description").Pc("OrderType").Pc("Status").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("KitchenId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantRelated
		public static void Res_RestaurantRelated(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Title").Pc("IsActive").Pc("Trash").Pc("DisplayOrder").Pc("Description").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Place_View
		public static void _Place_View(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PlaceId").Pc("UserId").Pc("ViewDate").Pc("IpAddress").Pc("DeviceType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Report_Delivery_Setting_Extension
		public static void Report_Delivery_Setting_Extension(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("CongNoPhaiThuPhatSinhGiam").Pc("CongNoPhaiTraPhatSinhGiam").Pc("TonDauKyCongNoPhaiThu").Pc("TonDauKyCongNoPhaiTra").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Reservation_Order
		public static void _Pos_Reservation_Order(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderNumber").Pc("RestaurantId").Pc("Date").Pc("Time").Pc("AdultTotal").Pc("ChildrenTotal").Pc("Note").Pc("Status").Pc("UserInfo").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn").Pc("UpdatedBy").Pc("DeviceClientType").Pc("DeviceOSType").Pc("Rest").Pc("Adpayment").Pc("Total")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Reservation_TimeRange
		public static void _Pos_Reservation_TimeRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("DayOfWeek").Pc("StartTime").Pc("EndTime").Pc("IsDayOff")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Reservation_UserInfo
		public static void _Pos_Reservation_UserInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("FullName").Pc("Phone").Pc("Email").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_SettingType
		public static void _Pos_SettingType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Group").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Setting
		public static void _Pos_Setting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TypeId").Pc("RestaurantId").Pc("Value").Pc("IsShow")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _FacebookAppToken
		public static void _FacebookAppToken(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("AppId").Pc("Token").Pc("ExpiredDate").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _FacebookApp
		public static void _FacebookApp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AppId").Pc("AppSecret").Pc("Name").Pc("IsDefault")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _FacebookAppAdsAccount
		public static void _FacebookAppAdsAccount(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AppId").Pc("AccountId").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _FacebookPost
		public static void _FacebookPost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AppId").Pc("TokenId").Pc("PageId").Pc("AdsAccountId").Pc("Message").Pc("Published").Pc("ChildAttachments").Pc("Caption").Pc("Link").Pc("CreatedOn").Pc("CreatedBy").Pc("PostId").Pc("PostDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _FacebookPage
		public static void _FacebookPage(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserTokenId").Pc("PageId").Pc("PageName").Pc("PageToken").Pc("CreatedOn").Pc("CreatedBy").Pc("IsActive").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserBalanceChangeLogs
		public static void Delivery_UserBalanceChangeLogs(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("LogId").Pc("OldValue").Pc("NewValue").Pc("TransId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserBalanceTransactionsType
		public static void Delivery_UserBalanceTransactionsType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DisplayName").Pc("DisplayNameEn").Pc("Description").Pc("IsNegative")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserType
		public static void Delivery_UserType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("Level").Pc("IsActive").Pc("Price").Pc("AddPercent")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserType_User_Mapping
		public static void Delivery_UserType_User_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("UserType").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_CustomerStart
		public static void _Pos_CustomerStart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("CreatedOn").Pc("StartDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserBalance
		public static void Delivery_UserBalance(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserId").Pc("BalanceType").Pc("Balance").Pc("IsActive").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Mov_Banner
		public static void _Mov_Banner(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PhotoUrl").Pc("Title").Pc("Url").Pc("Target").Pc("IsActive").Pc("DisplayOrder").Pc("Description").Pc("DateStart").Pc("DateEnd").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Mov_Wishlist
		public static void _Mov_Wishlist(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Name").Pc("WishType").Pc("IsActive").Pc("Content").Pc("DisplayOrder").Pc("Description").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Mov_Movie_Wishlist_Mapping
		public static void _Mov_Movie_Wishlist_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("WishId").Pc("MovieId").Pc("CreatedOn").Pc("DisplayOrder").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Delivery_Config
		public static void _Delivery_Config(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Key").Pc("Value").Pc("ValueType").Pc("Description").Pc("IsActive").Pc("Group").Pc("Published").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserBalanceRequest
		public static void Delivery_UserBalanceRequest(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("BalanceChange").Pc("Description").Pc("IsApproved").Pc("RequestType").Pc("CreatedOn").Pc("IsDeleted")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Mov_Category
		public static void _Mov_Category(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("DisplayOrder").Pc("IsActive").Pc("Description").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_SettingTemp
		public static void _Pos_SettingTemp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TypeId").Pc("UserId").Pc("RestaurantName").Pc("Value").Pc("IsShow")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Mov_Movie_Category_Mapping
		public static void _Mov_Movie_Category_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MovieId").Pc("CategoryId").Pc("CreatedBy").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Kitchen_Dish_Mapping
		public static void _Pos_Kitchen_Dish_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DishId").Pc("KitchenId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Kitchen
		public static void _Pos_Kitchen(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("PrintName").Pc("PrintIP").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserBalanceTransactions
		public static void Delivery_UserBalanceTransactions(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Description").Pc("ChangedBalance").Pc("UserId").Pc("ReferenceId").Pc("IsApproved").Pc("TransType").Pc("BalanceType").Pc("ModifyUser").Pc("IsActive").Pc("CreatedOn").Pc("Note")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Mov_Movie
		public static void _Mov_Movie(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("PhotoUrl").Pc("IsActive").Pc("TimeLength").Pc("Year").Pc("PartCount").Pc("Trash").Pc("MovieStatus").Pc("AvgRating").Pc("TotalComment").Pc("ContentShort").Pc("ContentShortEn").Pc("Content").Pc("ContentEn").Pc("Director").Pc("Actors").Pc("DisplayOrder").Pc("DateShow").Pc("MetaTitle").Pc("MetaDescription").Pc("Description").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Mov_Comment
		public static void _Mov_Comment(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ParentId").Pc("MovieId").Pc("UserId").Pc("Title").Pc("Content").Pc("TotalLike").Pc("TotalReplies").Pc("IsActive").Pc("Rating").Pc("Trash").Pc("Description").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Mov_Like
		public static void _Mov_Like(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ItemId").Pc("UserId").Pc("ItemType").Pc("CreatedOn").Pc("IsActive").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_VirtualDish
		public static void Delivery_VirtualDish(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("VirtualDeliveryId").Pc("DeliveryId").Pc("DishId").Pc("ResId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Actions
		public static void _Pos_Actions(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsMultiClick").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Roles
		public static void _Pos_Roles(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("Description").Pc("IsSystem").Pc("IsActive").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Functions_Actions_Mapping
		public static void _Pos_Functions_Actions_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FunctionId").Pc("ActionId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for TargetAudience
		public static void TargetAudience(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Name_En").Pc("DisplayOrder").Pc("Published")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCollection
		public static void DeliveryCollection(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameUrl").Pc("NameEn").Pc("ShortDescription").Pc("CreatedBy").Pc("CreatedOn").Pc("DisplayOrder").Pc("Picture").Pc("IsActive").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_RoleDetails
		public static void _Pos_RoleDetails(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RoleId").Pc("FunctionId").Pc("ActionId").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_FeaturedWishList
		public static void Res_FeaturedWishList(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ListId").Pc("Type").Pc("StartDate").Pc("EndDate").Pc("IsActive").Pc("DisplayOrder").Pc("AdsSponsor")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _FeaturedWishList_Type_Mapping
		public static void _FeaturedWishList_Type_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ListId").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_WorkShift
		public static void _Pos_WorkShift(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("RestaurantId").Pc("TimeStart").Pc("TimeEnd").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedOn").Pc("CreatedBy").Pc("ModifiedOn").Pc("ModifiedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Employee_WorkShift_mapping
		public static void _Pos_Employee_WorkShift_mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("WorkShiftId").Pc("RestaurantId").Pc("EmployeeId").Pc("IsDelete").Pc("CreatedOn").Pc("CreatedBy").Pc("ModifiedOn").Pc("ModifiedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_User_Reivew_Mapping
		public static void Res_User_Reivew_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Type").Pc("TargetId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Report_Delivery_DetailOrder
		public static void Report_Delivery_DetailOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("RestaurantId").Pc("OriginalCost").Pc("CommissionFoody").Pc("DeliveredTime").Pc("AddressShipping").Pc("CongNoPhaiThuPhatSinhTang").Pc("CongNoPhaiTraPhatSinhTang").Pc("CongNoPhaiThuPhatSinhGiam").Pc("CongNoPhaiTraPhatSinhGiam").Pc("ChenhLechCongNoPhaiThu").Pc("ChenhLechCongNoPhaiTra").Pc("TonDauKyCongNoPhaiThu").Pc("TonDauKyCongNoPhaiTra").Pc("TonCuoiKyCongNoPhaiThu").Pc("TonCuoiKyCongNoPhaiTra").Pc("CreatedOn").Pc("UpdatedOn").Pc("CNPThuPST_Extend").Pc("CNPTraPST_Extend").Pc("Reason").Pc("IsDeleted").Pc("RiskReceipt").Pc("RiskPayment")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for StateProvince
		public static void StateProvince(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("StateProvinceID").Pc("CountryID").Pc("Name").Pc("Abbreviation").Pc("DisplayOrder").Pc("UrlRewriteName").Pc("DisplayName").Pc("DisplayNameEn").Pc("Published").Pc("RegionId").Pc("Latitude").Pc("Longitude").Pc("RegionVn").Pc("IsAppDefault")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for __Res_FacebookPost
		public static void __Res_FacebookPost(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("PostId").Pc("Message").Pc("Picture").Pc("PictureId").Pc("CreatedOn").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_MenuTemplate
		public static void _Pos_MenuTemplate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsActive").Pc("Path").Pc("CssSuffix").Pc("ImageURL").Pc("Price").Pc("MenuId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_ChangeWorkShift
		public static void _Pos_ChangeWorkShift(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("EmployeeId").Pc("WorkShiftId").Pc("EmployeeIdTo").Pc("WorkShiftIdTo").Pc("ChangeDate").Pc("RestaurantId").Pc("IsDelete").Pc("CreatedOn").Pc("CreatedBy").Pc("ModifiedOn").Pc("ModifiedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for __Res_RestaurantComment
		public static void __Res_RestaurantComment(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReviewID").Pc("ReviewID").Pc("ReviewID").Pc("ReviewID").Pc("RestaurantID").Pc("RestaurantID").Pc("UserID").Pc("UserID").Pc("Title").Pc("Comment").Pc("CreatedOn").Pc("CreatedOn").Pc("CreatedOn").Pc("Food").Pc("Services").Pc("Atmosphere").Pc("Position").Pc("Price").Pc("Guest").Pc("MoneySpend").Pc("VisitAgain").Pc("SelectMenu").Pc("TotalComment").Pc("DisplayOrder").Pc("IsActive").Pc("IsFeatured").Pc("PostedByDevice").Pc("AvgRating").Pc("Trash").Pc("UpdatedOn").Pc("Tags").Pc("UpdatedByID").Pc("IsDraft").Pc("ReviewType").Pc("ReviewType").Pc("YoutubeCode").Pc("IsClosed").Pc("IsRecommended").Pc("RecommendedBy").Pc("RecommendedDate").Pc("TitleEN").Pc("CommentEN").Pc("SourceTranslator").Pc("IsAllowComment").Pc("IsPrivate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Employee
		public static void _Pos_Employee(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("EmployeeID").Pc("RegencyId").Pc("RestaurantID").Pc("Name").Pc("Gender").Pc("Birdthday").Pc("Phone").Pc("Email").Pc("Address").Pc("Description").Pc("WorkStatus").Pc("EmployeeStatus").Pc("IsActive").Pc("IsDelete").Pc("UserId").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("CurrentSalarylevelId").Pc("RoleId").Pc("Owner")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Currency
		public static void _Pos_Currency(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Province").Pc("Code").Pc("Name").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Email_Social_Mapping
		public static void Email_Social_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Email").Pc("LoginType").Pc("SocialId").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Dish_Schedule
		public static void Delivery_Dish_Schedule(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("StartDate").Pc("EndDate").Pc("IsActive").Pc("IsDefault").Pc("Type").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Dish_ScheduleItem
		public static void Delivery_Dish_ScheduleItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ScheduleId").Pc("DishId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Order
		public static void _Pos_Order(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("OrderID").Pc("TableID").Pc("UserID").Pc("EmployeeID").Pc("RestaurantID").Pc("MemberCardId").Pc("MemberCardCode").Pc("QtyAdults").Pc("QtyChildren").Pc("InDate").Pc("OutDate").Pc("DiscountPercent").Pc("DiscountCost").Pc("EcardPercent").Pc("ServicePercent").Pc("ServiceCost").Pc("VATPercent").Pc("VATCost").Pc("VATStatus").Pc("VATPrintDate").Pc("VATDescript").Pc("SubAmount").Pc("PayType").Pc("CardNo").Pc("PrintCount").Pc("OrderStatus").Pc("IsDelete").Pc("Description").Pc("DeleteNote").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("Code").Pc("OrderType").Pc("ReservationOrderId").Pc("ReservationCode").Pc("tableSplit").Pc("TotalAmount").Pc("GrossId").Pc("OrderNumber").Pc("Deposit").Pc("ReservationType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Social_SystemNotification
		public static void Social_SystemNotification(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Key").Pc("Title").Pc("Notification").Pc("CreatedOn").Pc("EndDate").Pc("IsActive").Pc("Type").Pc("NotificationEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _App_DiscountSection_Mapping
		public static void _App_DiscountSection_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CountryId").Pc("CityId").Pc("CategoryGroupId").Pc("SectionId").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _App_DiscountSection
		public static void _App_DiscountSection(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Name").Pc("NameEn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PhotoCollection_User_Mapping
		public static void Res_PhotoCollection_User_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CollectionId").Pc("UserId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for User_Place_Setting
		public static void User_Place_Setting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserId").Pc("PlaceId").Pc("IsHide").Pc("IsSubscribe")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_RawMaterialTypeSystem
		public static void _Pos_RawMaterialTypeSystem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("Name").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Blacklist
		public static void Res_Blacklist(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PlaceId").Pc("CreatedOn").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PhotoCollection_UserLike_Mapping
		public static void Res_PhotoCollection_UserLike_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CollectionId").Pc("UserId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Functions
		public static void _Pos_Functions(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("LangKeys").Pc("Keys").Pc("Description").Pc("IsActive").Pc("Group").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Dish_Price_mapping
		public static void _Pos_Dish_Price_mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DishId").Pc("RestaurantId").Pc("Price").Pc("DeliveryPrice").Pc("HomePrice").Pc("OriginPrice").Pc("FromDate").Pc("ToDate").Pc("IsDelete").Pc("CreatedOn").Pc("CreatedBy").Pc("ModifiedOn").Pc("ModifiedBy").Pc("IsApply")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_RawMaterialSystem
		public static void _Pos_RawMaterialSystem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupId").Pc("UnitId").Pc("Name").Pc("OldUnitPrice").Pc("NewUnitPrice").Pc("InventoryPrice").Pc("LastQty").Pc("Qty").Pc("UsedQty").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("LastPurchaseDate").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("Owner")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Department
		public static void _Pos_Department(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Support_Comment
		public static void _Pos_Support_Comment(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("IdSubjectSupport").Pc("Content").Pc("Image").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("DepartmentId").Pc("DepartmentAssignId").Pc("IdParent").Pc("IsHaveAnswer")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryLoginSession
		public static void DeliveryLoginSession(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("Token").Pc("CreatedOnUtc").Pc("ExpireDate").Pc("DeviceId").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Support_Subject
		public static void _Pos_Support_Subject(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Content").Pc("Image").Pc("DepartmentId").Pc("DepartmentAssignId").Pc("RestaurantId").Pc("IdStatus").Pc("CloseDate").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("IsActive").Pc("IsDelete").Pc("ReceivedBy").Pc("ReceivedOn").Pc("IsUnRead")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Support_Image
		public static void _Pos_Support_Image(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PhotoUrl").Pc("IdSubject").Pc("IdComment").Pc("IsActive").Pc("IsDelete").Pc("CreatedBy").Pc("CreatedOn").Pc("ModifiedBy").Pc("ModifiedOn").Pc("IsImageComment")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _CustomerBlackList
		public static void _CustomerBlackList(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Type").Pc("CreatedBy").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_PromotionDetail
		public static void _Pos_PromotionDetail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionID").Pc("Type").Pc("ReferenceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Promotions
		public static void _Pos_Promotions(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("Type").Pc("Formality").Pc("FromDate").Pc("ToDate").Pc("FromHour").Pc("ToHour").Pc("DayOfWeek").Pc("DiscountType").Pc("DistcountValue").Pc("IsActive").Pc("IsDelete").Pc("CreatedOn").Pc("CreatedBy").Pc("ModifiedBy").Pc("ModifiedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_KitchenPrinter
		public static void _Pos_KitchenPrinter(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ComputerUniqueId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_OffersTimeRange
		public static void Reservation_OffersTimeRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OfferId").Pc("DayOfWeek").Pc("CustomDate").Pc("TimeOpen").Pc("TimeClose").Pc("IsDayOff").Pc("Title").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_Order
		public static void Reservation_Order(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderNumber").Pc("ReservationResId").Pc("OfferId").Pc("Date").Pc("Time").Pc("AdultTotal").Pc("ChildrenTotal").Pc("DealTotal").Pc("Note").Pc("Status").Pc("UserInfo").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn").Pc("UpdatedBy").Pc("DeviceClientType").Pc("DeviceOSType").Pc("Type").Pc("IsPush").Pc("Rest").Pc("Adpayment").Pc("Total").Pc("TotalSentEmail").Pc("AdminNote").Pc("Commission")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_RestaurantOffers
		public static void Reservation_RestaurantOffers(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReservationId").Pc("LabelId").Pc("Title").Pc("ShortDescription").Pc("Description").Pc("StartDate").Pc("EndDate").Pc("CreatedOn").Pc("Price").Pc("DiscountValue").Pc("OfferText").Pc("MaxAdult").Pc("MaxChildren").Pc("MaxTable").Pc("DisplayOrder").Pc("IsActive").Pc("Note").Pc("IsDeleted").Pc("Commission").Pc("Type").Pc("IsFeature")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_ImportType
		public static void _Pos_ImportType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("LangKey")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_ImportResult
		public static void _Pos_ImportResult(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TypeId").Pc("RestaurantId").Pc("ImportDate").Pc("FileName").Pc("Success").Pc("Duplicate").Pc("Errors").Pc("DescriptionErrors").Pc("TotalRecord").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_SpecialAttr
		public static void Res_SpecialAttr(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PhotoCollection
		public static void Res_PhotoCollection(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameAscii").Pc("Status").Pc("IsPublic").Pc("TotalSave").Pc("TotalView").Pc("TotalItems").Pc("TotalLike").Pc("Description").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_PhotoCollectionItem
		public static void Res_PhotoCollectionItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CollectionId").Pc("PictureId").Pc("DisplayOrder").Pc("Description").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Biz_Project
		public static void Biz_Project(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ProjectName").Pc("ProjectDescr").Pc("DisplayOrder").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_EmployeeOffWork
		public static void _Pos_EmployeeOffWork(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("EmployeeId").Pc("WorkShiftId").Pc("DateOff").Pc("RestaurantId").Pc("IsDelete").Pc("EmployeeIdFillInFor").Pc("CreatedOn").Pc("CreatedBy").Pc("ModifiedOn").Pc("ModifiedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _Pos_Promotion_Restaurant_Mapping
		public static void _Pos_Promotion_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_PromotionNews
		public static void Delivery_PromotionNews(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("ShortDescription").Pc("Description").Pc("Image").Pc("RestaurantId").Pc("StartDate").Pc("EndDate").Pc("IsActive").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn").Pc("IsFeatured")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserOrderDetail
		public static void Delivery_UserOrderDetail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserOrderInfoId").Pc("OrderId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserOrderReport
		public static void Delivery_UserOrderReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CreatedOn").Pc("UpdatedOn").Pc("Total_New").Pc("Total_Old").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserOrderInfoHistory
		public static void Delivery_UserOrderInfoHistory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Phone").Pc("FullName").Pc("Address").Pc("CityId").Pc("DistrictId").Pc("IsVerifiedMap").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Order_Discount
		public static void Delivery_Order_Discount(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("DiscountId").Pc("Total").Pc("DiscountPercent").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_DiscountDescription
		public static void Delivery_DiscountDescription(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserOrderInfo
		public static void Delivery_UserOrderInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Phone").Pc("FullName").Pc("Address").Pc("CityId").Pc("DistrictId").Pc("IsVerifiedMap").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Biz_BannerGroup
		public static void Biz_BannerGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("BannerGroupName").Pc("BannerGroupKey").Pc("BannerGroupDescr").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Biz_Banner
		public static void Biz_Banner(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("BannerName").Pc("BannerKey").Pc("BannerDescr").Pc("BannerFilePath").Pc("BannerLink").Pc("BannerScript").Pc("BannerGroupId").Pc("StateProvinceId").Pc("ParentId").Pc("DisplayOrder").Pc("IsActive").Pc("CreatedOn").Pc("StartDate").Pc("EndDate").Pc("ReferenceId").Pc("ReferenceType").Pc("Template").Pc("CategoryGroupId").Pc("ClickUrl").Pc("ImpressionUrl")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CustomerRole
		public static void CustomerRole(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Active").Pc("IsSystemRole").Pc("SystemName").Pc("StateProvinceId").Pc("OnlyRegionId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Customer_CustomerRole_Mapping
		public static void Customer_CustomerRole_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Customer_Id").Pc("CustomerRole_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CustomerAttribute
		public static void CustomerAttribute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("Key").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CustomerExtension
		public static void CustomerExtension(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CustomerId").Pc("FirstName").Pc("LastName").Pc("Gender").Pc("TotalReviews").Pc("TotalPictures").Pc("TotalReviewedCities").Pc("VerifyingPercent").Pc("HistoryAvatar").Pc("TotalFirstReviews").Pc("TotalFriends").Pc("TotalLikedRestaurants").Pc("TotalCheckedInRestaurants").Pc("TotalViews").Pc("TotalPoints").Pc("TotalLists").Pc("Avatar").Pc("TotalCoupons").Pc("TotalLikedReviews").Pc("TotalPrivateLists").Pc("TotalCheckedin").Pc("Cover").Pc("AvatarStatus").Pc("MobileCover").Pc("SystemUpdatePreferences").Pc("TrustPercent").Pc("TotalFollowers").Pc("TotalOrderDelivered").Pc("TotalOrderCancelled").Pc("TotalOrderQuit").Pc("TotalOrderValue").Pc("AllowCashback")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MessageTemplate
		public static void MessageTemplate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("BccEmailAddresses").Pc("Subject").Pc("Body").Pc("IsActive").Pc("EmailAccountId").Pc("PlainText")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_Category_Mapping
		public static void Res_Restaurant_Category_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantID").Pc("CategoryID").Pc("Flag")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_Cuisine_Mapping
		public static void Res_Restaurant_Cuisine_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantID").Pc("CuisineID").Pc("Flag")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for SystemDish
		public static void SystemDish(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("NameUrl").Pc("Description").Pc("PhotoUrl").Pc("Price").Pc("TotalView").Pc("DisplayOrder").Pc("TypeId").Pc("CategoryId").Pc("CreatedOn").Pc("UpdatedOn").Pc("IsFeatured").Pc("IsActive").Pc("CreatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for QueuedEmail
		public static void QueuedEmail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Priority").Pc("From").Pc("FromName").Pc("To").Pc("ToName").Pc("CC").Pc("Bcc").Pc("Subject").Pc("Body").Pc("CreatedOnUtc").Pc("SentTries").Pc("SentOnUtc").Pc("EmailAccountId").Pc("PlainText").Pc("msrepl_tran_version")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantPicture
		public static void Res_RestaurantPicture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantPictureID").Pc("RestaurantPictureID").Pc("RestaurantPictureID").Pc("AlbumID").Pc("AlbumID").Pc("UserID").Pc("UserID").Pc("UserID").Pc("UserID").Pc("RestaurantID").Pc("RestaurantID").Pc("RestaurantID").Pc("RestaurantID").Pc("PhotoUrl").Pc("PhotoUrl").Pc("PictureID").Pc("DisplayOrder").Pc("CreatedOn").Pc("CreatedOn").Pc("PostedByDevice").Pc("ReviewID").Pc("ReviewID").Pc("Name").Pc("Name").Pc("PredefineAlbumID").Pc("PredefineAlbumID").Pc("TotalLikes").Pc("IsDraft").Pc("IsDraft").Pc("IsDraft").Pc("IsDraft").Pc("IsDraft").Pc("TokenKey").Pc("TotalComments").Pc("OriginalWidth").Pc("OriginalWidth").Pc("OriginalHeight").Pc("OriginalHeight").Pc("IsExisted").Pc("CheckinId").Pc("CheckinId").Pc("TotalViews").Pc("IsPopular").Pc("ShowOnHomePage").Pc("CreatedBy").Pc("BgColor").Pc("msrepl_tran_version")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Reservation_WasObtained
		public static void Reservation_WasObtained(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReservationResId").Pc("CreatedOn").Pc("CreatedByUserId").Pc("UpdatedOn").Pc("UpdatedByUserId").Pc("Date").Pc("Money").Pc("Descriptiion")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_DeputyUserInfo
		public static void Delivery_DeputyUserInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("UserName").Pc("Email").Pc("Phone")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Biz_Customer_Role_Mapping
		public static void Biz_Customer_Role_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Customer_Id").Pc("CustomerRole_Id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_UserOrderDay
		public static void Delivery_UserOrderDay(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Phone").Pc("TotalAmount").Pc("Counts").Pc("DeliveredTime")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_PaymentEmployeesSetting
		public static void Delivery_PaymentEmployeesSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("CreatedOn").Pc("UpdatedOn").Pc("DebitBalance").Pc("CreditBalance").Pc("TypeId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMenuItem
		public static void DeliveryMenuItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupId").Pc("DishId").Pc("RestaurantId").Pc("IsFeature").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryRestaurantItem
		public static void DeliveryRestaurantItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupId").Pc("RestaurantId").Pc("IsFeature").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ScheduleTask
		public static void ScheduleTask(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ProjectType").Pc("Name").Pc("Seconds").Pc("Type").Pc("Enabled").Pc("StopOnError").Pc("LastStartUtc").Pc("LastEndUtc").Pc("LastSuccessUtc")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_PaymentEmployees
		public static void Delivery_PaymentEmployees(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("TotalOrder").Pc("DeliveredTime").Pc("Risk").Pc("RiskPence").Pc("OriginalOrderCost").Pc("ServiceCost").Pc("ShipOrderCost").Pc("ReceivableOther").Pc("Commission").Pc("ShipCustomerCost").Pc("PayOther").Pc("TotalReceivable").Pc("CommissionFoody").Pc("Discount").Pc("IsPaid_Emp").Pc("Paid_Emp").Pc("PaidEdit_Emp").Pc("LongerPay_Emp").Pc("Pay_Emp_Finished").Pc("NotePaid_Emp").Pc("IsReceived_Acc").Pc("Receivable_Acc").Pc("ReceivedEdit_Acc").Pc("Receivable_Acc_Finished").Pc("LongerReceivable_Acc").Pc("NoteReceivable_Acc").Pc("CreatedOn").Pc("UpdatedOn").Pc("IsDeleted").Pc("Received_Changed").Pc("Paid_Changed").Pc("IsExportReceipt").Pc("IsExportPayment").Pc("Note")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryRestaurantGroup
		public static void DeliveryRestaurantGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Key").Pc("Name").Pc("StartDate").Pc("EndDate").Pc("IsActive").Pc("IsDefault").Pc("IsLoop").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMenuGroup
		public static void DeliveryMenuGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Key").Pc("Name").Pc("StartDate").Pc("EndDate").Pc("IsActive").Pc("IsLoop").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryShipingInfoLabel
		public static void DeliveryShipingInfoLabel(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("ShippingInfoId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Accountant_VoucherNumber
		public static void Delivery_Accountant_VoucherNumber(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DatePrint").Pc("Number").Pc("VoucherType").Pc("CreatedOn").Pc("CityId").Pc("TypeReportId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Accountant_VoucherSetting
		public static void Delivery_Accountant_VoucherSetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CreatedOn").Pc("UpdatedOn").Pc("OpeningStock").Pc("CityId").Pc("TypeReportId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Accountant_Receipt_Payment_Voucher
		public static void Delivery_Accountant_Receipt_Payment_Voucher(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("VoucherType").Pc("Number").Pc("DatePrint").Pc("FromDate").Pc("ToDate").Pc("Debit").Pc("Credit").Pc("FullName").Pc("Address").Pc("Description").Pc("Amount").Pc("InWords").Pc("EnClosed").Pc("TotalAmountReceived_InWords").Pc("CreatedOn").Pc("UpdatedOn").Pc("OpeningStock").Pc("IsDeleted").Pc("Note").Pc("CityId").Pc("TypeReportId").Pc("TypeUserId").Pc("OpeningStockByUser").Pc("CreatedUserId").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Accountant_BranchInfo
		public static void Delivery_Accountant_BranchInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("Branch_Tax_Code").Pc("Branch_Director").Pc("Branch_Chief_Accountant").Pc("Branch_Address").Pc("Branch_Name").Pc("Branch_Cashier").Pc("Branch_Preparer").Pc("Branch_Email")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Accountant_GeneralSettingReport
		public static void Delivery_Accountant_GeneralSettingReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("FromDate").Pc("ToDate").Pc("TypeId").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryManReportLog
		public static void DeliveryManReportLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("OrderId").Pc("Risk").Pc("RiskPence").Pc("Commission").Pc("CommissionFoody").Pc("ShipOrderCost").Pc("ShipCustomerCost").Pc("OriginalOrderCost").Pc("PayType").Pc("ServiceCost").Pc("CreatedOn").Pc("DeliveredTime").Pc("IsFar").Pc("TotalReceivable").Pc("UpdatedOn").Pc("ReceivableOther").Pc("PayOther").Pc("Note").Pc("Discount").Pc("IsDeleted").Pc("ChangeReceivable").Pc("CommissionExtend").Pc("ShipCustomerCostExtend").Pc("IsPartTime").Pc("ParkingFee").Pc("DeliveryManTypeId").Pc("RestaurantId").Pc("DeliveryManContractTypeId").Pc("TotalPay_Res").Pc("NotePay_Res").Pc("ChangePay_Res").Pc("IsPay_Res").Pc("TotalReceivableOther").Pc("TotalReceivableCOD").Pc("DiscountForFoody").Pc("DiscountForRes").Pc("CommisionForDiscount").Pc("IsReceivable_Res").Pc("PaymentMethodId").Pc("ReceivableCash").Pc("GroupService").Pc("TotalAmount").Pc("_CommissionDefault").Pc("_CommissionPartime").Pc("_MinShip").Pc("_CommissionSupportShip").Pc("LstCommission").Pc("System_Note").Pc("Cs_Note").Pc("DeliveryFee").Pc("CoefficientShipFee").Pc("ShippingMethodId").Pc("_CommissionExpressDefault").Pc("_CommissionExpressPartime").Pc("_MinCommissionExpress").Pc("Distance").Pc("_ShipExpressDefault").Pc("_ShipExpressPartime").Pc("_MinShipExpress").Pc("IsFullShip").Pc("_PercentSupportShip").Pc("_PercentShip").Pc("_PercentShipPartTime").Pc("IsSupportShip").Pc("_PercentShipExpress").Pc("_PercentShipExpressPartTime").Pc("VATShipFee").Pc("StatusId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Report_Delivery_DetailOrderLog
		public static void Report_Delivery_DetailOrderLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("RestaurantId").Pc("OriginalCost").Pc("CommissionFoody").Pc("DeliveredTime").Pc("AddressShipping").Pc("CongNoPhaiThuPhatSinhTang").Pc("CongNoPhaiTraPhatSinhTang").Pc("CongNoPhaiThuPhatSinhGiam").Pc("CongNoPhaiTraPhatSinhGiam").Pc("ChenhLechCongNoPhaiThu").Pc("ChenhLechCongNoPhaiTra").Pc("TonDauKyCongNoPhaiThu").Pc("TonDauKyCongNoPhaiTra").Pc("TonCuoiKyCongNoPhaiThu").Pc("TonCuoiKyCongNoPhaiTra").Pc("CreatedOn").Pc("UpdatedOn").Pc("CNPThuPST_Extend").Pc("CNPTraPST_Extend").Pc("Reason").Pc("IsDeleted").Pc("RiskReceipt").Pc("RiskPayment")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DeliveryPromoCode_Restaurant_Mapping
		public static void _DeliveryPromoCode_Restaurant_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromoCodeId").Pc("RestaurantId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPromoCode_User_Mapping
		public static void DeliveryPromoCode_User_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromoCodeId").Pc("UserId").Pc("UsedOn").Pc("DeliveryOrderId").Pc("PhoneNumber")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Customer_Tmp
		public static void Customer_Tmp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerGuid").Pc("Username").Pc("Email").Pc("Password").Pc("PasswordFormatId").Pc("PasswordSalt").Pc("AdminComment").Pc("LanguageId").Pc("TimeZoneId").Pc("Active").Pc("Deleted").Pc("IsSystemAccount").Pc("SystemName").Pc("LastIpAddress").Pc("CreatedOnUtc").Pc("LastLoginDateUtc").Pc("LastActivityDateUtc").Pc("Signature").Pc("Point").Pc("LogInType").Pc("SocialID").Pc("FoodyId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Customer_Foody_Tmp
		public static void Customer_Foody_Tmp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerGuid").Pc("Username").Pc("Email").Pc("Password").Pc("PasswordFormatId").Pc("PasswordSalt").Pc("AdminComment").Pc("LanguageId").Pc("TimeZoneId").Pc("Active").Pc("Deleted").Pc("IsSystemAccount").Pc("SystemName").Pc("LastIpAddress").Pc("CreatedOnUtc").Pc("LastLoginDateUtc").Pc("LastActivityDateUtc").Pc("Signature").Pc("Point").Pc("LogInType").Pc("SocialID").Pc("FoodyId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for test1
		public static void test1(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ItemsId").Pc("ItemName").Pc("ItemsLanguageTextId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for test2
		public static void test2(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ItemsId").Pc("ItemName").Pc("ItemsLanguageTextId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryLastSync
		public static void DeliveryLastSync(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("LastSync").Pc("Type").Pc("NextItemId").Pc("APIType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_ApiLogObjectRequest
		public static void Delivery_ApiLogObjectRequest(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ObjectId").Pc("Type").Pc("ActionTries").Pc("CreatedOn").Pc("UpdatedOn").Pc("IsDeleted").Pc("Status").Pc("Message")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for LogError
		public static void LogError(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("CreatedOn").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_ResDishPicture
		public static void Delivery_ResDishPicture(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DishId").Pc("PhotoUrl").Pc("IsDefault")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishAttribute
		public static void Res_DishAttribute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("Description").Pc("CreatedBy").Pc("CreatedOn").Pc("IsActive").Pc("IsDeleted").Pc("DisplayOrder").Pc("PartnerAttributeId").Pc("NTop")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishAttributeMapping
		public static void Res_DishAttributeMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DishId").Pc("AttributeValueId").Pc("PriceAdjustment").Pc("IsRequired").Pc("ValidationMinSelect").Pc("ValidationMaxSelect").Pc("ConditionAttributeXml").Pc("CreatedBy").Pc("CreatedOn").Pc("ExtraPrice")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ActionElapsedLog
		public static void ActionElapsedLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ControllerName").Pc("ActionName").Pc("TotalSeconds").Pc("StartDate").Pc("EndDate").Pc("CreatedOn").Pc("Message")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Restaurant_Related
		public static void Delivery_Restaurant_Related(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DeliveryId").Pc("RelatedDeliveryID")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderStatusOrdinal
		public static void DeliveryOrderStatusOrdinal(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("StatusId").Pc("Name").Pc("Descrition").Pc("OrderNumber").Pc("OrderNumberForMerchant").Pc("CheckOutOfStock")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantExtension_Bak
		public static void Res_RestaurantExtension_Bak(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantId").Pc("TotalReviews").Pc("TotalPictures").Pc("TotalFavourites").Pc("TotalWanteds").Pc("TotalCheckins").Pc("TotalViews").Pc("AvgPositionPoints").Pc("AvgPricePoints").Pc("AvgFoodPoints").Pc("AvgAtmospherePoints").Pc("AvgServicePoints").Pc("AvgRating").Pc("StaticMapImg")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantExtension_Bak_1
		public static void Res_RestaurantExtension_Bak_1(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantId").Pc("TotalReviews").Pc("TotalPictures").Pc("TotalFavourites").Pc("TotalWanteds").Pc("TotalCheckins").Pc("TotalViews").Pc("AvgPositionPoints").Pc("AvgPricePoints").Pc("AvgFoodPoints").Pc("AvgAtmospherePoints").Pc("AvgServicePoints").Pc("AvgRating").Pc("StaticMapImg")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Category
		public static void Res_Category(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("IsActive").Pc("IsFeatured").Pc("UrlRewriteName").Pc("NameEn").Pc("IsPopular").Pc("Icon").Pc("CategoryGroupId").Pc("IconClass").Pc("RestaurantCount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_User_Mapping
		public static void Delivery_User_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DeliveryId").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for GoogleAPIKey
		public static void GoogleAPIKey(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GoogleKey").Pc("Quotas").Pc("LastUsed").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishType
		public static void Res_DishType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("TypeID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("NameEn").Pc("Description").Pc("pos_id").Pc("IsActive").Pc("IsDeleted").Pc("msrepl_tran_version")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for LogCall
		public static void LogCall(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Phone").Pc("CreatedOn").Pc("IP").Pc("Name").Pc("AgentId").Pc("CallStatus").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Dish
		public static void Res_Dish(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DishID").Pc("SystemDishId").Pc("PartnerDishId").Pc("Name").Pc("NameUrl").Pc("Description").Pc("RestaurantID").Pc("_TypeID").Pc("ImageURL").Pc("Price").Pc("TotalView").Pc("AvgRatingPoint").Pc("TotalRating").Pc("IsFeatured").Pc("IsActive").Pc("IsDeleted").Pc("CreatedOn").Pc("UpdatedOn").Pc("UserID").Pc("CategoryID").Pc("IsGlobal").Pc("DisplayOrder").Pc("PhotoUrl").Pc("Name_EN").Pc("IsDelivery").Pc("Status").Pc("UpdateBy").Pc("GlobalId").Pc("pos_id").Pc("msrepl_tran_version").Pc("ProjectType").Pc("TotalOrder").Pc("NTop")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_MessageSMS
		public static void Delivery_MessageSMS(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("BrandName").Pc("Phone").Pc("Message").Pc("CreatedOn").Pc("UUID").Pc("TypePush").Pc("Status").Pc("UpdatedOn").Pc("SentTries").Pc("StatusResponse").Pc("MessageStatus").Pc("StatusOrder").Pc("CustomerType").Pc("PublicIP").Pc("GroupId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPartner
		public static void DeliveryPartner(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PartnerId").Pc("Name").Pc("IsActive").Pc("IsDeleted")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Hr_PartTime_TimeRange
		public static void Hr_PartTime_TimeRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TimeFrom").Pc("TimeTo").Pc("StateProvinceId").Pc("IsDelete").Pc("Date").Pc("IsCustom")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Hr_PartTime_TimeRange_DeliveryMan_Mapping
		public static void Hr_PartTime_TimeRange_DeliveryMan_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("TimeRangeId").Pc("DeliveryManId").Pc("CreatedBy").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for PartnerLog
		public static void PartnerLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("CreatedOn").Pc("JsonContent").Pc("PartnerId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Hr_PartTime_TimRange_Schedule
		public static void Hr_PartTime_TimRange_Schedule(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TimeFrom").Pc("TimeTo")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryNote_bk
		public static void DeliveryNote_bk(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("Type").Pc("TemplateSMS")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Accountant_EmailInfo
		public static void Delivery_Accountant_EmailInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("SmtpEmail").Pc("SmtpDisplay").Pc("SmtpUserName").Pc("SmtpPassword").Pc("SmtpHost").Pc("SmtpPort").Pc("SmtpEnableSSL")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCustomerReportImage
		public static void DeliveryCustomerReportImage(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReportId").Pc("Image")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCustomerReport
		public static void DeliveryCustomerReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("OrderId").Pc("Status").Pc("AdminNote").Pc("CreatedBy").Pc("CreatedOn").Pc("CardSuffix").Pc("CSNote").Pc("Name").Pc("Email").Pc("Phone")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Department
		public static void HR_Department(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("GroupName").Pc("ModifiedDate").Pc("IsPublished")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for LocaleStringResource2
		public static void LocaleStringResource2(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("LanguageId").Pc("ResourceName").Pc("ResourceValue").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Employee
		public static void HR_Employee(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("EmployeeCode").Pc("NationalIDNumber").Pc("NationalIDCreatedDate").Pc("NationalIDIssuePlace").Pc("BirthDate").Pc("PlaceOfBirth").Pc("MaritalStatus").Pc("Gender").Pc("FirstName").Pc("LastName").Pc("FullName").Pc("Passport").Pc("PassportIssueDate").Pc("PassportExpiryDate").Pc("PassportIssuePlace").Pc("EthnicId").Pc("ReligionId").Pc("NationalId").Pc("CreatedDate").Pc("CreatedBy").Pc("UpdatedDate").Pc("UpdatedBy").Pc("Status").Pc("Note").Pc("Img").Pc("JobPositionId").Pc("DepartmentId").Pc("LocationId").Pc("ManagerId").Pc("ReporterId").Pc("ContractTypeId").Pc("WorkStatusId").Pc("TerminationReason").Pc("DateOfTermination").Pc("ContractNumber").Pc("ContractCreatedDate").Pc("ContractLength").Pc("OfficeId").Pc("BeginWorkDate").Pc("BankName").Pc("BankId").Pc("UserTrainerId").Pc("Salary")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOffer
		public static void DeliveryOffer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("Title").Pc("ShortDescription").Pc("Image").Pc("PromoCode").Pc("DetailUrl").Pc("ShowDate").Pc("StartDate").Pc("EndDate").Pc("IsActive").Pc("Type").Pc("CityId").Pc("DisplayOrder").Pc("ShowOnHomePage")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderSource
		public static void DeliveryOrderSource(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPaymentMethod
		public static void DeliveryPaymentMethod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("Description").Pc("IsActive").Pc("DisplayOrder").Pc("ApplyForWeb").Pc("ApplyForApp").Pc("ShippingBy").Pc("ServiceFee")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMilestoneFee
		public static void DeliveryMilestoneFee(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MappingId").Pc("MilestoneFrom").Pc("MilestoneTo").Pc("Fee").Pc("IsDeleted").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Religion
		public static void HR_Religion(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsPublished").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Ethnic
		public static void HR_Ethnic(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsPublished").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for LogMissedCall
		public static void LogMissedCall(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Phone").Pc("CreatedOn").Pc("IP").Pc("Name").Pc("AgentId").Pc("CallStatus").Pc("UserId").Pc("IsCompleted")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Contact
		public static void HR_Contact(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("EmployeeId").Pc("PhoneMain").Pc("PhoneOther").Pc("SkypeId").Pc("FaceBookLink").Pc("WorkEmail").Pc("PersonalEmail").Pc("PermanentAddress").Pc("PermanentCountryId").Pc("PermanentStateProvinceId").Pc("PermanentDistrictId").Pc("CurrentAddress").Pc("CurrentCountryId").Pc("CurrentStateProvinceId").Pc("CurrentDistrictId").Pc("EmergencyContactName").Pc("EmergencyRelationship").Pc("EmergencyEmail").Pc("EmergencyMobile").Pc("EmergencyAddress").Pc("Zalo").Pc("Viber")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Merchant_Category
		public static void Delivery_Merchant_Category(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("ImageUrl").Pc("IsDelete").Pc("IconClass")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Merchant_Category_Mapping
		public static void Delivery_Merchant_Category_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DeliveryId").Pc("MerchantCategoryId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPromoCode_ApplyDate
		public static void DeliveryPromoCode_ApplyDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionCodeId").Pc("StartDate").Pc("EndDate").Pc("Type").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for _DeliveryPromoCode_Location_Mapping
		public static void _DeliveryPromoCode_Location_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionCodeId").Pc("LocationId").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Dish_RestaurantPicture_Mapping
		public static void Res_Dish_RestaurantPicture_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DishId").Pc("ResPicId").Pc("ImageUrl").Pc("IsDefault").Pc("IsActive").Pc("CreatedBy").Pc("CreatedOn").Pc("Status").Pc("UpdatedBy").Pc("UpdatedOn").Pc("msrepl_tran_version")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Customer
		public static void Customer(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerGuid").Pc("Username").Pc("Email").Pc("Password").Pc("PasswordFormatId").Pc("PasswordSalt").Pc("AdminComment").Pc("LanguageId").Pc("TimeZoneId").Pc("Active").Pc("Deleted").Pc("IsSystemAccount").Pc("SystemName").Pc("LastIpAddress").Pc("CreatedOnUtc").Pc("LastLoginDateUtc").Pc("LastActivityDateUtc").Pc("Signature").Pc("Point").Pc("LogInType").Pc("SocialID").Pc("FoodyId").Pc("FoodyAppToken")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_EmployerCheckInLog
		public static void Delivery_EmployerCheckInLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("CreatedOn").Pc("ActionId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Order_Mapping
		public static void Delivery_Order_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("DeliveryId").Pc("SubTotal").Pc("PayTypeId").Pc("DeliveryCommission_Foody").Pc("DeliveryCommission_Restaurant").Pc("HasContract").Pc("VATCost").Pc("VATPercent").Pc("DeliveryCommissionCost_Foody").Pc("DeliveryCommissionCost_Restaurant").Pc("CreatedOn").Pc("UpdatedOn").Pc("CustomFee").Pc("CustomFeeName").Pc("DiscountRestaurant").Pc("DiscountName").Pc("HasCommissionOrder").Pc("Minimum").Pc("CommisionId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Setting_bk_22082016
		public static void Setting_bk_22082016(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Setting_bk
		public static void Setting_bk(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Value")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_JobPosition
		public static void HR_JobPosition(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Title").Pc("IsPublished")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Location
		public static void HR_Location(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("StateProvinceId").Pc("CountryId").Pc("IsPublished")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_ContractType
		public static void HR_ContractType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsPublished")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_WorkStatus
		public static void HR_WorkStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsPublished").Pc("IsWorking")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_RestaurantHadSentMail
		public static void Delivery_RestaurantHadSentMail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ResId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCommisionType
		public static void DeliveryCommisionType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsActive").Pc("IsDeleted")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CommisionPaymentType
		public static void CommisionPaymentType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCommisionLog
		public static void DeliveryCommisionLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Commision").Pc("PayType").Pc("Type").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressMerchantDeliManMapping
		public static void ExpressMerchantDeliManMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("WarehouseId").Pc("DeliveryManId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressMerchant
		public static void ExpressMerchant(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Status").Pc("AppId").Pc("DeliveryFeeRate").Pc("MaxDeliveryFee").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressOrderType
		public static void ExpressOrderType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressCommisionType
		public static void ExpressCommisionType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressCommisionMapping
		public static void ExpressCommisionMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MerchantId").Pc("Commision").Pc("Type").Pc("CommisionPaymentType").Pc("IsDeleted").Pc("CommisionMinFee")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressOrderDetail
		public static void ExpressOrderDetail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Name").Pc("Price").Pc("Qty").Pc("Unit").Pc("Width").Pc("Height").Pc("Weight").Pc("TotalPrice").Pc("PriceOriginal")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressOrderStatus
		public static void ExpressOrderStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ParentId").Pc("Name").Pc("DisplayOrder").Pc("Color").Pc("NameEn").Pc("IconClass").Pc("Code")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressOrderStatusLog
		public static void ExpressOrderStatusLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("StatusId").Pc("UserId").Pc("ReasonCode").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressMerchantWarehouse
		public static void ExpressMerchantWarehouse(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MerchantId").Pc("Name").Pc("FullAddress").Pc("PhoneNumber").Pc("Latitude").Pc("Longitude").Pc("DistrictId").Pc("CityId").Pc("ShippingInfoId").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPromoCode_MappingType
		public static void DeliveryPromoCode_MappingType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPromoCode_Mapping
		public static void DeliveryPromoCode_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromoCodeId").Pc("Value").Pc("MappingType").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedBy").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ServiceMapping
		public static void ServiceMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CountryId").Pc("CityId").Pc("ServiceType").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HomeFilter
		public static void HomeFilter(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("IdMap").Pc("Name").Pc("Name_En").Pc("Code").Pc("Alert").Pc("IsPos").Pc("Type").Pc("IsActive").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPromocode_ApplyTime
		public static void DeliveryPromocode_ApplyTime(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionCodeId").Pc("StartTime").Pc("EndTime").Pc("Type").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy").Pc("ApplyType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_Shift
		public static void DeliveryMan_Shift(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("StateProvinceId").Pc("TimeStart").Pc("TimeEnd").Pc("Description").Pc("IsParttime").Pc("IsActive").Pc("IsDelete").Pc("CreatedOn").Pc("CreatedBy").Pc("ModifiedOn").Pc("ModifiedBy").Pc("ParentId").Pc("DaysOfWeek").Pc("DisplayOrder").Pc("DayOff").Pc("DayOverTime").Pc("TimeStartExtension").Pc("TimeEndExtension")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_FixedShift_Mapping
		public static void DeliveryMan_FixedShift_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ShiftId").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_WorkShift
		public static void DeliveryMan_WorkShift(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("ShiftId").Pc("StartDateTime").Pc("EndDateTime").Pc("Status").Pc("IsDelete").Pc("CSNote").Pc("UpdatedBy").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOffer_Dish_Mapping
		public static void DeliveryOffer_Dish_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OfferId").Pc("DishId").Pc("SellPrice").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for CustomerAddress
		public static void CustomerAddress(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("FullName").Pc("Label").Pc("FullAddress").Pc("GoogleAddress").Pc("PhoneNumber").Pc("Email").Pc("DistrictId").Pc("CityId").Pc("Latitude").Pc("Longitude").Pc("IsVerified").Pc("IsPrimary").Pc("Status").Pc("Note").Pc("CreatedOn").Pc("UpdatedOn").Pc("LastUsed").Pc("ShippingInfoId").Pc("FoodyId").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryNote
		public static void DeliveryNote(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("Message_EN").Pc("Type").Pc("TemplateSMS").Pc("TemplateSMS1")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryShareCart
		public static void DeliveryShareCart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserGuid").Pc("DeliveryId").Pc("ShoppingCartId").Pc("ShareCode").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishReplace_Mapping
		public static void Res_DishReplace_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DishReplaceId").Pc("DishId").Pc("Priority").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreateBy").Pc("UpdateBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishReplace
		public static void Res_DishReplace(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("DishId").Pc("ShowCancel").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreateBy").Pc("UpdateBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Customer_Mapping
		public static void HR_Customer_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CustomerId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryShoppingCartItem
		public static void DeliveryShoppingCartItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ShoppingCartId").Pc("UserGuid").Pc("UserId").Pc("DeliveryId").Pc("DishId").Pc("AttributesXml").Pc("Qty").Pc("OriginalPrice").Pc("Price").Pc("FinalPrice").Pc("TotalPrice").Pc("Note").Pc("IsDone").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryShoppingCart
		public static void DeliveryShoppingCart(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("CreatedOn").Pc("UserId").Pc("TotalItems").Pc("TotalAmounts").Pc("DeliverType").Pc("DeliverTime").Pc("ShoppingInfoId").Pc("UpdatedOn").Pc("Type").Pc("ShareCode").Pc("DeliveryCost").Pc("Distance").Pc("EstimateTime").Pc("ConfirmMethod").Pc("IsVAT")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_DishAttributeValue
		public static void Res_DishAttributeValue(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AttributeId").Pc("Name").Pc("PriceDefault").Pc("DisplayOrder").Pc("CreatedBy").Pc("CreatedOn").Pc("IsActive").Pc("IsDeleted").Pc("IsGlobal").Pc("IsDelivery").Pc("MaxQty").Pc("PartnerAttributeValueId").Pc("Priority")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for IntegratedApplication
		public static void IntegratedApplication(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AppName").Pc("AppId").Pc("SecretKey").Pc("IsActive").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryUserConnection
		public static void DeliveryUserConnection(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ConnectId").Pc("UserId").Pc("CartId").Pc("DeliveryId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderAttribute
		public static void DeliveryOrderAttribute(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Price").Pc("Note").Pc("Type").Pc("UpdateOn").Pc("UserId").Pc("FullName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderPaymentCard
		public static void DeliveryOrderPaymentCard(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("ResultCode").Pc("Title").Pc("Message").Pc("RequestId").Pc("TransactionId").Pc("AuthorizeCode").Pc("CardType").Pc("CardNumber").Pc("Expiry").Pc("TransactionDate").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Biz_CustomerRole_City_Mapping
		public static void Biz_CustomerRole_City_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerRoleId").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Biz_LogChanges
		public static void Biz_LogChanges(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("ReferenceId").Pc("FromData").Pc("ToData").Pc("UserId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Dish_ApplyTime
		public static void Res_Dish_ApplyTime(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DishId").Pc("RestaurantId").Pc("FromDate").Pc("ToDate").Pc("StartTime").Pc("EndTime").Pc("IsDelete").Pc("IsActive").Pc("ModifiedOn").Pc("ModifiedBy").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPaymentLog
		public static void DeliveryPaymentLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TransactionId").Pc("Message").Pc("Success").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOperaterRatingOverview
		public static void DeliveryOperaterRatingOverview(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("UserId").Pc("Avg").Pc("TotalRating").Pc("LastRating")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPromoCode
		public static void DeliveryPromoCode(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Discount").Pc("Limit").Pc("LimitedPerUser").Pc("RemainingQty").Pc("MaxDiscountValue").Pc("MinOrderValue").Pc("Status").Pc("StartDate").Pc("EndDate").Pc("UserId").Pc("CreatedOn").Pc("CreatedUserId").Pc("UpdatedOn").Pc("UpdatedUserId").Pc("IsActive").Pc("Note").Pc("ApplyType").Pc("CodeType").Pc("PlatformApply").Pc("Type").Pc("FoodyStatus").Pc("PublishType").Pc("CorporateId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOperaterRating
		public static void DeliveryOperaterRating(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("UserId").Pc("Point").Pc("Comment").Pc("CreatedOn").Pc("CreatedBy").Pc("IsDeleted").Pc("Status")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCategory
		public static void DeliveryCategory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("IconUrl").Pc("ImageUrl").Pc("ParentCategoryId").Pc("IsActive").Pc("DisplayOrder").Pc("ShowOnCategory").Pc("ShowOnHomePage").Pc("UrlRewrite").Pc("CityId").Pc("CountryId").Pc("Type").Pc("Code")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Report
		public static void HR_Report(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReportFrom").Pc("ReportTo").Pc("Status").Pc("Data").Pc("Note").Pc("Type").Pc("CreatedOn").Pc("UpdatedOn").Pc("UpdatedBy").Pc("ReferenceId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryType
		public static void DeliveryType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantPhone
		public static void Res_RestaurantPhone(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantID").Pc("Name").Pc("Phone").Pc("IsPublic").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressOrderStatus_bk
		public static void ExpressOrderStatus_bk(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ParentId").Pc("Name").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPaymentToken
		public static void DeliveryPaymentToken(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Token").Pc("UserId").Pc("ExpireDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_OnlinePayment_BlackList
		public static void Delivery_OnlinePayment_BlackList(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("IsActive").Pc("CreateOn").Pc("UpdateOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPaymentTransaction
		public static void DeliveryPaymentTransaction(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("TransactionId").Pc("OrderId").Pc("CardNumber").Pc("CardType").Pc("Expiry").Pc("Success").Pc("ResultCode").Pc("RequestId").Pc("TransactionDate").Pc("AuthorizeCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryManReport_PaymentLog
		public static void DeliveryManReport_PaymentLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("OrderId").Pc("TotalPay_Res").Pc("NotePay_Res").Pc("ChangePay_Res").Pc("IsPay_Res").Pc("CreatedOn").Pc("UserUpdate").Pc("IsReceivable_Res")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Brand
		public static void Res_Brand(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("BrandID").Pc("Name").Pc("NameUrl").Pc("DisplayOrder").Pc("RestaurantHeadID").Pc("UrlRewriteName").Pc("CoverImage").Pc("Description").Pc("MetaTitle").Pc("MetaKeywords").Pc("MetaDescription").Pc("SharedImage").Pc("SharedMobileImage").Pc("ParentId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCategory_Cuisine_Mapping
		public static void DeliveryCategory_Cuisine_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CategoryId").Pc("CuisineId").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantCuisine
		public static void Res_RestaurantCuisine(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CuisineID").Pc("Name").Pc("NameUrl").Pc("ParentID").Pc("DisplayOrder").Pc("IsActive").Pc("IsFeatured").Pc("UrlRewriteName").Pc("NameEn").Pc("ShowAsRoot").Pc("IsPopular").Pc("HitCount").Pc("Icon").Pc("ImageUrl")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryShippingInfo
		public static void DeliveryShippingInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Name").Pc("Phone").Pc("RecipientName").Pc("RecipientPhone").Pc("WorkAddress").Pc("Address").Pc("CityId").Pc("DistrictId").Pc("GoogleAddress").Pc("Latitude").Pc("Longitude").Pc("Email").Pc("Note").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedUserId").Pc("UpdatedUserId").Pc("LastUsed").Pc("IsSuggest").Pc("IsVerifiedMap")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderItem
		public static void DeliveryOrderItem(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("DishId").Pc("DeliveryId").Pc("VirtualDeliveryId").Pc("UserId").Pc("OriginalPrice").Pc("Price").Pc("UnitPrice").Pc("Qty").Pc("Note").Pc("IsDone").Pc("IsCreateBySystem").Pc("SystemNote").Pc("UpdatedOn").Pc("UpdatedUserId").Pc("AttributesXml").Pc("TotalAttributePrice").Pc("Percent").Pc("Total").Pc("MerchantNote").Pc("OutOfStock")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Dish_TimeRange
		public static void Res_Dish_TimeRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DishId").Pc("RestaurantId").Pc("DayOffWeek").Pc("CustomDate").Pc("StartTime").Pc("EndTime").Pc("IsDayOff").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderTip
		public static void DeliveryOrderTip(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("UserId").Pc("EmployeeId").Pc("TipAmount").Pc("TransactionId").Pc("CreatedOn").Pc("ResultCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliverySettingHasTimeRange
		public static void DeliverySettingHasTimeRange(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Value").Pc("StartTime").Pc("EndTime").Pc("DayOfWeek").Pc("CustomDate").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryShipperStatus
		public static void DeliveryShipperStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("OrderId").Pc("Status").Pc("UpdatedOn").Pc("TypeOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_PaymentEmployeesSetting_Edit
		public static void Delivery_PaymentEmployeesSetting_Edit(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("PaymentSettingId").Pc("DebitBalance_Edit").Pc("CreditBalance_Edit").Pc("IsReceived").Pc("IsPaid").Pc("UpdatedOn").Pc("Note").Pc("NoteDebitBalance_Edit").Pc("NoteCreditBalance_Edit").Pc("UpdateUserId").Pc("TypeId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_PaymentEmployees_Finished
		public static void Delivery_PaymentEmployees_Finished(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Amount").Pc("DeliveredTime").Pc("CreatedOn").Pc("TypeId").Pc("SystemNote").Pc("TypeReportId").Pc("PaymentMethodId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Fee
		public static void Delivery_Fee(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("IsComputed").Pc("_Key")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Order_Mapping_Fee
		public static void Delivery_Order_Mapping_Fee(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("FeeId").Pc("Amount").Pc("TypeId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliverySetting
		public static void DeliverySetting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CountryId").Pc("CityId").Pc("KeyName").Pc("Value").Pc("Description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Express_ReportOrderShipperDetail_Daily
		public static void Express_ReportOrderShipperDetail_Daily(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("UserId").Pc("CityId").Pc("Commission").Pc("DeliveryFee").Pc("SubTotal").Pc("TotalAmount").Pc("PickAddress").Pc("DropAddress").Pc("LstFeeMapping").Pc("DeliveredTime").Pc("IsDeleted").Pc("CreatedOn").Pc("UpdatedOn").Pc("Sys_Note").Pc("Acc_Note").Pc("Cs_Note").Pc("ReceivableOther").Pc("Risk").Pc("RiskPence").Pc("PayOther").Pc("Discount").Pc("CommissionShipper").Pc("CommissionShipperExtend").Pc("IsPartTime").Pc("ParkingFee").Pc("_CommisionDefault").Pc("_CommisionPartime").Pc("_MinCommission").Pc("TotalReceivable").Pc("ChangeReceivable").Pc("TotalPayShipper").Pc("ShipCustomerCost").Pc("ShipCustomerCostExtend").Pc("ServiceCost").Pc("IsLocked").Pc("DeliveryManTypeId").Pc("DeliveryManContractTypeId").Pc("DeliveryManGroupService").Pc("Distance").Pc("_MinCommissionExpress").Pc("_MinShip").Pc("_MinShipExpress").Pc("_ShipExpressDefault").Pc("_ShipExpressPartime").Pc("IsFullShip").Pc("PayTypeId").Pc("DeliveryFeeOfSender").Pc("DeliveryFeeOfReceiver").Pc("_PercentShip").Pc("_PercentShipPartTime").Pc("_PercentShipExpress").Pc("_PercentShipExpressPartTime").Pc("DeliveryFeeReturned").Pc("StatusId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Express_ReportOrderShipper_Daily
		public static void Express_ReportOrderShipper_Daily(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("CityId").Pc("TotalOrder").Pc("DeliveredTime").Pc("CreatedOn").Pc("UpdatedOn").Pc("Sys_Note").Pc("Commission").Pc("DeliveryFee").Pc("SubTotal").Pc("TotalAmount").Pc("ReceivableOther").Pc("ChangeReceivable").Pc("TotalReceivable").Pc("Receivable_Edit").Pc("ReceivableRemain").Pc("Receivable_AccNote").Pc("Risk").Pc("RiskPence").Pc("Discount").Pc("ServiceCost").Pc("CommissionShipper").Pc("ShipCustomerCost").Pc("PayOther").Pc("ParkingFee").Pc("TotalPayShipper").Pc("PayShipper_Edit").Pc("PayShipperRemain").Pc("PayShipper_AccNote").Pc("IsReceived").Pc("IsPayShipper").Pc("IsExportReceipt").Pc("IsExportPayment")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressOrderStatusCommisionLog
		public static void ExpressOrderStatusCommisionLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("StatusId").Pc("UserId").Pc("Commision").Pc("CreatedOn").Pc("IsDelete")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_RestaurantExtension
		public static void Res_RestaurantExtension(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantId").Pc("TotalReviews").Pc("TotalPictures").Pc("TotalFavourites").Pc("TotalWanteds").Pc("TotalCheckins").Pc("TotalViews").Pc("AvgPositionPoints").Pc("AvgPricePoints").Pc("AvgFoodPoints").Pc("AvgAtmospherePoints").Pc("AvgServicePoints").Pc("AvgRating").Pc("StaticMapImg")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderImage
		public static void DeliveryOrderImage(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Img").Pc("CreatedBy").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliverymanLogWork
		public static void DeliverymanLogWork(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DateCheckin").Pc("DateCheckout").Pc("UserId").Pc("IsCheck")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant_Url
		public static void Res_Restaurant_Url(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("RestaurantId").Pc("UrlRewriteName").Pc("CityId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCommision
		public static void DeliveryCommision(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("CommisionForFoody").Pc("DiscountByFoody").Pc("DiscountByFoodyOnComs").Pc("DiscountByFoodyOwner").Pc("DiscountByRes").Pc("PayType").Pc("Type").Pc("ValueType").Pc("IsDeleted").Pc("StartDate").Pc("EndDate").Pc("Priority").Pc("Commision").Pc("CommisionForDiscount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Push_Log
		public static void Delivery_Push_Log(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Message").Pc("CreateDate").Pc("Token").Pc("Device").Pc("UriPush").Pc("UserId").Pc("OrderId").Pc("Distance").Pc("NumberPush").Pc("MessageId").Pc("IsViewed")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_PendingShipLog
		public static void DeliveryMan_PendingShipLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Description").Pc("CreatedOn").Pc("IdSosType").Pc("IsDelete").Pc("PendingTime")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_WorkShift_Note
		public static void DeliveryMan_WorkShift_Note(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CreatedBy").Pc("DeliManId").Pc("Note").Pc("CreatedOn").Pc("Deleted").Pc("UpdatedBy").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Force_Checkout_Push_Log
		public static void Force_Checkout_Push_Log(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("UserId").Pc("IsUpdated").Pc("CreateDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_SosType
		public static void DeliveryMan_SosType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TypeName").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DishType_ResDish_Mapping
		public static void DishType_ResDish_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TypeId").Pc("DishId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Res_Restaurant
		public static void Res_Restaurant(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("RestaurantID").Pc("RestaurantID").Pc("RestaurantID").Pc("RestaurantID").Pc("RestaurantID").Pc("RestaurantID").Pc("SheisId").Pc("RestaurantCode").Pc("BrandID").Pc("UserID").Pc("Name").Pc("Name_EN").Pc("NameUrl").Pc("NameUrl_EN").Pc("Address").Pc("CityID").Pc("CityID").Pc("CityID").Pc("CityID").Pc("DistrictID").Pc("AreaID").Pc("AreaID").Pc("Phone").Pc("Fax").Pc("Email").Pc("Website").Pc("Logo").Pc("EstablishYear").Pc("CapacityAdult").Pc("CapacityChild").Pc("WaitingTimeMin").Pc("WaitingTimeMax").Pc("PriceMin").Pc("PriceMax").Pc("NearTo").Pc("AccessGuide").Pc("Latitude").Pc("Longtitude").Pc("IsActive").Pc("IsActive").Pc("IsActive").Pc("IsActive").Pc("IsActive").Pc("IsDelete").Pc("IsDelete").Pc("IsDelete").Pc("IsDelete").Pc("IsDelete").Pc("CreatedOn").Pc("UpdatedOn").Pc("RestaurantStatus").Pc("RestaurantStatus").Pc("RestaurantStatus").Pc("RestaurantStatus").Pc("ShortDesc").Pc("ShortDesc_EN").Pc("Description").Pc("Description_EN").Pc("MetaTitle").Pc("MetaTitle_EN").Pc("MetaKeywords").Pc("MetaKeywords_EN").Pc("MetaDescription").Pc("MetaDescription_EN").Pc("DisplayOrder").Pc("Faqs").Pc("SaleStatus").Pc("Holidays").Pc("UpdatedByID").Pc("BackgroundUrl").Pc("LastReceiveTime").Pc("SpecialDesc").Pc("UrlRewriteName").Pc("OldUrlRewriteName").Pc("Languages").Pc("TierID").Pc("Alias").Pc("StreetID").Pc("MobileImageUrl").Pc("IsDraft").Pc("IsDraft").Pc("IsDraft").Pc("CurrentViewers").Pc("DisplayTemplateId").Pc("CompanyId").Pc("BonusCurrentViewers").Pc("IsFeatured").Pc("Picture").Pc("IsBooking").Pc("Fanpage").Pc("ReviewOption").Pc("IsDisableReview").Pc("FanpageAvatar").Pc("FanpageName").Pc("ApprovedBy").Pc("ApprovedOn").Pc("IsVerifiedMap").Pc("LatestActivityDate").Pc("RedirectId").Pc("IsShowWifi").Pc("IsHalal").Pc("SpecialAttr").Pc("MobileBgColor").Pc("msrepl_tran_version").Pc("DeliveryOnly")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for She_PlaceProductExtension
		public static void She_PlaceProductExtension(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("DishId").Pc("CompanyId").Pc("ProductMasterId").Pc("Color").Pc("MainColorId").Pc("TextureId").Pc("Size").Pc("ShortDescription").Pc("ProductionDate").Pc("ExpiryDate").Pc("Ingredient").Pc("ToolId").Pc("HowToUse").Pc("Note").Pc("KeyWord")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Customer_Phone_Mapping
		public static void Customer_Phone_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Number").Pc("CountryPrefix").Pc("NationalNumber").Pc("IsVerified").Pc("VerifiedId").Pc("Type").Pc("CreatedOn").Pc("UpdatedOn").Pc("Primary").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_GroupUser
		public static void Delivery_GroupUser(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_News
		public static void Delivery_News(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Description").Pc("DescriptionEN").Pc("LstCityId").Pc("LstGroupUser").Pc("IsActive").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedBy").Pc("LogUserIdChange").Pc("IsDeleted").Pc("StatusPush").Pc("UrlRewriteName").Pc("NameUrl").Pc("CategoryId").Pc("GroupService")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for NowServiceRootCategory
		public static void NowServiceRootCategory(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ParentId").Pc("Name").Pc("NameEn").Pc("DisplayOrder").Pc("Status").Pc("SearchPlaceHolder").Pc("SearchPlaceHolder_En").Pc("Code").Pc("SettingKey")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_EmloyeeLog
		public static void HR_EmloyeeLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Field").Pc("FromValue").Pc("ToValue").Pc("FromValueText").Pc("ToValueText").Pc("CreatedOn").Pc("CreatedBy").Pc("CreatedByName")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Checkin_Checkout_Log
		public static void Delivery_Checkin_Checkout_Log(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("DeliveryMan_WorkShift_Id").Pc("DateTimeCheckin").Pc("DateTimeCheckout").Pc("IsCheckout")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryLogSync
		public static void DeliveryLogSync(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ObjectId").Pc("TypeName").Pc("ObjectName").Pc("LastSync")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Accountant_VoucherUserAlias
		public static void Delivery_Accountant_VoucherUserAlias(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("Alias").Pc("CreatedUserId").Pc("CreatedOn").Pc("IsDelete")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_Bank
		public static void HR_Bank(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("IsPublished").Pc("DisplayOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_ShippingMethod_Mapping
		public static void Delivery_ShippingMethod_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ShippingMethodId").Pc("DeliveryId").Pc("DeliveryFee").Pc("MinServiceTime").Pc("MaxServiceTime").Pc("IsDeleted").Pc("Priority")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCorporate
		public static void DeliveryCorporate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CompanyName").Pc("CompanyAddress").Pc("CompanyPhone").Pc("Usable").Pc("Used").Pc("Remaining").Pc("Commission").Pc("TotalAmount").Pc("PrepayAmount").Pc("RestAmount").Pc("StartDate").Pc("EndDate").Pc("Status").Pc("Note").Pc("CreatedBy").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCorporateTransaction
		public static void DeliveryCorporateTransaction(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CorporateId").Pc("OldValue").Pc("NewValue").Pc("CreatedBy").Pc("CreatedOn").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCategory_NowServiceRootCategory_Mapping
		public static void DeliveryCategory_NowServiceRootCategory_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("NowServiceRootCategoryId").Pc("DeliveryCategoryId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCorporateGroup_Customer_Mapping
		public static void DeliveryCorporateGroup_Customer_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("GroupId").Pc("IsApprove").Pc("IsDelete")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryShippingMethod
		public static void DeliveryShippingMethod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("NameEn").Pc("Description").Pc("DisplayOrder").Pc("Status").Pc("SettingKey").Pc("Default")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for NowServiceRootCategory_City_Mapping
		public static void NowServiceRootCategory_City_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("RootCategoryId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_HubShipper
		public static void Delivery_HubShipper(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("Name").Pc("Address").Pc("GoogleAddress").Pc("Lat").Pc("Lng").Pc("IsActive").Pc("IsDeleted").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan
		public static void DeliveryMan(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("CurrentDetailId").Pc("StatusId").Pc("CreatedOn").Pc("CurrentPrinterId").Pc("CurrentLatitude").Pc("CurrentLongitude").Pc("IsOnline").Pc("TypeId").Pc("UpdatedLocationOn").Pc("IsDeleted").Pc("UpdatedHandleOrder").Pc("WorkShift").Pc("CityId").Pc("Equip").Pc("IsRequested").Pc("CashBook").Pc("SoundSettingId").Pc("TypeOrder").Pc("GroupService").Pc("MaxOrderHandle").Pc("NoteCoordinator").Pc("NumberPushCurrent").Pc("TrainingType").Pc("VehicleType").Pc("PushSettingId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Payment_Log
		public static void Payment_Log(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderMomo").Pc("UserId").Pc("OrderId").Pc("Message").Pc("PaymentType").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ReportOptionInputType
		public static void ReportOptionInputType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("AppCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ReportOption
		public static void ReportOption(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Name_En").Pc("Description").Pc("InputType").Pc("ParentId").Pc("DispalyOrder").Pc("Deleted")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ReportOptionMapping
		public static void ReportOptionMapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ReportId").Pc("OptionId").Pc("OptionTextValue").Pc("CreatedOn").Pc("CreatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_CallCenterBookShipper
		public static void Delivery_CallCenterBookShipper(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ShipperId").Pc("OrderId").Pc("CallCenterId").Pc("IsDeleted").Pc("CreatedOn").Pc("Note")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressMerchant_User_Mapping
		public static void ExpressMerchant_User_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MerchantId").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for SystemAddressType
		public static void SystemAddressType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_CallCenter_Customer_Mapping
		public static void Delivery_CallCenter_Customer_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CustomerId").Pc("GroupShiftId").Pc("GroupId").Pc("AdminGroupType").Pc("IsDeleted").Pc("CreateBy").Pc("CreateOn").Pc("UpdateBy").Pc("UpdateOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Express_MessageSMS
		public static void Express_MessageSMS(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("BrandName").Pc("Phone").Pc("Message").Pc("CreatedOn").Pc("UUID").Pc("TypePush").Pc("Status").Pc("UpdatedOn").Pc("SentTries").Pc("StatusResponse").Pc("MessageStatus").Pc("StatusOrder").Pc("CustomerType").Pc("PublicIP")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderAlertConfirm
		public static void DeliveryOrderAlertConfirm(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("EstimateDeliveryTime").Pc("PushTries").Pc("UserOrderId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryManReport
		public static void DeliveryManReport(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("OrderId").Pc("Risk").Pc("RiskPence").Pc("Commission").Pc("CommissionFoody").Pc("ShipOrderCost").Pc("ShipCustomerCost").Pc("OriginalOrderCost").Pc("PayType").Pc("ServiceCost").Pc("CreatedOn").Pc("DeliveredTime").Pc("IsFar").Pc("TotalReceivable").Pc("UpdatedOn").Pc("ReceivableOther").Pc("PayOther").Pc("Note").Pc("Discount").Pc("IsDeleted").Pc("ChangeReceivable").Pc("CommissionExtend").Pc("ShipCustomerCostExtend").Pc("IsPartTime").Pc("ParkingFee").Pc("TotalPay_Res").Pc("NotePay_Res").Pc("ChangePay_Res").Pc("IsPay_Res").Pc("TotalReceivableOther").Pc("TotalReceivableCOD").Pc("DiscountForFoody").Pc("DiscountForRes").Pc("CommisionForDiscount").Pc("IsReceivable_Res").Pc("PaymentMethodId").Pc("RestaurantId").Pc("DeliveryManTypeId").Pc("DeliveryManContractTypeId").Pc("ReceivableCash").Pc("GroupService").Pc("TotalAmount").Pc("_CommissionDefault").Pc("_CommissionPartime").Pc("_MinShip").Pc("_CommissionSupportShip").Pc("LstCommission").Pc("System_Note").Pc("Cs_Note").Pc("DeliveryFee").Pc("CoefficientShipFee").Pc("ShippingMethodId").Pc("_CommissionExpressDefault").Pc("_CommissionExpressPartime").Pc("_MinCommissionExpress").Pc("Distance").Pc("_ShipExpressDefault").Pc("_ShipExpressPartime").Pc("_MinShipExpress").Pc("IsLocked").Pc("IsFullShip").Pc("_PercentSupportShip").Pc("_PercentShip").Pc("_PercentShipPartTime").Pc("IsSupportShip").Pc("_PercentShipExpress").Pc("_PercentShipExpressPartTime").Pc("VATShipFee").Pc("StatusId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCorporate_Customer_Mapping
		public static void DeliveryCorporate_Customer_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CorporateId").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderLog
		public static void DeliveryOrderLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Message").Pc("OrdinalOrder").Pc("OrdinalOrderItem")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_EmployeeExtension
		public static void HR_EmployeeExtension(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CustomerId").Pc("FirstName").Pc("LastName").Pc("Gender").Pc("Avatar").Pc("TotalVerified").Pc("TotalComfirmed").Pc("TotalAssigned").Pc("TotalDenied").Pc("TotalIncharge").Pc("TotalDelivered")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCorporateGroup
		public static void DeliveryCorporateGroup(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupName").Pc("NameRewrite").Pc("Description").Pc("UserId").Pc("CreatedOn").Pc("CorporateId").Pc("IsDelete")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryCorporateGroup_Promocode_Mapping
		public static void DeliveryCorporateGroup_Promocode_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CorporateGroupId").Pc("PromocodeId").Pc("UserId").Pc("IsDelete").Pc("CreateOn").Pc("UpdateOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPaymentMethod_DeviceOSType_Mapping
		public static void DeliveryPaymentMethod_DeviceOSType_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PaymentMethodId").Pc("DeviceOSType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_RequestOrderWithDistrict
		public static void DeliveryMan_RequestOrderWithDistrict(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("DistrictId").Pc("StreetIdList").Pc("IsDeleted").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HomeMessage
		public static void HomeMessage(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("TitleEN").Pc("Message").Pc("MessageEN").Pc("Key").Pc("IsActive").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressDeliveryBusy
		public static void ExpressDeliveryBusy(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("MasterRootId").Pc("Title").Pc("TitleEn").Pc("CustomMessage").Pc("MessageEN").Pc("Estimate").Pc("StartDate").Pc("EndDate").Pc("Type").Pc("PlatformApply").Pc("CreatedOn").Pc("CreatedBy").Pc("ImageUrl")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryBusy
		public static void DeliveryBusy(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("CityId").Pc("Title").Pc("TitleEn").Pc("CustomMessage").Pc("MessageEN").Pc("Estimate").Pc("StartDate").Pc("EndDate").Pc("Type").Pc("PlatformApply").Pc("MasterRootApply").Pc("CategoryApply").Pc("CreatedOn").Pc("CreatedBy").Pc("ImageUrl")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HomeFilter_NowServiceRoot_Mapping
		public static void HomeFilter_NowServiceRoot_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("ID").Pc("HomeFilterId").Pc("NowServiceRootId").Pc("DisplayOrder").Pc("Active")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Express_ReportRestaurant_Setting
		public static void Express_ReportRestaurant_Setting(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("MerchantId").Pc("WarehouseId").Pc("TonDauKyCongNoPhaiThu").Pc("TonDauKyCongNoPhaiTra").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Express_ReportRestaurant
		public static void Express_ReportRestaurant(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("MerchantId").Pc("WarehouseId").Pc("PickMoney").Pc("ShipCostMerchant").Pc("CommissionFoody").Pc("DeliveredTime").Pc("AddressShipping").Pc("CongNoPhaiThuPhatSinhTang").Pc("CongNoPhaiTraPhatSinhTang").Pc("CongNoPhaiThuPhatSinhGiam").Pc("CongNoPhaiTraPhatSinhGiam").Pc("ChenhLechCongNoPhaiThu").Pc("ChenhLechCongNoPhaiTra").Pc("TonCuoiKyCongNoPhaiThu").Pc("TonCuoiKyCongNoPhaiTra").Pc("CreatedOn").Pc("UpdatedOn").Pc("CNPThuPST_Extend").Pc("CNPTraPST_Extend").Pc("Reason").Pc("IsDeleted").Pc("RiskReceipt").Pc("RiskPayment").Pc("CityId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryMan_PushAutoLog
		public static void DeliveryMan_PushAutoLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("StatusId").Pc("CurrentLatitude").Pc("CurrentLongitude").Pc("IsOnline").Pc("TypeId").Pc("WorkShift").Pc("CityId").Pc("GroupService").Pc("MaxOrderHandle").Pc("NumberPushCurrent").Pc("EmployeeStatus").Pc("TypeNotSelected").Pc("OrderId").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressOrderLog
		public static void ExpressOrderLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ExpressOrderId").Pc("Message").Pc("OrdinalOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressManLevelIncome
		public static void ExpressManLevelIncome(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("Type").Pc("FromNumberOrder").Pc("ToNumberOrder").Pc("Amount").Pc("IsDelete").Pc("IsActive").Pc("GroupService").Pc("DeliManType").Pc("CreateOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Express_ReportShipperIncome
		public static void Express_ReportShipperIncome(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("FromDate").Pc("ToDate").Pc("LevelAmount").Pc("TotalOrder").Pc("TotalAmount").Pc("IsPaid").Pc("Note").Pc("SystemNote").Pc("CreatedUserId").Pc("PayAmountOther").Pc("GroupService").Pc("DeliManType").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Report_CC_Accountant
		public static void Delivery_Report_CC_Accountant(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Amount").Pc("CCNote").Pc("AccountantNote").Pc("StatusId").Pc("CreatedUserId").Pc("UpdatedUserId").Pc("CreatedOn").Pc("UpdatedOn").Pc("IsDelete").Pc("DeliveryTime")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_ConfigBonusOrder
		public static void HR_ConfigBonusOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("GroupService").Pc("DeliManType").Pc("BonusType").Pc("BonusValue").Pc("StartTime").Pc("EndTime").Pc("RunType").Pc("IsActive").Pc("IsDeleted").Pc("CreatedOn").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryNowReport_Realtime
		public static void DeliveryNowReport_Realtime(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Metric").Pc("Region").Pc("Country").Pc("DateReport").Pc("ValueReport").Pc("CreatedDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryNowReport_Monthly
		public static void DeliveryNowReport_Monthly(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Metric").Pc("Region").Pc("Country").Pc("DateReport").Pc("ValueReport").Pc("CreatedDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryNowReport_Daily
		public static void DeliveryNowReport_Daily(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Metric").Pc("Region").Pc("Country").Pc("DateReport").Pc("ValueReport").Pc("CreatedDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryNowReport_OperationStat
		public static void DeliveryNowReport_OperationStat(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Country").Pc("DateReport").Pc("OperationName").Pc("ValueReport").Pc("CreatedDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_ConfigBonusOrder_bk
		public static void HR_ConfigBonusOrder_bk(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("CityId").Pc("GroupService").Pc("DeliManType").Pc("BonusType").Pc("BonusValue").Pc("StartTime").Pc("EndTime").Pc("RunType").Pc("IsActive").Pc("IsDeleted").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ConfirmMethod
		public static void ConfirmMethod(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ResourceName").Pc("Price").Pc("Type").Pc("Color").Pc("IsActive")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for AppTracking
		public static void AppTracking(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Category").Pc("Action").Pc("Label").Pc("LabelUnsigned").Pc("AppType").Pc("AppTypeName").Pc("OSType").Pc("AppTypeCategory").Pc("CityId").Pc("DeviceId").Pc("DeviceUDID").Pc("CreatedOn").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderItemCompleted
		public static void DeliveryOrderItemCompleted(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("DishId").Pc("DeliveryId").Pc("VirtualDeliveryId").Pc("UserId").Pc("OriginalPrice").Pc("Price").Pc("UnitPrice").Pc("Qty").Pc("Note").Pc("IsDone").Pc("IsCreateBySystem").Pc("SystemNote").Pc("UpdatedOn").Pc("UpdatedUserId").Pc("AttributesXml").Pc("TotalAttributePrice").Pc("Percent").Pc("Total").Pc("MerchantNote").Pc("OutOfStock")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressOrder
		public static void ExpressOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderCode").Pc("ClientOrderId").Pc("MerchantId").Pc("PickAddressId").Pc("DropAddressId").Pc("SubTotal").Pc("DeliveryFee").Pc("TotalAmount").Pc("Comission").Pc("CommisionPaymentType").Pc("PaymentMethod").Pc("Note").Pc("Status").Pc("Type").Pc("Assignee").Pc("PickDate").Pc("DropDate").Pc("DeliverWorkShift").Pc("CreatedOn").Pc("UpdatedOn").Pc("IsDeleted").Pc("NoteCS").Pc("VersionNo").Pc("InternalDeliveredTime").Pc("TaskRequest").Pc("IsFreeShip").Pc("Distance").Pc("PickMoney").Pc("PickType").Pc("DeliverType").Pc("CurrencyUnit").Pc("RealPickTime").Pc("RealDropTime").Pc("UserId").Pc("Done").Pc("DeliveryFeeRate").Pc("MaxDeliveryFeeOfSender").Pc("WarehouseId").Pc("DeliveryFeeOfSender").Pc("NoteId").Pc("UserNote").Pc("DeviceOSType").Pc("CommisionMinFee").Pc("CommisionType").Pc("CommisionFee").Pc("AddressTypeCurrent").Pc("UserPayShippingFeeType").Pc("DeliveryFeeReturned").Pc("UserNoteCancel").Pc("PromotionCodeId").Pc("TotalDiscount").Pc("DeliveryFeeDiscount").Pc("DeliveryFeeOfReceiver").Pc("ExpressCustomerAddressId").Pc("IsShiperCommission")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_ShipperMessage_SMS_Template
		public static void Delivery_ShipperMessage_SMS_Template(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Title").Pc("Template").Pc("TemplateEN").Pc("LstCityId").Pc("LstGroupUser").Pc("IsActive").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedBy").Pc("LogUserIdChange").Pc("IsDeleted").Pc("UrlRewriteName").Pc("NameUrl").Pc("GroupService")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_ShipperMessage_SMS_Group
		public static void Delivery_ShipperMessage_SMS_Group(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Template").Pc("Title").Pc("IsActive").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedBy").Pc("LogUserIdChange").Pc("IsDeleted").Pc("GroupService")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryInvoiceStatus
		public static void DeliveryInvoiceStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryInvoice
		public static void DeliveryInvoice(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("ShippingInfoId").Pc("RestaurantId").Pc("CompanyName").Pc("CompanyAddress").Pc("TaxCode").Pc("DeliverTime").Pc("Status").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryConversationType
		public static void DeliveryConversationType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressNotifyUser
		public static void ExpressNotifyUser(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("ItemType").Pc("ItemId").Pc("ItemCode").Pc("Message").Pc("IsShow").Pc("CreatedDate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryConversationTemplate
		public static void DeliveryConversationTemplate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Message").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn").Pc("IsActive").Pc("IsDeleted").Pc("GroupService")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryInvoiceInfo
		public static void DeliveryInvoiceInfo(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("CompanyName").Pc("CompanyAddress").Pc("TaxCode")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryConversation
		public static void DeliveryConversation(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Type").Pc("CreatedBy").Pc("CreatedOn").Pc("IsActive").Pc("IsDeleted").Pc("GroupService")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryConversationStatus
		public static void DeliveryConversationStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryConversationMessage
		public static void DeliveryConversationMessage(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ConversationId").Pc("Message").Pc("Status").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn").Pc("IsActive").Pc("IsDeleted").Pc("GroupService")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressPromoCode
		public static void ExpressPromoCode(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("DiscountValue").Pc("DiscountType").Pc("Limit").Pc("LimitedPerUser").Pc("RemainingQty").Pc("MaxDiscountValue").Pc("MinOrderValue").Pc("Status").Pc("StartDate").Pc("EndDate").Pc("UserId").Pc("CreatedOn").Pc("CreatedUserId").Pc("UpdatedOn").Pc("UpdatedUserId").Pc("IsActive").Pc("Note").Pc("ApplyType").Pc("PlatformApply").Pc("Type").Pc("FoodyStatus").Pc("PublishType").Pc("CorporateId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressPromoCode_ApplyDate
		public static void ExpressPromoCode_ApplyDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionCodeId").Pc("StartDate").Pc("EndDate").Pc("Type").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressPromoCode_ApplyTime
		public static void ExpressPromoCode_ApplyTime(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromotionCodeId").Pc("StartTime").Pc("EndTime").Pc("Type").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy").Pc("ApplyType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressPromoCode_Mapping
		public static void ExpressPromoCode_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromoCodeId").Pc("Value").Pc("MappingType").Pc("CreatedOn").Pc("UpdatedOn").Pc("CreatedBy").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressPromoCode_User_Mapping
		public static void ExpressPromoCode_User_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PromoCodeId").Pc("UserId").Pc("UsedOn").Pc("ExpressOrderId").Pc("PhoneNumber")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Hr_ReportOrderShipperOnDate
		public static void Hr_ReportOrderShipperOnDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("WorkTimeStart").Pc("WorkTimeEnd").Pc("OrderTimeStart").Pc("OrderTimeEnd").Pc("TotalOrder").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_CallCenter_Group
		public static void Delivery_CallCenter_Group(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("Description").Pc("UserId").Pc("CityId").Pc("StartTime").Pc("EndTime").Pc("SortOrder").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn").Pc("IsActive").Pc("IsDeleted")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_CallCenter
		public static void Delivery_CallCenter(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("GroupId").Pc("IsActive").Pc("IsDeleted").Pc("GroupShiftId").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdateOn").Pc("UpdateBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Log_DeliveryMerchantApp
		public static void Log_DeliveryMerchantApp(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("StatusId").Pc("CreateOn").Pc("UserId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_EmployeeCallCenter
		public static void HR_EmployeeCallCenter(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("FirstName").Pc("LastName").Pc("FullName").Pc("Phone").Pc("Skype").Pc("PersonalEmail").Pc("StatusId").Pc("IsDeleted").Pc("CreatedOn").Pc("CityId").Pc("GroupService").Pc("WorkEmail")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryStatistic_PhoneOrder
		public static void DeliveryStatistic_PhoneOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Phone").Pc("TotalOrderDelivered").Pc("TotalOrderCancel").Pc("TotalOrderQuit").Pc("TotalOrderValue").Pc("LastUpdate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryStatistic_RestaurantOrderByDate
		public static void DeliveryStatistic_RestaurantOrderByDate(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryId").Pc("DateOrder").Pc("TotalOrderDelivered").Pc("TotalOrderCancel").Pc("TotalOrderQuit").Pc("TotalOrderValue").Pc("LastUpdate")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for HR_ShipperMapRuleViolationDetail
		public static void HR_ShipperMapRuleViolationDetail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("ViolationId").Pc("ViolationName").Pc("Fee").Pc("Note").Pc("CityId").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("FeedBackId").Pc("StatusId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery
		public static void Delivery(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("RestaurantId").Pc("Name").Pc("ShortCode").Pc("ShortDescription").Pc("Description").Pc("ImageUrl").Pc("MinimumOrderAmount").Pc("Cashback").Pc("ShowDate").Pc("StartDate").Pc("EndDate").Pc("CreatedOn").Pc("UpdatedOn").Pc("IsActive").Pc("DisplayOrder").Pc("DeliveryFee").Pc("MaxDistance").Pc("Service").Pc("IsFoodyDelivery").Pc("IsFeature").Pc("IsDeleted").Pc("ComsDeliveryByFoody").Pc("ComsDeliveryByRes").Pc("VAT").Pc("HasContract").Pc("PayType").Pc("Email").Pc("Phone").Pc("UrlRewrite").Pc("MerchantId").Pc("PartnerId").Pc("ComsDeliveryByUser").Pc("PrepareTime").Pc("LastOrder").Pc("ContractType").Pc("YoutubeUrl").Pc("NowServiceRootCategoryId").Pc("CooperateToGrow").Pc("IsOnline").Pc("ShowPhoneUser").Pc("InvoiceVAT").Pc("InvoiceTime").Pc("AutoAssignToMerchant").Pc("AirPayStoreId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrder
		public static void DeliveryOrder(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryCost").Pc("OrderCode").Pc("ShortCode").Pc("DeliveryId").Pc("UserId").Pc("ShippingInfoId").Pc("PromotionCodeId").Pc("StatusId").Pc("CreatedOn").Pc("SubmittedOn").Pc("EstimateTime").Pc("DeliveredTime").Pc("DeliveredTimeAt").Pc("Verified_UserId").Pc("Assign_UserId").Pc("Assign_RestaurantId").Pc("IsDeleted").Pc("UpdatedOn").Pc("SubTotal").Pc("DiscountPercent").Pc("ServicePercent").Pc("TotalAmount").Pc("TotalDiscount").Pc("RedeemAmount").Pc("ServiceCost").Pc("TotalVATCost").Pc("FixedService").Pc("VATShipFee").Pc("IsFoodyDelivery").Pc("Note").Pc("VersionNo").Pc("CustomShippingFee").Pc("IsLongDistance").Pc("Risk").Pc("VATDeliveryExtend").Pc("ValueChangeOriginal").Pc("Task_Request").Pc("TotalCustomFee").Pc("DiscountPaymentPercent").Pc("DiscountPaymentByPoint").Pc("TotalDiscountRestaurant").Pc("DiscountCampaign").Pc("DiscountCampaignName").Pc("Distance").Pc("DeliveryFee").Pc("IsSupportShip").Pc("DeviceOSType").Pc("AppType").Pc("ParkingFee").Pc("MerchantNote").Pc("MerchantEstimate").Pc("OrderType").Pc("PaymentMethodId").Pc("ReceivedAmount").Pc("RefundAmount").Pc("NoteId").Pc("AdminNote").Pc("UserNote").Pc("LastUpdatedOnStatus").Pc("UserDeleted").Pc("CardId").Pc("PaymentCardResultCode").Pc("PaidStatus").Pc("InternalDeliveredTime").Pc("UserAssigneeId").Pc("ConfirmMethod").Pc("Confirm_UserId").Pc("CrossChecked").Pc("DeviceInfo").Pc("AutoAssignSuccess").Pc("Cooked").Pc("ShippingMethod").Pc("NowServiceRootCategoryId").Pc("IsLate").Pc("Coefficient").Pc("TotalItem").Pc("TotalMember").Pc("ASAP").Pc("CSNote").Pc("ConfirmFee").Pc("CityId").Pc("RestaurantId").Pc("RestaurantName").Pc("SearchUsername").Pc("SearchUserPhone").Pc("SearchEmail").Pc("DistrictId").Pc("RestaurantAddress").Pc("HasNewMessages").Pc("BonusShipper").Pc("AutoConfirmed").Pc("Rate").Pc("MerchantPaidStatus").Pc("MerchantPaidMethod").Pc("MerchantPaidAmount").Pc("MerchantStatus").Pc("HideForCS")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderCompleted
		public static void DeliveryOrderCompleted(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("DeliveryCost").Pc("OrderCode").Pc("ShortCode").Pc("DeliveryId").Pc("UserId").Pc("ShippingInfoId").Pc("PromotionCodeId").Pc("StatusId").Pc("CreatedOn").Pc("SubmittedOn").Pc("EstimateTime").Pc("DeliveredTime").Pc("DeliveredTimeAt").Pc("Verified_UserId").Pc("Assign_UserId").Pc("Assign_RestaurantId").Pc("IsDeleted").Pc("UpdatedOn").Pc("SubTotal").Pc("DiscountPercent").Pc("ServicePercent").Pc("TotalAmount").Pc("TotalDiscount").Pc("RedeemAmount").Pc("ServiceCost").Pc("TotalVATCost").Pc("FixedService").Pc("VATShipFee").Pc("IsFoodyDelivery").Pc("Note").Pc("VersionNo").Pc("CustomShippingFee").Pc("IsLongDistance").Pc("Risk").Pc("VATDeliveryExtend").Pc("ValueChangeOriginal").Pc("Task_Request").Pc("TotalCustomFee").Pc("DiscountPaymentPercent").Pc("DiscountPaymentByPoint").Pc("TotalDiscountRestaurant").Pc("DiscountCampaign").Pc("DiscountCampaignName").Pc("Distance").Pc("DeliveryFee").Pc("IsSupportShip").Pc("DeviceOSType").Pc("AppType").Pc("ParkingFee").Pc("MerchantNote").Pc("MerchantEstimate").Pc("OrderType").Pc("PaymentMethodId").Pc("ReceivedAmount").Pc("RefundAmount").Pc("NoteId").Pc("AdminNote").Pc("UserNote").Pc("LastUpdatedOnStatus").Pc("UserDeleted").Pc("CardId").Pc("PaymentCardResultCode").Pc("PaidStatus").Pc("InternalDeliveredTime").Pc("UserAssigneeId").Pc("ConfirmMethod").Pc("Confirm_UserId").Pc("CrossChecked").Pc("DeviceInfo").Pc("AutoAssignSuccess").Pc("Cooked").Pc("ShippingMethod").Pc("NowServiceRootCategoryId").Pc("IsLate").Pc("Coefficient").Pc("TotalItem").Pc("TotalMember").Pc("ASAP").Pc("CSNote").Pc("ConfirmFee").Pc("CityId").Pc("RestaurantId").Pc("RestaurantName").Pc("SearchUsername").Pc("SearchUserPhone").Pc("SearchEmail").Pc("DistrictId").Pc("RestaurantAddress").Pc("BonusShipper").Pc("AutoConfirmed").Pc("Rate").Pc("HasNewMessages").Pc("MerchantPaidStatus").Pc("MerchantPaidMethod").Pc("MerchantPaidAmount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sysarticles
		public static void sysarticles(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("artid").Pc("creation_script").Pc("del_cmd").Pc("description").Pc("dest_table").Pc("filter").Pc("filter_clause").Pc("ins_cmd").Pc("name").Pc("objid").Pc("pubid").Pc("pre_creation_cmd").Pc("status").Pc("sync_objid").Pc("type").Pc("upd_cmd").Pc("schema_option").Pc("dest_owner").Pc("ins_scripting_proc").Pc("del_scripting_proc").Pc("upd_scripting_proc").Pc("custom_script").Pc("fire_triggers_on_snapshot")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sysarticlecolumns
		public static void sysarticlecolumns(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("artid").Pc("colid").Pc("is_udt").Pc("is_xml").Pc("is_max")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sysschemaarticles
		public static void sysschemaarticles(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("artid").Pc("creation_script").Pc("description").Pc("dest_object").Pc("name").Pc("objid").Pc("pubid").Pc("pre_creation_cmd").Pc("status").Pc("type").Pc("schema_option").Pc("dest_owner")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for syspublications
		public static void syspublications(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("description").Pc("name").Pc("pubid").Pc("repl_freq").Pc("status").Pc("sync_method").Pc("snapshot_jobid").Pc("independent_agent").Pc("immediate_sync").Pc("enabled_for_internet").Pc("allow_push").Pc("allow_pull").Pc("allow_anonymous").Pc("immediate_sync_ready").Pc("allow_sync_tran").Pc("autogen_sync_procs").Pc("retention").Pc("allow_queued_tran").Pc("snapshot_in_defaultfolder").Pc("alt_snapshot_folder").Pc("pre_snapshot_script").Pc("post_snapshot_script").Pc("compress_snapshot").Pc("ftp_address").Pc("ftp_port").Pc("ftp_subdirectory").Pc("ftp_login").Pc("ftp_password").Pc("allow_dts").Pc("allow_subscription_copy").Pc("centralized_conflicts").Pc("conflict_retention").Pc("conflict_policy").Pc("queue_type").Pc("ad_guidname").Pc("backward_comp_level").Pc("allow_initialize_from_backup").Pc("min_autonosync_lsn").Pc("replicate_ddl").Pc("options").Pc("originator_id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for syssubscriptions
		public static void syssubscriptions(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("artid").Pc("srvid").Pc("dest_db").Pc("status").Pc("sync_type").Pc("login_name").Pc("subscription_type").Pc("distribution_jobid").Pc("timestamp").Pc("update_mode").Pc("loopback_detection").Pc("queued_reinit").Pc("nosync_type").Pc("srvname")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sysarticleupdates
		public static void sysarticleupdates(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("artid").Pc("pubid").Pc("sync_ins_proc").Pc("sync_upd_proc").Pc("sync_del_proc").Pc("autogen").Pc("sync_upd_trig").Pc("conflict_tableid").Pc("ins_conflict_proc").Pc("identity_support")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpub_identity_range
		public static void MSpub_identity_range(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("objid").Pc("range").Pc("pub_range").Pc("current_pub_range").Pc("threshold").Pc("last_seed")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for systranschemas
		public static void systranschemas(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("tabid").Pc("startlsn").Pc("endlsn").Pc("typeid")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpeer_lsns
		public static void MSpeer_lsns(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("id").Pc("last_updated").Pc("originator").Pc("originator_db").Pc("originator_publication").Pc("originator_publication_id").Pc("originator_db_version").Pc("originator_lsn").Pc("originator_version").Pc("originator_id")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpeer_request
		public static void MSpeer_request(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("id").Pc("publication").Pc("sent_date").Pc("description")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpeer_response
		public static void MSpeer_response(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("request_id").Pc("peer").Pc("peer_db").Pc("received_date")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpeer_topologyrequest
		public static void MSpeer_topologyrequest(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("id").Pc("publication").Pc("sent_date")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpeer_topologyresponse
		public static void MSpeer_topologyresponse(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("request_id").Pc("peer").Pc("peer_version").Pc("peer_db").Pc("originator_id").Pc("peer_conflict_retention").Pc("received_date").Pc("connection_info")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpeer_originatorid_history
		public static void MSpeer_originatorid_history(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("originator_publication").Pc("originator_id").Pc("originator_node").Pc("originator_db").Pc("originator_db_version").Pc("originator_version").Pc("inserted_date")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpeer_conflictdetectionconfigrequest
		public static void MSpeer_conflictdetectionconfigrequest(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("id").Pc("publication").Pc("sent_date").Pc("timeout").Pc("modified_date").Pc("progress_phase").Pc("phase_timed_out")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for MSpeer_conflictdetectionconfigresponse
		public static void MSpeer_conflictdetectionconfigresponse(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("request_id").Pc("peer_node").Pc("peer_db").Pc("peer_version").Pc("peer_db_version").Pc("is_peer").Pc("conflictdetection_enabled").Pc("originator_id").Pc("peer_conflict_retention").Pc("peer_continue_onconflict").Pc("peer_subscriptions").Pc("progress_phase").Pc("modified_date")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for sysreplservers
		public static void sysreplservers(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("srvname").Pc("srvid")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_CallCenter_GroupTarget
		public static void Delivery_CallCenter_GroupTarget(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("GroupId").Pc("ValueTarget").Pc("Seniority").Pc("IsDeleted").Pc("CreatedOn").Pc("CreatedBy").Pc("UpdatedOn").Pc("UpdatedBy")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for AirPayMerchant
		public static void AirPayMerchant(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AirPayStoreId").Pc("RestaurantId").Pc("OwerName").Pc("ResPhone").Pc("ResEmail").Pc("ResName").Pc("ResAddress").Pc("Password")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for AirPayMerchantTransLog
		public static void AirPayMerchantTransLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("ResponseCode").Pc("MerchantId").Pc("AirpayStoreId").Pc("AirpayTxnId").Pc("AirpayTxnTime").Pc("Currency").Pc("Amount").Pc("CreatedOn").Pc("MessageResponse")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Merchant_PayType
		public static void Delivery_Merchant_PayType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for Delivery_Merchant_PayStatus
		public static void Delivery_Merchant_PayStatus(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Code").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryReportOrderDeposit
		public static void DeliveryReportOrderDeposit(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("TypeCollect").Pc("ShipperIdCollect").Pc("MoneyCollectDeposit").Pc("NumberCard").Pc("IsTransfer").Pc("ShipperIdPay").Pc("MoneyPayDeposit").Pc("UpDownCollectDeposit").Pc("UpDownPayDeposit").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for SyncLog
		public static void SyncLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Action").Pc("Request").Pc("SyncData").Pc("CreatedBy").Pc("CreatedOn").Pc("UpdatedBy").Pc("UpdatedOn").Pc("IsActive").Pc("IsDeleted").Pc("GroupService")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryDiscountType
		public static void DeliveryDiscountType(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryPaymentMethod_Service_Mapping
		public static void DeliveryPaymentMethod_Service_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("PaymentMethod").Pc("ServiceType")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryService
		public static void DeliveryService(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryDiscountCampaign_AppType_Mapping
		public static void DeliveryDiscountCampaign_AppType_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CampaignId").Pc("AppType").Pc("MinSupportedVersion")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryDiscountCampaign_PaymentMethod_Mapping
		public static void DeliveryDiscountCampaign_PaymentMethod_Mapping(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("CampaignId").Pc("PaymentMethodId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryDiscountCampaign
		public static void DeliveryDiscountCampaign(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Name").Pc("ResourceName").Pc("Type").Pc("Discount").Pc("MaxDiscount").Pc("StartDate").Pc("EndDate").Pc("ApplyOrder")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for ExpressCustomerAddress
		public static void ExpressCustomerAddress(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("MerchantId").Pc("WarehouseId").Pc("FullName").Pc("Label").Pc("FullAddress").Pc("GoogleAddress").Pc("PhoneNumber").Pc("Email").Pc("DistrictId").Pc("CityId").Pc("Latitude").Pc("Longitude").Pc("IsVerified").Pc("IsPrimary").Pc("Status").Pc("Note").Pc("CreatedOn").Pc("UpdatedOn").Pc("LastUsed").Pc("ShippingInfoId").Pc("FoodyId").Pc("Type")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryReportOrderDepositLog
		public static void DeliveryReportOrderDepositLog(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ReportDepositId").Pc("UserId").Pc("Type").Pc("Description").Pc("CreatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryReportOrderCard_Daily
		public static void DeliveryReportOrderCard_Daily(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("DeliveredTime").Pc("TotalPayShipper").Pc("TotalAmountNotPaid").Pc("PaymentMethod").Pc("IsPaid").Pc("IsReceived").Pc("TotalPayShipper_Remain").Pc("TotalAmountNotPaid_Remain").Pc("UpdatedOn").Pc("UpdatedUserId").Pc("TotalOrder").Pc("TotalAmount").Pc("Note").Pc("PayShipper_Edit")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryReportOrderCard_Detail
		public static void DeliveryReportOrderCard_Detail(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("UserId").Pc("OrderId").Pc("DeliveredTime").Pc("PayType").Pc("PaymentMethodId").Pc("TotalAmount").Pc("TotalPayShipper").Pc("OtherPayShipper").Pc("PaidStatus").Pc("CityId").Pc("IsLocked").Pc("IsDeleted").Pc("Note")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryOrderCommisionCS
		public static void DeliveryOrderCommisionCS(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("UserId").Pc("StatusId").Pc("IsApproved").Pc("Commision").Pc("CreatedOn").Pc("Note").Pc("IsDeleted").Pc("InternalDelvieryTime")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryDiscount
		public static void DeliveryDiscount(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("OrderId").Pc("Discount").Pc("DiscountPercent").Pc("CampaignId").Pc("PromoCode").Pc("Description").Pc("CreatedOn").Pc("UpdatedOn")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for DeliveryReportOrderDeposit_Daily
		public static void DeliveryReportOrderDeposit_Daily(GCRequest obj, out GCResponse oo)
		{
		    var x = new X3(_cs, _isDebug, _loggedUserId ); x.SDA(D._a, DE._a); x.SDFD(D._fd, DE._fd); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("ShipperId").Pc("FullName").Pc("TotalOrder").Pc("MoneyCollectDeposit").Pc("MoneyPayDeposit").Pc("UpDownTotalCollectDeposit").Pc("UpDownTotalPayDeposit").Pc("TotalCollectDeposit").Pc("TotalPayDeposit").Pc("TotalCollectedDeposit").Pc("TotalPaidDeposit").Pc("DebtorCollectDeposit").Pc("DebtorPayDeposit").Pc("IsCollect").Pc("IsPay").Pc("UpdatedOn").Pc("DeliveredTime").Pc("UpdatedUserId").Pc("Note")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}