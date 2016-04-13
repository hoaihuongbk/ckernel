using cModel;
using cKernel;
 namespace cKernel.Extend
{
    public class PE
    {
        private static string _cs; private static bool _isDebug = false; private static int _loggedUserId;
		public PE(string cs, bool isDebug, int uid) { _cs = cs; _isDebug = isDebug; _loggedUserId = uid; }

    }
}