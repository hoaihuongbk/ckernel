using System.Collections.Generic;
 namespace cDict
{
    public class DE
    {
        // 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function 
		public static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  { 
			//tbl_Driver_View_001
			{"pGettbl_Driver_View_001"     , new[]{"P", "10", "10" ,"tbl_Driver_View_001", "tbl_Driver_View_001", "tbl_Driver_View_001"}},
			{"fGettbl_Driver_View_001"     , new[]{"G", "10", "10" ,"tbl_Driver_View_001", "tbl_Driver_View_001", "tbl_Driver_View_001"}},
			//tbl_PT_Group_Permission_View_001
			{"pGettbl_PT_Group_Permission_View_001"     , new[]{"P", "11", "11" ,"tbl_PT_Group_Permission_View_001", "tbl_PT_Group_Permission_View_001", "tbl_PT_Group_Permission_View_001"}},
			{"fGettbl_PT_Group_Permission_View_001"     , new[]{"G", "11", "11" ,"tbl_PT_Group_Permission_View_001", "tbl_PT_Group_Permission_View_001", "tbl_PT_Group_Permission_View_001"}},
			//GetPermissionByGroupAndModule
			{"sGetPermissionByGroupAndModule"     , new[]{"S", "12", "12" ,"GetPermissionByGroupAndModule", "GetPermissionByGroupAndModule", "GetPermissionByGroupAndModule"}},
			//InsertOrUpdatePermission
			{"sInsertOrUpdatePermission"     , new[]{"S", "13", "13" ,"InsertOrUpdatePermission", "InsertOrUpdatePermission", "InsertOrUpdatePermission"}},
			//UpdateManager
			{"sUpdateManager"     , new[]{"S", "14", "14" ,"UpdateManager", "UpdateManager", "UpdateManager"}},
		};
        //[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]
		public static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> { 
			{10, new [] {  //tbl_Driver_View_001 - 19 columns  
				 new []{ "0", "0", "0", "", "8", "", "", "Id" },
				 new []{ "8", "1", "0", "", "4", "", "", "Type" },
				 new []{ "22", "1", "0", "", "128", "", "", "Code" },
				 new []{ "22", "1", "0", "", "128", "", "", "UserName" },
				 new []{ "12", "1", "0", "", "512", "", "", "FullName" },
				 new []{ "22", "1", "0", "", "128", "", "", "PrimaryPhone" },
				 new []{ "22", "1", "0", "", "128", "", "", "PrimaryEmail" },
				 new []{ "12", "1", "0", "", "512", "", "", "Address" },
				 new []{ "8", "1", "0", "", "4", "", "", "ProvinceId" },
				 new []{ "8", "1", "0", "", "4", "", "", "CityId" },
				 new []{ "8", "1", "0", "", "4", "", "", "TaxiType" },
				 new []{ "22", "1", "0", "", "128", "", "", "Number" },
				 new []{ "12", "1", "0", "", "5", "", "", "Latitude" },
				 new []{ "12", "1", "0", "", "5", "", "", "Longitude" },
				 new []{ "8", "1", "0", "", "4", "", "", "Status" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgCreatedDate" },
				 new []{ "4", "1", "0", "", "8", "", "", "IsPrgUpdatedDate" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgCreatedUserId" },
				 new []{ "8", "1", "0", "", "4", "", "", "IsPrgUpdatedUserId" },
			}},
			{11, new [] {  //tbl_PT_Group_Permission_View_001 - 4 columns  
				 new []{ "8", "1", "0", "", "4", "", "", "GroupId" },
				 new []{ "8", "1", "0", "", "4", "", "", "PermissionId" },
				 new []{ "12", "1", "0", "", "512", "", "", "Name" },
				 new []{ "12", "1", "0", "", "512", "", "", "Description" },
			}},
			{12, new [] {  //GetPermissionByGroupAndModule - 2 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "GroupId" },
				 new []{ "22", "0", "0", "", "128", "", "", "Module" },
			}},
			{13, new [] {  //InsertOrUpdatePermission - 3 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "GroupId" },
				 new []{ "8", "0", "0", "", "4", "", "", "PermissionId" },
				 new []{ "8", "0", "0", "", "4", "", "", "Status" },
			}},
			{14, new [] {  //UpdateManager - 8 columns  
				 new []{ "8", "0", "0", "", "4", "", "", "Id" },
				 new []{ "8", "0", "0", "", "4", "", "", "UserId" },
				 new []{ "22", "0", "0", "", "128", "", "", "Password" },
				 new []{ "12", "0", "0", "", "256", "", "", "FullName" },
				 new []{ "12", "0", "0", "", "256", "", "", "PrimaryPhone" },
				 new []{ "12", "0", "0", "", "512", "", "", "Address" },
				 new []{ "8", "0", "0", "", "4", "", "", "ProvinceId" },
				 new []{ "8", "0", "0", "", "4", "", "", "Type" },
			}},
		};
    }
}