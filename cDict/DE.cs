using System.Collections.Generic;
 namespace cDict
{
    public class DE
    {
        // 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function 
		public static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  { 
			//DeN_Admin_DeliveryConversationMessage_Get
			{"sDeN_Admin_DeliveryConversationMessage_Get"     , new[]{"S", "3", "3" ,"DeN_Admin_DeliveryConversationMessage_Get", "DeN_Admin_DeliveryConversationMessage_Get", "DeN_Admin_DeliveryConversationMessage_Get"}},
			//DeN_Admin_DeliveryConversationMessage_GetList
			{"sDeN_Admin_DeliveryConversationMessage_GetList"     , new[]{"S", "4", "4" ,"DeN_Admin_DeliveryConversationMessage_GetList", "DeN_Admin_DeliveryConversationMessage_GetList", "DeN_Admin_DeliveryConversationMessage_GetList"}},
			//DeN_Admin_DeliveryConversationMessage_Update
			{"sDeN_Admin_DeliveryConversationMessage_Update"     , new[]{"S", "5", "5" ,"DeN_Admin_DeliveryConversationMessage_Update", "DeN_Admin_DeliveryConversationMessage_Update", "DeN_Admin_DeliveryConversationMessage_Update"}},
			//DeN_Admin_DeliveryConversation_Get
			{"sDeN_Admin_DeliveryConversation_Get"     , new[]{"S", "6", "6" ,"DeN_Admin_DeliveryConversation_Get", "DeN_Admin_DeliveryConversation_Get", "DeN_Admin_DeliveryConversation_Get"}},
			//DeN_Admin_DeliveryConversation_GetList
			{"sDeN_Admin_DeliveryConversation_GetList"     , new[]{"S", "7", "7" ,"DeN_Admin_DeliveryConversation_GetList", "DeN_Admin_DeliveryConversation_GetList", "DeN_Admin_DeliveryConversation_GetList"}},
			//DeN_Admin_DeliveryConversation_Update
			{"sDeN_Admin_DeliveryConversation_Update"     , new[]{"S", "8", "8" ,"DeN_Admin_DeliveryConversation_Update", "DeN_Admin_DeliveryConversation_Update", "DeN_Admin_DeliveryConversation_Update"}},
		};
        //[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]
		public static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> { 
			{3, new [] {  //DeN_Admin_DeliveryConversationMessage_Get - 1 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "Id" },
			}},
			{4, new [] {  //DeN_Admin_DeliveryConversationMessage_GetList - 2 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "PageIndex" },
				 new []{ "8", "0", "0", "", "4", "", "", "PageSize" },
			}},
			{5, new [] {  //DeN_Admin_DeliveryConversationMessage_Update - 6 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "Id" },
				 new []{ "8", "0", "0", "", "4", "", "", "ConversationId" },
				 new []{ "12", "0", "0", "", "8000", "", "", "Message" },
				 new []{ "8", "0", "0", "", "4", "", "", "Status" },
				 new []{ "8", "0", "0", "", "4", "", "", "CreatedBy" },
				 new []{ "4", "0", "0", "", "8", "", "", "CreatedOn" },
			}},
			{6, new [] {  //DeN_Admin_DeliveryConversation_Get - 1 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "Id" },
			}},
			{7, new [] {  //DeN_Admin_DeliveryConversation_GetList - 2 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "PageIndex" },
				 new []{ "8", "0", "0", "", "4", "", "", "PageSize" },
			}},
			{8, new [] {  //DeN_Admin_DeliveryConversation_Update - 5 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "Id" },
				 new []{ "8", "0", "0", "", "4", "", "", "OrderId" },
				 new []{ "8", "0", "0", "", "4", "", "", "Type" },
				 new []{ "8", "0", "0", "", "4", "", "", "CreatedBy" },
				 new []{ "4", "0", "0", "", "8", "", "", "CreatedOn" },
			}},
		};
    }
}