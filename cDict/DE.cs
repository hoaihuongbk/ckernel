using System.Collections.Generic;
 namespace cDict
{
    public class DE
    {
        // 0:method, 1:table key, 2:view key, 3:table, 4:view, 5:main function 
		public static Dictionary<string, string[]> _a = new Dictionary<string, string[]>  { 
		};
        //[int: 1; float: 2; string: 4; date: 5; bool: 3] [0:type, 1:isnull, 2:key, 3:fkey, 4:length, 5:ftable, 6:fId, 7:Name]
		public static Dictionary<int, string[][]> _fd = new Dictionary<int, string[][]> { 
		};
    }
}