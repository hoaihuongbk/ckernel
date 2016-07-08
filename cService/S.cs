using System;
using cKernel.Extend;
using cModel;
using cDict;
using cService.Helpers;
using System.Collections.Generic;

namespace cService
{
    // ReSharper disable InconsistentNaming
    public class S
    {
        private readonly string _cs;
        private readonly bool _isDebug;
        private readonly int _loggedUserId;
        private const int maxStatement = 10;

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
            pr[1] = new GCResponse { Result = 0, TotalRecordCount = 0, Records = new List<object[]>() };

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
                        {
                            m.Invoke(p, pr); // sử dụng gọi method
                            //if (obj._md != null && obj._md.Length > maxStatement)
                            //{
                            //    switch (_a[0])
                            //    {
                            //        case "I":
                            //            for (var i = 0; i < obj._md.Length; i+= maxStatement)
                            //            {
                            //                var gl = i + maxStatement > obj._md.Length ? obj._md.Length - i : maxStatement;
                            //                var tobj = new GCRequest() {
                            //                    _a = obj._a,
                            //                    _md = obj._md.SubArray(i, gl)
                            //                };
                            //                var tpr = new object[2];
                            //                tpr[0] = tobj;
                            //                tpr[1] = new GCResponse { Result = 0, TotalRecordCount = 0, Records = new List<object[]>() };
                            //                m.Invoke(p, tpr);
                            //                ((GCResponse)pr[1]).Result = ((GCResponse)tpr[1]).Result;
                            //                ((GCResponse)pr[1]).Records.AddRange(((GCResponse)tpr[1]).Records);
                            //            } 
                            //            break;
                            //        case "U":
                            //            for (var i = 0; i < obj._mc.Length; i += maxStatement)
                            //            {
                            //                var gl = i + maxStatement > obj._mc.Length ? obj._mc.Length - i : maxStatement;
                            //                var tobj = new GCRequest()
                            //                {
                            //                    _a = obj._a,
                            //                    _mc = obj._mc.SubArray(i, gl),
                            //                    _md = obj._md.SubArray(i, gl)
                            //                };
                            //                var tpr = new object[2];
                            //                tpr[0] = tobj;
                            //                tpr[1] = new GCResponse { Result = 0, TotalRecordCount = 0, Records = new List<object[]>() };
                            //                m.Invoke(p, tpr);
                            //                ((GCResponse)pr[1]).Result = ((GCResponse)tpr[1]).Result;
                            //                ((GCResponse)pr[1]).Records.AddRange(((GCResponse)tpr[1]).Records);
                            //            }
                            //            break;
                            //    }
                            //} else
                            //{
                               
                            //}
                        }
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