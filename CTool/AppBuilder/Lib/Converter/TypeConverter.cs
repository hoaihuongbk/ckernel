using System;

namespace Toyota.Financial.Core.Converter
{
    public static class TypeConverter
    {
        public static decimal ToDecimal(object d)
        {
            try
            {
                return Convert.ToDecimal(d);
            }
            catch
            {
                return 0;
            }
        }

        public static int ToInt(object i)
        {
            try
            {
                return Convert.ToInt32(i);
            }
            catch
            {
                return 0;
            }
        }

        public static short ToShort(object i)
        {
            try
            {
                return Convert.ToInt16(i);
            }
            catch
            {
                return Convert.ToInt16(0);
            }
        }
    }
}