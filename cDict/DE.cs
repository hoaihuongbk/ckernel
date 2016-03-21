using System.Collections.Generic;
 namespace cDict
{
    public class DE
    {
        // 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function 
		public static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  { 
			//tbl_PT_MailBox_View_OutBox
			{"pGettbl_PT_MailBox_View_OutBox"     , new[]{"P", "2", "2" ,"tbl_PT_MailBox_View_OutBox", "tbl_PT_MailBox_View_OutBox", "tbl_PT_MailBox_View_OutBox"}},
			{"fGettbl_PT_MailBox_View_OutBox"     , new[]{"G", "2", "2" ,"tbl_PT_MailBox_View_OutBox", "tbl_PT_MailBox_View_OutBox", "tbl_PT_MailBox_View_OutBox"}},
			//tbl_PT_MailBox_View_SentBox
			{"pGettbl_PT_MailBox_View_SentBox"     , new[]{"P", "3", "3" ,"tbl_PT_MailBox_View_SentBox", "tbl_PT_MailBox_View_SentBox", "tbl_PT_MailBox_View_SentBox"}},
			{"fGettbl_PT_MailBox_View_SentBox"     , new[]{"G", "3", "3" ,"tbl_PT_MailBox_View_SentBox", "tbl_PT_MailBox_View_SentBox", "tbl_PT_MailBox_View_SentBox"}},
			//slyt_SetNextAccount
			{"sslyt_SetNextAccount"     , new[]{"S", "4", "4" ,"slyt_SetNextAccount", "slyt_SetNextAccount", "slyt_SetNextAccount"}},
		};
        //[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]
		public static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> { 
			{2, new [] {  //tbl_PT_MailBox_View_OutBox - 14 columns  
				 new []{ "0", "0", "0", "", "8", "", "", "Id" },
				 new []{ "8", "1", "0", "", "4", "", "", "Type" },
				 new []{ "22", "1", "0", "", "128", "", "", "Code" },
				 new []{ "12", "1", "0", "", "512", "", "", "Name" },
				 new []{ "12", "1", "0", "", "256", "", "", "To" },
				 new []{ "12", "1", "0", "", "1024", "", "", "CC" },
				 new []{ "12", "1", "0", "", "1024", "", "", "BCC" },
				 new []{ "12", "1", "0", "", "512", "", "", "Subject" },
				 new []{ "11", "1", "0", "", "16", "", "", "Body" },
				 new []{ "8", "1", "0", "", "4", "", "", "Status" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgCreatedDate" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgUpdatedDate" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgCreatedUserId" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgUpdatedUserId" },
			}},
			{3, new [] {  //tbl_PT_MailBox_View_SentBox - 14 columns  
				 new []{ "0", "0", "0", "", "8", "", "", "Id" },
				 new []{ "8", "1", "0", "", "4", "", "", "Type" },
				 new []{ "22", "1", "0", "", "128", "", "", "Code" },
				 new []{ "12", "1", "0", "", "512", "", "", "Name" },
				 new []{ "12", "1", "0", "", "256", "", "", "To" },
				 new []{ "12", "1", "0", "", "1024", "", "", "CC" },
				 new []{ "12", "1", "0", "", "1024", "", "", "BCC" },
				 new []{ "12", "1", "0", "", "512", "", "", "Subject" },
				 new []{ "11", "1", "0", "", "16", "", "", "Body" },
				 new []{ "8", "1", "0", "", "4", "", "", "Status" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgCreatedDate" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgUpdatedDate" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgCreatedUserId" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgUpdatedUserId" },
			}},
			{4, new [] {  //slyt_SetNextAccount - 1 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "CurrentId" },
			}},
		};
    }
}