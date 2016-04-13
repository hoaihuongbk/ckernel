using System.Collections.Generic;
 namespace cDict
{
    public class D
    {
        // 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function 
		public static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  { 
			//tbl_SMS
			{"pGettbl_SMS"     , new[]{"P", "0", "0" ,"tbl_SMS", "tbl_SMS_View", "tbl_SMS"}},
			{"fGettbl_SMS"     , new[]{"G", "0", "0" ,"tbl_SMS", "tbl_SMS_View", "tbl_SMS"}},
			{"Inserttbl_SMS"   , new[]{"I", "0", "0" ,"tbl_SMS", "tbl_SMS_View", "tbl_SMS"}},
			{"Updatetbl_SMS"   , new[]{"U", "0", "0" ,"tbl_SMS", "tbl_SMS_View", "tbl_SMS"}},
			{"Removetbl_SMS"   , new[]{"D", "0", "0" ,"tbl_SMS", "tbl_SMS_View", "tbl_SMS"}},
		};
        //[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]
		public static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> { 
			{0, new [] {  //tbl_SMS - 11 columns  
				 new []{ "0", "0", "1", "", "8", "", "", "Id" },
				 new []{ "8", "1", "0", "", "4", "", "", "Type" },
				 new []{ "22", "1", "0", "", "128", "", "", "Code" },
				 new []{ "12", "1", "0", "", "512", "", "", "Name" },
				 new []{ "22", "1", "0", "", "128", "", "", "PhoneNumber" },
				 new []{ "12", "1", "0", "", "1024", "", "", "Message" },
				 new []{ "8", "1", "0", "", "4", "", "", "Status" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgCreatedDate" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgUpdatedDate" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgCreatedUserId" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgUpdatedUserId" },
			}},
		};
    }
}