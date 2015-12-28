using cModel;
namespace cKernel.Extend
{
    public class P
    {
        private static string _cs; private static bool _isDebug; private static int _loggedUserId;
		public P(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug;
		    _loggedUserId = uid;
		}
		//for gc_App
		public void gc_App(GCRequest obj, out GCResponse oo)
		{
            var x = new X2(_cs, _isDebug, _loggedUserId); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("FullName").Pc("Url").Pc("Note").Pc("Description").Pc("IsDebug").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Function
		public static void gc_Function(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("FullName").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Function_Input
		public static void gc_Function_Input(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FunctionId").Pc("Type").Pc("Code").Pc("Name").Pc("FullName").Pc("IsReference").Pc("DefaultValue").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Function_Output
		public static void gc_Function_Output(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("FunctionId").Pc("Type").Pc("Code").Pc("Name").Pc("FullName").Pc("DefaultValue").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page
		public static void gc_Page(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("AppId").Pc("Type").Pc("Code").Pc("Name").Pc("FullName").Pc("RouteFormat").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page_Data
		public static void gc_Page_Data(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PageId").Pc("Type").Pc("Code").Pc("Name").Pc("ReturnType").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page_Data_Binding
		public static void gc_Page_Data_Binding(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PageDataId").Pc("TemplateId").Pc("Type").Pc("Code").Pc("Name").Pc("AttributeName").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount").Pc("PageDataValue")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page_Data_Service
		public static void gc_Page_Data_Service(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PageDataId").Pc("Type").Pc("Code").Pc("Name").Pc("Action").Pc("Fields").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page_Data_Service_Condition
		public static void gc_Page_Data_Service_Condition(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PageDataServiceId").Pc("Type").Pc("Code").Pc("Name").Pc("KeyName").Pc("Value").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page_Param
		public static void gc_Page_Param(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PageId").Pc("Type").Pc("Code").Pc("Name").Pc("RegEx").Pc("Converter").Pc("ConverterType").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page_Template
		public static void gc_Page_Template(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PageId").Pc("TemplateId").Pc("IsActive").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page_URLFormat
		public static void gc_Page_URLFormat(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("PageId").Pc("Type").Pc("HasKey").Pc("ParseFormat").Pc("IsPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Template_Event
		public static void gc_Template_Event(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TemplateId").Pc("FunctionId").Pc("Type").Pc("IsActive").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Template_Slot
		public static void gc_Template_Slot(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("TemplateId1").Pc("TemplateId2").Pc("Type").Pc("SlotCode").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Template
		public static void gc_Template(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("Code").Pc("Name").Pc("FullName").Pc("FilePath").Pc("Content").Pc("Note").Pc("Description").Pc("isPrgStatus").Pc("isPrgCreatedDate").Pc("isPrgUpdatedDate").Pc("isPrgHistoryInfo").Pc("isPrgCreatedAccount").Pc("isPrgUpdatedAccount")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}