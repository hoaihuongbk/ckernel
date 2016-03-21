using System.Collections.Generic;
 namespace cDict
{
    public class D
    {
        // 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function 
		public static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  { 
			//tbl_PT_GmailAccount
			{"pGettbl_PT_GmailAccount"     , new[]{"P", "0", "0" ,"tbl_PT_GmailAccount", "tbl_PT_GmailAccount_View", "tbl_PT_GmailAccount"}},
			{"fGettbl_PT_GmailAccount"     , new[]{"G", "0", "0" ,"tbl_PT_GmailAccount", "tbl_PT_GmailAccount_View", "tbl_PT_GmailAccount"}},
			{"Inserttbl_PT_GmailAccount"   , new[]{"I", "0", "0" ,"tbl_PT_GmailAccount", "tbl_PT_GmailAccount_View", "tbl_PT_GmailAccount"}},
			{"Updatetbl_PT_GmailAccount"   , new[]{"U", "0", "0" ,"tbl_PT_GmailAccount", "tbl_PT_GmailAccount_View", "tbl_PT_GmailAccount"}},
			{"Removetbl_PT_GmailAccount"   , new[]{"D", "0", "0" ,"tbl_PT_GmailAccount", "tbl_PT_GmailAccount_View", "tbl_PT_GmailAccount"}},
			//tbl_PT_MailBox
			{"pGettbl_PT_MailBox"     , new[]{"P", "1", "1" ,"tbl_PT_MailBox", "tbl_PT_MailBox_View", "tbl_PT_MailBox"}},
			{"fGettbl_PT_MailBox"     , new[]{"G", "1", "1" ,"tbl_PT_MailBox", "tbl_PT_MailBox_View", "tbl_PT_MailBox"}},
			{"Inserttbl_PT_MailBox"   , new[]{"I", "1", "1" ,"tbl_PT_MailBox", "tbl_PT_MailBox_View", "tbl_PT_MailBox"}},
			{"Updatetbl_PT_MailBox"   , new[]{"U", "1", "1" ,"tbl_PT_MailBox", "tbl_PT_MailBox_View", "tbl_PT_MailBox"}},
			{"Removetbl_PT_MailBox"   , new[]{"D", "1", "1" ,"tbl_PT_MailBox", "tbl_PT_MailBox_View", "tbl_PT_MailBox"}},
		};
        //[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]
		public static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> { 
			{0, new [] {  //tbl_PT_GmailAccount - 12 columns  
				 new []{ "0", "0", "1", "", "8", "", "", "Id" },
				 new []{ "8", "1", "0", "", "4", "", "", "Type" },
				 new []{ "22", "1", "0", "", "128", "", "", "Code" },
				 new []{ "12", "1", "0", "", "512", "", "", "Name" },
				 new []{ "22", "1", "0", "", "128", "", "", "Email" },
				 new []{ "12", "1", "0", "", "256", "", "", "Password" },
				 new []{ "8", "1", "0", "", "4", "", "", "InUse" },
				 new []{ "8", "1", "0", "", "4", "", "", "Status" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgCreatedDate" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgUpdatedDate" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgCreatedUserId" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgUpdatedUserId" },
			}},
			{1, new [] {  //tbl_PT_MailBox - 14 columns  
				 new []{ "0", "0", "1", "", "8", "", "", "Id" },
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
		};
    }
}