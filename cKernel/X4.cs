using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using cModel;
using System.Data.Common;

// ReSharper disable InconsistentNaming
namespace cKernel
{
    public class X4
    {
        //Initial value
        private readonly DbProviderFactory _factory;
        private readonly string _cs; 
        private readonly bool _isDebug;
        private readonly int _loggedUserId;

        private Dictionary<string, string[]> _cda;
        private Dictionary<int, string[][]> _cdfd;

        //Request object
        private GCRequest _robj;

        //Core value

        public readonly R _r = new R { _s = 1 };
        //public string _ac { get; set; } //Current action
        private string[] _a { get; set; } //Current action config
        private string[][] _fs; // Current list fields

        private readonly string[][] _p = new string[100][];     //Current pushed conditions
        private int _pIdx;     //Current pushed condition index
        private string _f;     //Query fields  

        //private readonly string[][][] _c = new string[10][][];
        //private readonly string[][][] _d = new string[10][][];
        private readonly string[][][] _c = new string[100][][];
        private readonly string[][][] _d = new string[100][][];

        private readonly string[][] _od = new string[100][];

        //SQL Statement
        private readonly List<SqlCommand> _sql = new List<SqlCommand>();
        //private readonly List<SqlCommand> _csql = new List<SqlCommand>();

        public X4(string cs, bool isDebug, int uid = 0)
        {
            _factory = SqlClientFactory.Instance;
            _cs = cs;
            _isDebug = isDebug;
            _loggedUserId = uid;
            _cda = new Dictionary<string, string[]>();
            _cdfd = new Dictionary<int, string[][]>();
        }

        public void SDA(params Dictionary<string, string[]>[] args)
        {
            foreach(var item in args)
            {
                _cda = _cda.Concat(item).ToDictionary(x => x.Key, x => x.Value);
            }
        }

        public void SDFD(params Dictionary<int, string[][]>[] args)
        {
            foreach (var item in args)
            {
                _cdfd = _cdfd.Concat(item).ToDictionary(x => x.Key, x => x.Value);
            }
        }


        /// <summary>
        /// Initial
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="uid"></param>
        public void Init(GCRequest obj)
        {
            _robj = obj;
        }

        /// <summary>
        /// Check right
        /// </summary>
        /// <returns></returns>
        public X4 R()
        {
            if (_r._e) return this; _r._s = 1; _r._m = ""; return this;
        }

        /// <summary>
        /// Check action
        /// </summary>
        /// <returns></returns>
        public X4 A()
        {  
            // Kiem tra va lay action
            if (_r._e) return this;
            if (!string.IsNullOrEmpty(_robj._a))
            {
                if (_cda.ContainsKey(_robj._a))
                {
                    _a = _cda[_robj._a];
                    _pIdx = 0;
                    _fs = _a[0][0] == 'G' ? _cdfd[int.Parse(_a[2])] : _cdfd[int.Parse(_a[1])];
                }
                else
                {
                    _r._s = 0;
                    _r._m = _E.E10001.G(_isDebug, null);
                }
            }
            else
            {
                _r._s = 0; _r._m = _E.E10002.G(_isDebug, null);
            }
            return this;
        }

        /// <summary>
        /// Push condition
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public X4 Pc(string value)
        {
            if (_r._e) return this;
            var fi = L(value, 7, 0, _fs.Length, _fs);
            if (!string.IsNullOrEmpty(fi))
            {
                _p[_pIdx] = new[] { value, fi };
                _pIdx++;
            }
            else { _r._s = 0; _r._m = _E.E10005.G(_isDebug, null); }
            return this;
        }

        /// <summary>
        /// Look up field: key, index compare, index value, length, array
        /// </summary>
        /// <param name="k"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="l"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public string L(string k, int i, int j, int l, string[][] f)
        {
            for (var m = 0; m < l; m++) if (f[m][i] == k) return f[m][j]; return string.Empty;
        }

        /// <summary>
        /// Check condition
        /// </summary>
        /// <returns></returns>
        public X4 _CC()
        {
            if (_r._e) return this;
            if (_robj._c != null)
            {
                if(_robj._c.Any())
                {
                    if (_robj._c.Any(i => string.IsNullOrEmpty(L(i.Key, 0, 0, _p.Length, _p))))
                    {
                        _r._s = 0;
                        _r._m = _E.E10006.G(_isDebug, null);
                    }
                    else
                    {
                        _c[0] = new string[_robj._c.Count][];
                    }
                }

            }
            if (_robj._mc != null)
            {
                if (_robj._mc.Any())
                {
                    if (_robj._mc.Any(c => c.Any(i => string.IsNullOrEmpty(L(i.Key, 0, 0, _p.Length, _p)))))
                    {
                        _r._s = 0;
                        _r._m = _E.E10006.G(_isDebug, null);
                    }
                    else
                    {
                        for (var i = 0; i < _robj._mc.Length; i++)
                        {
                            _c[i] = new string[_robj._mc[i].Count][];
                        }
                    }
                }
            }
           
            return this;
        }

        /// <summary>
        /// Check field
        /// </summary>
        /// <returns></returns>
        public X4 _CF()
        {
            if (_r._e) return this;

            if (_robj._d != null)
            {
                if (_robj._d.Any())
                {
                    if (_robj._d.Any(i => string.IsNullOrEmpty(L(i.Key, 7, 0, _fs.Length, _fs))))
                    {
                        _r._s = 0;
                        _r._m = _E.E10007.G(_isDebug, null);
                    }
                    if (!V(_robj._d)) //Validate
                    {
                        _r._s = 0;
                        _r._m = _E.E10010.G(_isDebug, null);
                    }
                    else
                    {
                        _d[0] = new string[_robj._d.Count][];
                    }
                }
            }
            if (_robj._md != null)
            {
                if(_robj._md.Any())
                {
                    if (_robj._md.Any(d => d.Any(i => string.IsNullOrEmpty(L(i.Key, 7, 0, _fs.Length, _fs)))))
                    {
                        _r._s = 0;
                        _r._m = _E.E10007.G(_isDebug, null);
                    }
                    if (_robj._md.Any(d => !V(d))) //Validate
                    {
                        _r._s = 0;
                        _r._m = _E.E10010.G(_isDebug, null);
                    }
                    else
                    {
                        for (var i = 0; i < _robj._md.Length; i++)
                        {
                            _d[i] = new string[_robj._md[i].Count][];
                        }
                    }
                }
            }

            //Assign field
            _f = !string.IsNullOrEmpty(_robj._f) ? MF(_robj._f) : "*";

            return this;
        }
        public string MF(string f)
        {
            return string.Join(",", f.Split(',').Where(c => !string.IsNullOrEmpty(c)).Select(c => string.Format("[{0}]", c.Trim())));
        }

        /// <summary>
        /// Validate data
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public bool V(object d)
        {
            return true;
        }

        /// <summary>
        /// Load condition and data, order, limit, offset
        /// </summary>
        /// <returns></returns>
        public X4 L()
        {
            if (_r._e) return this;
            
            int i;
            
            if (_robj._c != null)
            {
                if (_robj._c.Any())
                {
                    i = 0;
                    foreach (var c in _robj._c)
                    {
                        _c[0][i] = new[] {c.Key, L(c.Key, 7, 0, _fs.Length, _fs), string.Format("{0}", c.Value)};
                        i++;
                    }
                   
                }
            }

            if (_robj._d != null)
            {
                if (_robj._d.Any())
                {
                    i = 0;
                    foreach (var d in _robj._d)
                    {
                        _d[0][i] = new[] { d.Key, L(d.Key, 7, 0, _fs.Length, _fs), string.Format("{0}", d.Value) };
                        i++;
                    }
                }
            }


            if (_robj._mc != null)
            {
                if (_robj._mc.Any())
                {
                    i = 0;
                    foreach (var c in _robj._mc)
                    {
                        var j = 0;
                        foreach (var item in c)
                        {
                            _c[i][j] = new[]
                            {item.Key, L(item.Key, 7, 0, _fs.Length, _fs), string.Format("{0}", item.Value)};
                            j++;
                        }
                        i++;
                    }
                    
                }
            }

            if (_robj._md != null)
            {
                if (_robj._md.Any())
                {
                    i = 0;
                    foreach (var d in _robj._md)
                    {
                        var j = 0;
                        foreach (var item in d)
                        {
                            _d[i][j] = new[] { item.Key, L(item.Key, 7, 0, _fs.Length, _fs), string.Format("{0}", item.Value) };
                            j++;
                        }
                        i++;
                    }
                }
            }

            if (_robj._od == null) return this;
            if (!_robj._od.Any()) return this;
            i = 0;
            foreach (var od in _robj._od)
            {
                _od[i] = new[] {od.Key, L(od.Key, 7, 0, _fs.Length, _fs), string.Format("{0}", od.Value)};
                i++;
            }

            return this;
        }

        /// <summary>
        /// Generate SQL statement
        /// </summary>
        /// <returns></returns>
        public X4 S()
        {
            if (_r._e) return this;
            var v = _a[0][0] == 'G' ? _a[4] : _a[3];
            switch (_a[0][0])
            {
                case 'G': G(v, _f, _c, _od, _robj._lm, _robj._os); break;
                case 'P': PG(v, _f, _c, _od, _robj._lm, _robj._os); break;
                case 'I': I(v, _d); break;
                case 'U': U(v, _c, _d); break;
                case 'D': R(v, _c); break;
                case 'S': SP(_a[5], _c); break;
            }
            return this;
        }

        #region Select statement
        public void G(string v, string f, string[][][] c, string[][] od, int? lm, int? os)
        {

            var cond = string.Empty;
            var fcond = c.FirstOrDefault(i => i != null);

            var cmd = new SqlCommand();
            List<SqlParameter> pc = new List<SqlParameter>();
            if (fcond != null)
            {
                cond = LW(fcond, fcond.Length, out pc);
            }
            var order = LOD(od, od.Length);
            cmd.CommandText = string.Format("SELECT {0} FROM {1} {2} {3}", f, v, cond, order);
            cmd.Parameters.AddRange(pc.ToArray());
            _sql.Add(cmd);
        }
        public void PG(string v, string f, string[][][] c, string[][] od, int? lm, int? os)
        {
            var cond = string.Empty;
            var fcond = c.FirstOrDefault(i => i != null);

            var cmd = new SqlCommand() {
                CommandType = CommandType.StoredProcedure
            };
            List<SqlParameter> pc = new List<SqlParameter>();
            if (fcond != null)
            {
                cond = LW(fcond, fcond.Length, out pc);
                foreach(var item in pc)
                {
                    switch (item.SqlDbType)
                    {
                        case SqlDbType.VarChar:
                        case SqlDbType.NVarChar:
                            cond = cond.Replace(string.Format("@{0}", item.ParameterName), string.Format("'{0}'", item.Value));
                            break;
                        default:
                            cond = cond.Replace(string.Format("@{0}", item.ParameterName), string.Format("{0}", item.Value));
                            break;
                    }
                }
            }
            var order = LOD(od, od.Length);

            cmd.CommandText = "GetPaginationData";
            cmd.Parameters.Add("@sort", SqlDbType.NVarChar);
            cmd.Parameters["@sort"].Value = order;
            cmd.Parameters.Add("@table", SqlDbType.NVarChar);
            cmd.Parameters["@table"].Value = v;
            cmd.Parameters.Add("@column", SqlDbType.NVarChar);
            cmd.Parameters["@column"].Value = f;
            cmd.Parameters.Add("@filter", SqlDbType.NVarChar);
            cmd.Parameters["@filter"].Value = cond;
            cmd.Parameters.Add("@numOfRow", SqlDbType.Int);
            cmd.Parameters["@numOfRow"].Value = lm.HasValue ? lm.Value : 1000;
            cmd.Parameters.Add("@index", SqlDbType.Int);
            cmd.Parameters["@index"].Value = os.HasValue ? os.Value : 0;
            //cmd.CommandText = string.Format("EXEC {0} @table = {1}, @column = {2}, @sort = {3}, @filter = {4}, @index = {5}, @numOfRow = {6}", "GetPaginationData", v, _f, order, cond, os.HasValue ? os.Value : 0, lm.HasValue ? lm.Value : 1000);
            _sql.Add(cmd);
        }
        public string LW(string[][] f, int l, out List<SqlParameter> pc)
        {
            pc = new List<SqlParameter>();
            var r = "";
            for (var i = 0; i < l; i++)
            {
                if (f[i] == null) continue;
                string x;
                if (f[i][2].Trim().IndexOf("$x", StringComparison.Ordinal) != -1)
                    x = f[i][2].Replace("$x", string.Format("[{0}]",f[i][0]));
                else
                {
                    x = string.Format("[{0}] = @{1}", f[i][0], LPN(f[i][0]));

                    var tp = LT(f[i][1]);
                    object v = f[i][2];
                    switch (tp)
                    {
                        case SqlDbType.Bit:
                            v = f[i][2].Equals("1") || f[i][2].Equals("True");
                            break;
                        default:
                            break;
                    }
                    pc.Add(new SqlParameter(LPN(f[i][0]), tp)
                    {
                        Value = v
                    });
                }
                if (r == "") r += " WHERE " + x; else r += " AND " + x;
            }
            return r;
        }
        

        public string LOD(string[][] f, int l)
        {
            var r = "";
            for (var i = 0; i < l; i++)
            {
                if (f[i] == null) continue;
                var x = string.Format("{0} {1}", f[i][0], f[i][2]);
                if (r == "") r += " ORDER BY " + x;
                else r += " , " + x;
            }
            return r;
        }
        public string LLO(int? lm, int? os)
        {
            var r = "";
            if (lm.HasValue && os.HasValue)
            {
                r = string.Format(" LIMIT {0} OFFSET {1}", lm.Value, os.Value);
            }
            return r;
        }
        public string LPN(string n, string prefix = "w")
        {
            return string.Format("{0}_{1}", prefix, n);
        }

        #endregion

        #region Insert statement
        public void I(string v, string[][][] d)
        {
            foreach (var item in d)
            {
                if (item != null)
                {
                    var cmd = new SqlCommand();
                    List<SqlParameter> pc;
                    var param = LI(item, out pc);
                    cmd.CommandText = string.Format("INSERT INTO {0}({1}) VALUES({2}); SELECT SCOPE_IDENTITY()", v, param[0], param[1]);
                    cmd.Parameters.AddRange(pc.ToArray());
                    _sql.Add(cmd);
                }
            }
           
        }
        public string[] LI(string[][] f, out List<SqlParameter> pc)
        {
            pc = new List<SqlParameter>();
            string[] r = { "", "" };
            foreach (var t1 in f.Where(t1 => !t1[0].Equals("Id")))
            {
                if (r[0] == "")
                    r[0] += string.Format("[{0}]", t1[0]);
                else
                    r[0] += "," + string.Format("[{0}]", t1[0]);
                if (r[1] == "")
                    r[1] += string.Format("@{0}", LPN(t1[0],"i"));
                else
                    r[1] += "," + string.Format("@{0}", LPN(t1[0],"i"));

                var t = LT(t1[1]);
                object v = t1[2];
                switch (t)
                {
                    case SqlDbType.Bit:
                        v = t1[2].Equals("1") || t1[2].Equals("True");
                        break;
                    case SqlDbType.Date:
                    case SqlDbType.DateTime:
                        if (string.IsNullOrEmpty(t1[2]))
                        {
                            v = DBNull.Value;
                        }
                        break;
                    default:
                        break;
                }
                pc.Add(new SqlParameter(LPN(t1[0], "i"), t )
                {
                    Value = v
                });
            }

            var afs = f.Select(t1 => t1[0]).ToList();
            if (!afs.Contains("IsPrgCreatedUserId"))
            {
                if (!string.IsNullOrEmpty(L("IsPrgCreatedUserId", 7, 0, _fs.Length, _fs)))
                {
                    if(_loggedUserId > 0)
                    {
                        if (r[0] == "") r[0] += "[IsPrgCreatedUserId]"; else r[0] += "," + "[IsPrgCreatedUserId]";
                        if (r[1] == "") r[1] += "@i_IsPrgCreatedUserId"; else r[1] += "," + "@i_IsPrgCreatedUserId";
                        pc.Add(new SqlParameter("i_IsPrgCreatedUserId", SqlDbType.Int) {
                            Value = _loggedUserId
                        });
                    }
                }
            }
            if (!afs.Contains("IsPrgCreatedDate"))
            {
                if (!string.IsNullOrEmpty(L("IsPrgCreatedDate", 7, 0, _fs.Length, _fs)))
                {
                    if (r[0] == "") r[0] += "[IsPrgCreatedDate]"; else r[0] += "," + "[IsPrgCreatedDate]";
                    if (r[1] == "") r[1] += "@i_IsPrgCreatedDate"; else r[1] += "," + "@i_IsPrgCreatedDate";
                    pc.Add(new SqlParameter("i_IsPrgCreatedDate", SqlDbType.DateTime) {
                        Value = DateTime.Now
                    });
                }
            }
         
            return r;
        }
        public SqlDbType LT(object t)
        {
            return (SqlDbType)Convert.ToInt32(t);
        }
        #endregion

        #region Update statement
        public void U(string v, string[][][] c, string[][][] d)
        {
            for (var i = 0; i < c.Length; i++)
            {
                if (c[i] != null)
                {
                    var cmd = new SqlCommand();
                    List<SqlParameter> pc, pcc;
                    var param = LU(d[i], out pc);
                    var cond = LW(c[i], c[i].Length, out pcc);
                    cmd.CommandText = string.Format("UPDATE {0} SET {1} {2}; SELECT @@ROWCOUNT", v, param, cond);
                    cmd.Parameters.AddRange(pc.ToArray());
                    cmd.Parameters.AddRange(pcc.ToArray());
                    _sql.Add(cmd);
                }
            }
        }
        public string LU(string[][] f, out List<SqlParameter> pc)
        {
            pc = new List<SqlParameter>();
            var r = "";
            foreach (var t1 in f.Where(t1 => !t1[0].Equals("Id")))
            {
                string t;
                if (t1[2].Trim().IndexOf("$x", StringComparison.Ordinal) != -1)
                    t = t1[2].Replace("$x", string.Format("[{0}]",t1[0]));
                else
                {
                    t = string.Format("[{0}] = @{1}", t1[0], LPN(t1[0],"u"));

                    var tp = LT(t1[1]);
                    object v = t1[2];
                    switch (tp)
                    {
                        case SqlDbType.Bit:
                            v = t1[2].Equals("1") || t1[2].Equals("True");
                            break;
                        case SqlDbType.Date:
                        case SqlDbType.DateTime:
                            if (string.IsNullOrEmpty(t1[2]))
                            {
                                v = DBNull.Value;
                            }
                            break;
                        default:
                            break;
                    }
                    pc.Add(new SqlParameter(LPN(t1[0], "u"), tp)
                    {
                        Value = v
                    });
                }
                if (r == "") r += t;
                else r += ("," + t);
            }

            var afs = f.Select(t1 => t1[0]).ToList();
            if (!afs.Contains("IsPrgUpdatedUserId"))
            {
                if (!string.IsNullOrEmpty(L("IsPrgUpdatedUserId", 7, 0, _fs.Length, _fs)))
                {
                    if(_loggedUserId > 0)
                    {
                        if (r == "")
                            r += "[IsPrgUpdatedUserId] = @u_IsPrgUpdatedUserId";
                        else
                            r += ",[IsPrgUpdatedUserId] = @u_IsPrgUpdatedUserId";
                        pc.Add(new SqlParameter("u_IsPrgUpdatedUserId", SqlDbType.Int) {
                            Value = _loggedUserId
                        });
                    }
                }
            }

            if (!afs.Contains("IsPrgUpdatedDate"))
            {
                if (!string.IsNullOrEmpty(L("IsPrgUpdatedDate", 7, 0, _fs.Length, _fs)))
                {
                    if (r == "")
                        r += "[IsPrgUpdatedDate] = @u_IsPrgUpdatedDate";
                    else
                        r += ",[IsPrgUpdatedDate] = @u_IsPrgUpdatedDate";
                    pc.Add(new SqlParameter("u_IsPrgUpdatedDate", SqlDbType.DateTime) {
                        Value = DateTime.Now
                    });
                }
            }

            return r;
        }
        #endregion

        #region Delete statement
        public void R(string v, string[][][] c)
        {
            foreach (var item in c)
            {
                if (item != null)
                {
                    var cmd = new SqlCommand();
                    List<SqlParameter> pc;
                    var cond = LW(item, item.Length, out pc);
                    cmd.CommandText = string.Format("DELETE FROM {0} {1}", v, cond);
                    cmd.Parameters.AddRange(pc.ToArray());
                    _sql.Add(cmd);
                }
            }
        }
        #endregion

        #region Store procedure statement
        public void SP(string sp, string[][][] c)
        {
            //var fcond = c.FirstOrDefault(i => i != null);
            //if (fcond != null)
            //{
            //    var cmd = new SqlCommand() {
            //        CommandType = CommandType.StoredProcedure
            //    };
            //    List<SqlParameter> pc = LWSP(fcond, fcond.Length);
            //    cmd.CommandText = sp;
            //    cmd.Parameters.AddRange(pc.ToArray());
            //    _sql.Add(cmd);
            //}

            foreach(var item in c)
            {
                if(item != null)
                {
                    var cmd = new SqlCommand()
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    List<SqlParameter> pc = LWSP(item, item.Length);
                    cmd.CommandText = sp;
                    cmd.Parameters.AddRange(pc.ToArray());
                    _sql.Add(cmd);
                }
            }

        }
        public List<SqlParameter> LWSP(string[][] f, int l)
        {
            var pc = new List<SqlParameter>();
            for (var i = 0; i < l; i++)
            {
                if (f[i] == null) continue;
                if (f[i][2].Trim().IndexOf("$x", StringComparison.Ordinal) != -1)
                    pc.Add(new SqlParameter(f[i][0], SqlDbType.NVarChar)
                    {
                        Value = f[i][2].Replace("$x", string.Format("[{0}]", f[i][0]))
                    });
                else
                {
                    var tp = LT(f[i][1]);
                    object v = f[i][2];
                    switch (tp)
                    {
                        case SqlDbType.Bit:
                            v = f[i][2].Equals("1") || f[i][2].Equals("True");
                            break;
                        default:
                            break;
                    }
                    pc.Add(new SqlParameter(f[i][0], tp)
                    {
                        Value = v
                    });
                }
            }
            return pc;
        }

        #endregion



        #region Execute SQL statement
        public X4 EX()
        {
            if (_r._e) return this;
            switch (_a[0][0])
            {
                case 'G': 
                case 'S': EXQ(_sql); break;
                case 'I': 
                case 'U':
                case 'D': EXNQ(_sql); break;
                case 'P': EXPQ(_sql); break;
            }
            return this;
        }

        public void EXPQ(List<SqlCommand> sql)
        {
            try
            {
                using (var con = _factory.CreateConnection())
                {
                    con.ConnectionString = _cs;
                    con.Open();

                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = sql.FirstOrDefault().CommandText;
                        var pIdOut = new SqlParameter("@total", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        cmd.Parameters.Add(pIdOut);
                        cmd.Prepare(); //Prepare for performance

                        using (var reader = cmd.ExecuteReader())
                        {
                            var result = new DataTable();
                            result.Load(reader);

                            var total = 0;
                            if ((pIdOut.Value != DBNull.Value))
                                total = (int)(pIdOut.Value);

                            var list = new List<object[]>();
                            for (var m = 0; m < result.Rows.Count; m++) list.Add(result.Rows[m].ItemArray);
                            _r._d = list; _r._t = total;
                        }
                    }
                      
                }
            }
            catch (Exception ex)
            {
                _r._s = 0; _r._m = _E.E10009.G(_isDebug, ex);
            }
        }
        public void EXQ(List<SqlCommand> sql)
        {
            try
            {
                using (var con = _factory.CreateConnection())
                {
                    con.ConnectionString = _cs;
                    con.Open();

                    _r._d = new List<object[]>();
                    _r._t = 0;
                    foreach (var item in sql)
                    {
                        if (item != null)
                        {
                            using (var cmd = con.CreateCommand())
                            {
                                cmd.CommandText = item.CommandText;
                                cmd.Prepare(); //Prepare for performance

                                using (var reader = cmd.ExecuteReader())
                                {
                                    var result = new DataTable();
                                    result.Load(reader);

                                    var list = new List<object[]>();
                                    for (var m = 0; m < result.Rows.Count; m++) list.Add(result.Rows[m].ItemArray);
                                    _r._d = _r._d.Concat(list).ToList(); _r._t += result.Rows.Count;
                                }
                                    
                            }
                        }
                    }
                }
                  
            }
            catch (Exception ex)
            {
                _r._s = 0; _r._m = _E.E10009.G(_isDebug, ex);
            }
        }
        public void EXNQ(List<SqlCommand> sql)
        {
            DbTransaction transaction = null;
            try
            {
                using (var con = _factory.CreateConnection())
                {
                    con.ConnectionString = _cs;
                    con.Open();

                    //Begin transaction
                    transaction = con.BeginTransaction();

                    _r._d = new List<object[]>();
                    foreach (var item in sql)
                    {
                        using (var cmd = con.CreateCommand())
                        {
                            cmd.CommandText = item.CommandText;
                            cmd.Transaction = transaction;

                            var result = cmd.ExecuteScalar();
                            _r._d.Add(new[] { result });
                        }
                    }
                    //Commit
                    transaction.Commit();
                }
            }
            catch (Exception ex)
            {
                _r._s = 0; _r._m = _E.E10009.G(_isDebug, ex);

                //Rollback
                if (transaction != null)
                {
                    transaction.Rollback();
                }
            }
        }
        #endregion

        /// <summary>
        /// Check order
        /// </summary>
        /// <returns></returns>
        public X4 _CO()
        {
            if (_r._e) return this;
            if (_robj._od == null) return this;
            if(_robj._od.Any())
            {
                if (_robj._od.Any(i => string.IsNullOrEmpty(L(i.Key, 7, 0, _fs.Length, _fs))))
                {
                    _r._s = 0; _r._m = _E.E10012.G(_isDebug, null);
                }
            }
            return this;
        }

        /// <summary>
        /// Check limit offset
        /// </summary>
        /// <returns></returns>
        public X4 _CLO()
        {
            if (_r._e) return this;
            if (_robj._lm.HasValue)
            {
                if (_robj._lm.Value <= 0)
                {
                    _r._s = 0; _r._m = _E.E10013.G(_isDebug, null);
                }
            }
            if (_robj._os.HasValue)
            {
                if (_robj._os.Value < 0)
                {
                    _r._s = 0; _r._m = _E.E10014.G(_isDebug, null);
                }
            }
            return this;
        }

        /// <summary>
        /// Get result
        /// </summary>
        /// <returns></returns>
        public R G()
        {
            return _r;
        }

    }
}
