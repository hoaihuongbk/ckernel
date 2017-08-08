using System.Collections.Generic;
 namespace cDict
{
    public class D
    {
        // 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function 
		public static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  { 
			//DeliveryConversationMessage
			{"pGetDeliveryConversationMessage"     , new[]{"P", "0", "0" ,"DeliveryConversationMessage", "DeliveryConversationMessage_View", "DeliveryConversationMessage"}},
			{"fGetDeliveryConversationMessage"     , new[]{"G", "0", "0" ,"DeliveryConversationMessage", "DeliveryConversationMessage_View", "DeliveryConversationMessage"}},
			{"InsertDeliveryConversationMessage"   , new[]{"I", "0", "0" ,"DeliveryConversationMessage", "DeliveryConversationMessage_View", "DeliveryConversationMessage"}},
			{"UpdateDeliveryConversationMessage"   , new[]{"U", "0", "0" ,"DeliveryConversationMessage", "DeliveryConversationMessage_View", "DeliveryConversationMessage"}},
			{"RemoveDeliveryConversationMessage"   , new[]{"D", "0", "0" ,"DeliveryConversationMessage", "DeliveryConversationMessage_View", "DeliveryConversationMessage"}},
			//DeliveryConversationType
			{"pGetDeliveryConversationType"     , new[]{"P", "1", "1" ,"DeliveryConversationType", "DeliveryConversationType_View", "DeliveryConversationType"}},
			{"fGetDeliveryConversationType"     , new[]{"G", "1", "1" ,"DeliveryConversationType", "DeliveryConversationType_View", "DeliveryConversationType"}},
			{"InsertDeliveryConversationType"   , new[]{"I", "1", "1" ,"DeliveryConversationType", "DeliveryConversationType_View", "DeliveryConversationType"}},
			{"UpdateDeliveryConversationType"   , new[]{"U", "1", "1" ,"DeliveryConversationType", "DeliveryConversationType_View", "DeliveryConversationType"}},
			{"RemoveDeliveryConversationType"   , new[]{"D", "1", "1" ,"DeliveryConversationType", "DeliveryConversationType_View", "DeliveryConversationType"}},
			//DeliveryConversation
			{"pGetDeliveryConversation"     , new[]{"P", "2", "2" ,"DeliveryConversation", "DeliveryConversation_View", "DeliveryConversation"}},
			{"fGetDeliveryConversation"     , new[]{"G", "2", "2" ,"DeliveryConversation", "DeliveryConversation_View", "DeliveryConversation"}},
			{"InsertDeliveryConversation"   , new[]{"I", "2", "2" ,"DeliveryConversation", "DeliveryConversation_View", "DeliveryConversation"}},
			{"UpdateDeliveryConversation"   , new[]{"U", "2", "2" ,"DeliveryConversation", "DeliveryConversation_View", "DeliveryConversation"}},
			{"RemoveDeliveryConversation"   , new[]{"D", "2", "2" ,"DeliveryConversation", "DeliveryConversation_View", "DeliveryConversation"}},
		};
        //[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]
		public static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> { 
			{0, new [] {  //DeliveryConversationMessage - 6 columns  
				 new []{ "8", "0", "1", "", "4", "", "", "Id" },
				 new []{ "8", "1", "0", "", "4", "", "", "ConversationId" },
				 new []{ "12", "1", "0", "", "8000", "", "", "Message" },
				 new []{ "8", "1", "0", "", "4", "", "", "Status" },
				 new []{ "8", "1", "0", "", "4", "", "", "CreatedBy" },
				 new []{ "4", "1", "0", "", "8", "", "", "CreatedOn" },
			}},
			{1, new [] {  //DeliveryConversationType - 2 columns  
				 new []{ "8", "0", "1", "", "4", "", "", "Id" },
				 new []{ "12", "0", "0", "", "500", "", "", "Name" },
			}},
			{2, new [] {  //DeliveryConversation - 5 columns  
				 new []{ "8", "0", "1", "", "4", "", "", "Id" },
				 new []{ "8", "1", "0", "", "4", "", "", "OrderId" },
				 new []{ "8", "1", "0", "", "4", "", "", "Type" },
				 new []{ "8", "1", "0", "", "4", "", "", "CreatedBy" },
				 new []{ "4", "1", "0", "", "8", "", "", "CreatedOn" },
			}},
		};
    }
}