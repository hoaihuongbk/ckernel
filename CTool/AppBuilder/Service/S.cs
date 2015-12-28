using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vxr.Core.Extend;
using Vxr.Dict;

namespace Vxr.Front.Service
{
    public class S
    {
        public Dictionary<string, object> CreateRequestObj(string act, Dictionary<string, object> cond, string[] fields)
        {
            return new Dictionary<string, object>()
            {
                {"_a", act},
                {"_c", cond},
                {"_f", String.Join(",", fields)}
            };
        }

        public object SubmitAction(Dictionary<string, object> obj)
        {
            var pr = new object[2];
            pr[0] = obj;
            pr[1] = new { Result = 0, Records = "", TotalRecordCount = 0 };

            var _ip = obj;
            try
            {
                if (_ip.ContainsKey("_a"))
                {
                    var a = _ip["_a"] as string;
                    if (a != null && D._a.ContainsKey(a))
                    {
                        var _a = D._a[a];
                        if (!string.IsNullOrEmpty(_a[6]) && _ip.ContainsKey("_d"))
                        {
                            var h = Type.GetType("Vxr.Core.Extend.PH");
                            if (h != null)
                            {

                                string[] l =
                        {
                            HttpContext.Current.Request.Headers["CompId"],
                            HttpContext.Current.Request.Headers["AgentId"],
                            HttpContext.Current.Request.Headers["UserId"],
                            HttpContext.Current.Request.Headers["UserName"],
                            a, _a[0]
                        };
                                var ph = new object[3];
                                ph[0] = obj;
                                ph[1] = l;
                                ph[2] = new object();
                                var hp = Activator.CreateInstance(h);
                                var hpp = hp.GetType().GetMethod(_a[6]);
                                if (hpp != null)
                                    hpp.Invoke(hp, ph);// sử dụng gọi method
                                pr[0] = ph[2];
                            }
                        }
                        var p = new P();
                        var m = p.GetType().GetMethod(_a[5]);
                        if (m != null)
                            m.Invoke(p, pr);// sử dụng gọi method
                        else // call extension
                        {
                            var t = Type.GetType("Vxr.Core.Extend.PE");
                            if (t != null)
                            {
                                var pe = Activator.CreateInstance(t);
                                m = pe.GetType().GetMethod(_a[5]);
                                if (m != null)
                                    m.Invoke(p, pr);// sử dụng gọi method
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                pr[1] = new { Result = 0, Records = ex, TotalRecordCount = 0 };
            }

            return pr[1];
        }
    }
}