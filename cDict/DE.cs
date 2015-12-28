using System.Collections.Generic;
namespace cDict
{
    public class DE
    {
        // 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function 
		public static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  { 
			//gc_Page_Data_Service_Condition_View00
			{"pGetgc_Page_Data_Service_Condition_View00"     , new[]{"P", "0", "0" ,"gc_Page_Data_Service_Condition_View00", "gc_Page_Data_Service_Condition_View00", "gc_Page_Data_Service_Condition_View00"}},
			{"fGetgc_Page_Data_Service_Condition_View00"     , new[]{"G", "0", "0" ,"gc_Page_Data_Service_Condition_View00", "gc_Page_Data_Service_Condition_View00", "gc_Page_Data_Service_Condition_View00"}},
			//gc_Page_Data_View00
			{"pGetgc_Page_Data_View00"     , new[]{"P", "1", "1" ,"gc_Page_Data_View00", "gc_Page_Data_View00", "gc_Page_Data_View00"}},
			{"fGetgc_Page_Data_View00"     , new[]{"G", "1", "1" ,"gc_Page_Data_View00", "gc_Page_Data_View00", "gc_Page_Data_View00"}},
			//gc_Template_Slot_View00
			{"pGetgc_Template_Slot_View00"     , new[]{"P", "2", "2" ,"gc_Template_Slot_View00", "gc_Template_Slot_View00", "gc_Template_Slot_View00"}},
			{"fGetgc_Template_Slot_View00"     , new[]{"G", "2", "2" ,"gc_Template_Slot_View00", "gc_Template_Slot_View00", "gc_Template_Slot_View00"}},
			//gc_Function_Input_View00
			{"pGetgc_Function_Input_View00"     , new[]{"P", "3", "3" ,"gc_Function_Input_View00", "gc_Function_Input_View00", "gc_Function_Input_View00"}},
			{"fGetgc_Function_Input_View00"     , new[]{"G", "3", "3" ,"gc_Function_Input_View00", "gc_Function_Input_View00", "gc_Function_Input_View00"}},
			//gc_Function_Output_View00
			{"pGetgc_Function_Output_View00"     , new[]{"P", "4", "4" ,"gc_Function_Output_View00", "gc_Function_Output_View00", "gc_Function_Output_View00"}},
			{"fGetgc_Function_Output_View00"     , new[]{"G", "4", "4" ,"gc_Function_Output_View00", "gc_Function_Output_View00", "gc_Function_Output_View00"}},
			//GetPageEventFunction
			{"sGetPageEventFunction"     , new[]{"S", "5", "5" ,"GetPageEventFunction", "GetPageEventFunction", "GetPageEventFunction"}},
		};
        //[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]
		public static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> { 
			{0, new [] {  //gc_Page_Data_Service_Condition_View00 - 2 columns  
				 new []{ "1", "1", "0", "", "8", "", "", "PageDataServiceId" },
				 new []{ "4", "1", "0", "", "-1", "", "", "Conditions" },
			}},
			{1, new [] {  //gc_Page_Data_View00 - 10 columns  
				 new []{ "1", "1", "0", "", "8", "", "", "PageId" },
				 new []{ "4", "1", "0", "", "256", "", "", "Name" },
				 new []{ "4", "1", "0", "", "256", "", "", "Action" },
				 new []{ "4", "1", "0", "", "-1", "", "", "Conditions" },
				 new []{ "4", "1", "0", "", "1024", "", "", "Fields" },
				 new []{ "1", "1", "0", "", "4", "", "", "BindingType" },
				 new []{ "4", "1", "0", "", "256", "", "", "BindingName" },
				 new []{ "4", "1", "0", "", "1024", "", "", "BindingAttributeName" },
				 new []{ "4", "1", "0", "", "1024", "", "", "TemplatePath" },
				 new []{ "4", "1", "0", "", "-1", "", "", "BindingPageDataValue" },
			}},
			{2, new [] {  //gc_Template_Slot_View00 - 7 columns  
				 new []{ "1", "0", "0", "", "8", "", "", "Id" },
				 new []{ "1", "1", "0", "", "4", "", "", "Type" },
				 new []{ "1", "1", "0", "", "8", "", "", "TemplateId2" },
				 new []{ "1", "1", "0", "", "8", "", "", "TemplateId1" },
				 new []{ "4", "1", "0", "", "64", "", "", "SlotCode" },
				 new []{ "4", "1", "0", "", "64", "", "", "Code" },
				 new []{ "4", "1", "0", "", "1024", "", "", "FilePath" },
			}},
			{3, new [] {  //gc_Function_Input_View00 - 2 columns  
				 new []{ "1", "1", "0", "", "8", "", "", "FunctionId" },
				 new []{ "4", "1", "0", "", "-1", "", "", "Inputs" },
			}},
			{4, new [] {  //gc_Function_Output_View00 - 2 columns  
				 new []{ "1", "1", "0", "", "8", "", "", "FunctionId" },
				 new []{ "4", "1", "0", "", "-1", "", "", "Outputs" },
			}},
			{5, new [] {  //GetPageEventFunction - 1 columns  
				 new []{ "1", "0", "0", "", "4", "", "", "PageTemplateId" },
			}},
		};
    }
}