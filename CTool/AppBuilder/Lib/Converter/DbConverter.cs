using System;
using MySys = System.Text;
namespace Toyota.Financial.Core.Converter
{
    public static class DbConverter
    {
        public static DateTime? HasValueDB(DateTime? obj)
        {
            try
            {
                if (obj.HasValue)
                    return obj.Value;
                //return DateTime.MinValue;
                return null;
            }
            catch
            {
                //return DateTime.MinValue;
                return null;
            }
        }

        //public static DateTime HasValueDB(DateTime obj)
        //{
        //    try
        //    {
        //        if (obj == null)
        //            return DateTime.MinValue;
        //        return obj;
        //    }
        //    catch
        //    {
        //        return DateTime.MinValue;
        //    }
        //}

        public static short HasValueDB(long obj)
        {
            try
            {
                return (short)obj;
            }
            catch
            {
                return 0;
            }
        }

        public static decimal HasValueDB(decimal obj)
        {
            try
            {
                return obj;
            }
            catch
            {
                return 0;
            }
        }

        public static float HasValueDB(float obj)
        {
            try
            {
                return obj;
            }
            catch
            {
                return 0;
            }
        }

        public static string HasValueDB(string obj)
        {
            try
            {
                var cvr = new ConvertFont();
                if (obj == null)
                    return "";
                cvr.Convert(ref obj, FontIndex.iVNI, FontIndex.iUNI);
                return obj.Trim();
            }
            catch
            {
                return "";
            }
        }

        public static decimal HasValueDB(long? obj)
        {
            try
            {
                return (decimal)obj;
            }
            catch
            {
                return 0;
            }
        }

        public static short HasValueDB(short? obj)
        {
            try
            {
                return (short)obj;
            }
            catch
            {
                return 0;
            }
        }

        public static short HasValueDB(short obj)
        {
            try
            {
                return (short)obj;
            }
            catch
            {
                return 0;
            }
        }


        public static decimal HasValueDB(decimal? obj)
        {
            try
            {
                return (decimal)obj;
            }
            catch
            {
                return 0;
            }
        }

        //public static DateTime? SetValueDB(DateTime? obj)
        //{
        //    try
        //    {
        //        if (obj.HasValue)
        //            return obj.Value;
        //        //return DateTime.MinValue;
        //        return null;
        //    }
        //    catch
        //    {
        //        //return DateTime.MinValue;
        //        return null;
        //    }
        //}
        public static DateTime? SetValueDB(DateTime? obj)
        {
            try
            {
                if (obj.HasValue && obj.Value != DateTime.MinValue)
                    return obj.Value;
                return null;
            }
            catch
            {
                return null;
            }
        }
        //public static DateTime SetValueDB(DateTime obj)
        //{
        //    try
        //    {
        //        if (obj == null)
        //            return DateTime.MinValue;
        //        return obj;
        //    }
        //    catch
        //    {
        //        return DateTime.MinValue;
        //    }
        //}

        public static short SetValueDB(long obj)
        {
            try
            {
                return (short)obj;
            }
            catch
            {
                return 0;
            }
        }

        public static short SetValueDB(decimal obj)
        {
            try
            {
                return (short)obj;
            }
            catch
            {
                return 0;
            }
        }

        public static short SetValueDB(short obj)
        {
            try
            {
                return (short)obj;
            }
            catch
            {
                return 0;
            }
        }

        public static short SetValueDB(short? obj)
        {
            try
            {
                return (short)obj;
            }
            catch
            {
                return 0;
            }
        }

        public static decimal SetValueDB(decimal? obj)
        {
            try
            {
                return (decimal)obj;
            }
            catch
            {
                return 0;
            }
        }

        public static string SetValueDB(string obj)
        {
            try
            {
                var cvr = new ConvertFont();
                if (obj == null)
                    return "";
                var objUni = obj;
                if (cvr.getCode(obj) == FontIndex.iUTH)
                    objUni = CompoundToUnicode(obj);
                cvr.Convert(ref objUni, FontIndex.iUNI, FontIndex.iVNI);
                return objUni.Trim();
            }
            catch
            {
                return "";
            }
        }
        public static string SetValueUpload(string obj)
        {
            try
            {
                var cvr = new ConvertFont();
                if (cvr.getCode(obj) == FontIndex.iUNI)
                {
                    var ss = "";
                }
                if (obj == null)
                    return "";
                cvr.Convert(ref obj, FontIndex.iUNI, FontIndex.iVNI);
                return obj.Trim();
            }
            catch
            {
                return "";
            }
        }
        public static string CompoundToUnicode(string input)
        {
            var ds = new[]
            {
                "\u00e0", "\u00e1", "\u1ea1", "\u1ea3", "\u00e3", "\u00e2", "\u1ea7", "\u1ea5", "\u1ead", "\u1ea9",
                "\u1eab", "\u0103", "\u1eb1", "\u1eaf", "\u1eb7", "\u1eb3", "\u1eb5", "\u00e8", "\u00e9", "\u1eb9",
                "\u1ebb", "\u1ebd", "\u00ea", "\u1ec1", "\u1ebf", "\u1ec7", "\u1ec3", "\u1ec5", "\u00ec", "\u00ed",
                "\u1ecb", "\u1ec9", "\u0129", "\u00f2", "\u00f3", "\u1ecd", "\u1ecf", "\u00f5", "\u00f4", "\u1ed3",
                "\u1ed1", "\u1ed9", "\u1ed5", "\u1ed7", "\u01a1", "\u1edd", "\u1edb", "\u1ee3", "\u1edf", "\u1ee1",
                "\u00f9", "\u00fa", "\u1ee5", "\u1ee7", "\u0169", "\u01b0", "\u1eeb", "\u1ee9", "\u1ef1", "\u1eed",
                "\u1eef", "\u1ef3", "\u00fd", "\u1ef5", "\u1ef7", "\u1ef9", "\u0111", "\u00c0", "\u00c1", "\u1ea0",
                "\u1ea2", "\u00c3", "\u00c2", "\u1ea6", "\u1ea4", "\u1eac", "\u1ea8", "\u1eaa", "\u0102", "\u1eb0",
                "\u1eae", "\u1eb6", "\u1eb2", "\u1eb4", "\u00c8", "\u00c9", "\u1eb8", "\u1eba", "\u1ebc", "\u00ca",
                "\u1ec0", "\u1ebe", "\u1ec6", "\u1ec2", "\u1ec4", "\u00cc", "\u00cd", "\u1eca", "\u1ec8", "\u0128",
                "\u00d2", "\u00d3", "\u1ecc", "\u1ece", "\u00d5", "\u00d4", "\u1ed2", "\u1ed0", "\u1ed8", "\u1ed4",
                "\u1ed6", "\u01a0", "\u1edc", "\u1eda", "\u1ee2", "\u1ede", "\u1ee0", "\u00d9", "\u00da", "\u1ee4",
                "\u1ee6", "\u0168", "\u01af", "\u1eea", "\u1ee8", "\u1ef0", "\u1eec", "\u1eee", "\u1ef2", "\u00dd",
                "\u1ef4", "\u1ef6", "\u1ef8", "\u0110"
            };
            var th = new[]
            {
                "a\u0300", "a\u0301", "a\u0323", "a\u0309", "a\u0303", "\u00e2", "\u00e2\u0300", "\u00e2\u0301",
                "\u00e2\u0323", "\u00e2\u0309", "\u00e2\u0303", "\u0103", "\u0103\u0300", "\u0103\u0301", "\u0103\u0323",
                "\u0103\u0309", "\u0103\u0303", "e\u0300", "e\u0301", "e\u0323", "e\u0309", "e\u0303", "\u00ea",
                "\u00ea\u0300", "\u00ea\u0301", "\u00ea\u0323", "\u00ea\u0309", "\u00ea\u0303", "i\u0300", "i\u0301",
                "i\u0323", "i\u0309", "i\u0303", "o\u0300", "o\u0301", "o\u0323", "o\u0309", "o\u0303", "\u00f4",
                "\u00f4\u0300", "\u00f4\u0301", "\u00f4\u0323", "\u00f4\u0309", "\u00f4\u0303", "\u01a1", "\u01a1\u0300",
                "\u01a1\u0301", "\u01a1\u0323", "\u01a1\u0309", "\u01a1\u0303", "u\u0300", "u\u0301", "u\u0323",
                "u\u0309", "u\u0303", "\u01b0", "\u01b0\u0300", "\u01b0\u0301", "\u01b0\u0323", "\u01b0\u0309",
                "\u01b0\u0303", "y\u0300", "y\u0301", "y\u0323", "y\u0309", "y\u0303", "\u0111", "A\u0300", "A\u0301",
                "A\u0323", "A\u0309", "A\u0303", "\u00c2", "\u00c2\u0300", "\u00c2\u0301", "\u00c2\u0323",
                "\u00c2\u0309", "\u00c2\u0303", "\u0102", "\u0102\u0300", "\u0102\u0301", "\u0102\u0323", "\u0102\u0309",
                "\u0102\u0303", "E\u0300", "E\u0301", "E\u0323", "E\u0309", "E\u0303", "\u00ca", "\u00ca\u0300",
                "\u00ca\u0301", "\u00ca\u0323", "\u00ca\u0309", "\u00ca\u0303", "I\u0300", "I\u0301", "I\u0323",
                "I\u0309", "I\u0303", "O\u0300", "O\u0301", "O\u0323", "O\u0309", "O\u0303", "\u00d4", "\u00d4\u0300",
                "\u00d4\u0301", "\u00d4\u0323", "\u00d4\u0309", "\u00d4\u0303", "\u01a0", "\u01a0\u0300", "\u01a0\u0301",
                "\u01a0\u0323", "\u01a0\u0309", "\u01a0\u0303", "U\u0300", "U\u0301", "U\u0323", "U\u0309", "U\u0303",
                "\u01af", "\u01af\u0300", "\u01af\u0301", "\u01af\u0323", "\u01af\u0309", "\u01af\u0303", "Y\u0300",
                "Y\u0301", "Y\u0323", "Y\u0309", "Y\u0303", "\u0110"
            };
            for (int i = 0; i < ds.Length; i++)
            {
                input = input.Replace(th[i], ds[i]);
            }
            return input;
        }
    }
}