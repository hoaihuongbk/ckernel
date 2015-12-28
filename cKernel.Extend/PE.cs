using cModel;
namespace cKernel.Extend
{
    public class PE
    {
        private static string _cs; private static bool _isDebug; private static int _loggedUserId;
        public PE(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }
		//for gc_Page_Data_Service_Condition_View00
		public static void gc_Page_Data_Service_Condition_View00(GCRequest obj, out GCResponse oo)
		{
            var x = new X2(_cs, _isDebug, _loggedUserId); x.Init(obj);
		    var r = x.R().A().Pc("PageDataServiceId").Pc("Conditions")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Page_Data_View00
		public static void gc_Page_Data_View00(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("PageId").Pc("Name").Pc("Action").Pc("Conditions").Pc("Fields").Pc("BindingType").Pc("BindingName").Pc("BindingAttributeName").Pc("TemplatePath").Pc("BindingPageDataValue")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Template_Slot_View00
		public static void gc_Template_Slot_View00(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("Id").Pc("Type").Pc("TemplateId2").Pc("TemplateId1").Pc("SlotCode").Pc("Code").Pc("FilePath")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Function_Input_View00
		public static void gc_Function_Input_View00(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("FunctionId").Pc("Inputs")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for gc_Function_Output_View00
		public static void gc_Function_Output_View00(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("FunctionId").Pc("Outputs")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}
		//for GetPageEventFunction
		public static void GetPageEventFunction(GCRequest obj, out GCResponse oo)
		{
		    var x = new X2(_cs, _isDebug); x.Init(obj);
		    var r = x.R().A().Pc("PageTemplateId")._CC()._CF()._CO()._CLO().L().S().EX().G();
		    oo = new GCResponse { Result = r._e ? 0 : 1, Records = r._d, TotalRecordCount = r._t, Message = r._m };
		}

    }
}