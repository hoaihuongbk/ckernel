using System;
using cKernel.Extend;
using cModel;
using cDict;

namespace cService
{
    // ReSharper disable InconsistentNaming
    public class S
    {
        private readonly string _cs;
        private readonly bool _isDebug;
        private readonly int _loggedUserId;

        public S(string connectionString, bool isDebug = false, int uid = 0)
        {
            _cs = connectionString;
            _isDebug = isDebug;
            _loggedUserId = uid;
        }

        public GCResponse P(GCRequest obj)
        {
            var pr = new object[2];
            pr[0] = obj;
            pr[1] = new GCResponse { Result = 0, TotalRecordCount = 0 };

            try
            {
                if (!String.IsNullOrEmpty(obj._a))
                {
                    if (D._a.ContainsKey(obj._a))
                    {
                        var p = new P(_cs, _isDebug, _loggedUserId);
                        var _a = D._a[obj._a];
                        var m = p.GetType().GetMethod(_a[5]);
                        if (m != null)
                            m.Invoke(p, pr); // sử dụng gọi method
                    }
                    else if (DE._a.ContainsKey(obj._a)) // call extension
                    {
                        var pe = new PE(_cs, _isDebug, _loggedUserId);
                        var _a = DE._a[obj._a];
                        var m = pe.GetType().GetMethod(_a[5]);
                        if (m != null)
                            m.Invoke(pe, pr); // sử dụng gọi method
                    }
                }
            }
            catch (Exception ex)
            {
                pr[1] = new GCResponse { Result = 0, TotalRecordCount = 0, Message = ex.Message };
            }
            return (GCResponse) pr[1];
        }
    }
}