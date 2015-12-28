using System;

namespace cKernel
{
    public class _E
    {
        public string[] T { get; set; }
        public string G(bool isDebug, Exception ex)
        {
            if (!isDebug || ex == null)
            {
                return T[0] + ":" + T[1];
            }
            return ex.ToString();

        }
        public static _E E10001 = new _E { T = new[] { "10001", "Action not found" } };
        public static _E E10002 = new _E { T = new[] { "10002", "Wrong input" } };
        public static _E E10004 = new _E { T = new[] { "10004", "Format wrong" } };
        public static _E E10005 = new _E { T = new[] { "10005", "Push condition field wrong" } };
        public static _E E10006 = new _E { T = new[] { "10006", "Condition field wrong" } };
        public static _E E10007 = new _E { T = new[] { "10007", "Data field wrong" } };
        public static _E E10008 = new _E { T = new[] { "10008", "Field wrong" } };
        public static _E E10009 = new _E { T = new[] { "10009", "Excute sql error" } };
        public static _E E10010 = new _E { T = new[] { "10010", "Validate error" } };
        public static _E E10011 = new _E { T = new[] { "10011", "Count not found" } };
        public static _E E10012 = new _E { T = new[] { "10012", "Order field not found" } };
        public static _E E10013 = new _E { T = new[] { "10013", "Wrong limit" } };
        public static _E E10014 = new _E { T = new[] { "10014", "Wrong offset" } };
    }
}
