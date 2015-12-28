using System;
using Lang.Php;

namespace cKernel2PHP
{
    [Page("Index")]
    public class _E : PhpDummy
    {
        public string[] T { get; set; }
        public string G(bool isDebug, Exception ex)
        {
            if (!isDebug || ex == null)
            {
                return T[0] + ":" + T[1] + ":" + T[2];
            }
            return ex.ToString();

        }
        public static _E E10001 = new _E { T = new[] { "10001", "Err", "Action not found" } };
        public static _E E10002 = new _E { T = new[] { "10002", "Err", "Wrong input" } };
        public static _E E10004 = new _E { T = new[] { "10004", "Err", "Format wrong" } };
        public static _E E10005 = new _E { T = new[] { "10005", "Err", "Push condition field wrong" } };
        public static _E E10006 = new _E { T = new[] { "10006", "Err", "Condition field wrong" } };
        public static _E E10007 = new _E { T = new[] { "10007", "Err", "Data field wrong" } };
        public static _E E10008 = new _E { T = new[] { "10008", "Err", "Field wrong" } };
        public static _E E10009 = new _E { T = new[] { "10009", "Err", "Excute sql error" } };
        public static _E E10010 = new _E { T = new[] { "10010", "Err", "Validate error" } };
        public static _E E10011 = new _E { T = new[] { "10011", "Err", "Count not found" } };
        public static _E E10012 = new _E { T = new[] { "10012", "Err", "Order field not found" } };
        public static _E E10013 = new _E { T = new[] { "10013", "Err", "Wrong limit" } };
        public static _E E10014 = new _E { T = new[] { "10014", "Err", "Wrong offset" } };
    }
}
