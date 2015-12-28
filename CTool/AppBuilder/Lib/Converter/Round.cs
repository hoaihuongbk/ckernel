using System;

namespace Toyota.Financial.Core.Converter
{
    public static class Round
    {
        public static double RoundUp(double tdNumber, int tiPlaces)
        {
            return RoundOff(tdNumber + (0.49 * Math.Pow(10, (tiPlaces * -1))), tiPlaces);
        }
        public static double RoundOff(double tdNumber, int tiPlaces)
        {
            return Conversion.Int((tdNumber * Math.Pow(10, tiPlaces)) + 0.5) / Math.Pow(10, tiPlaces);
        }
        public static double RoundDown(double tdValue)
        {
            double functionReturnValue = 0;
            dynamic tiX = null;
            tiX = Strings.InStr(1, Convert.ToString(tdValue), ".");
            functionReturnValue = tiX != 0 ? Conversion.Val(Strings.Mid(tdValue.ToString(), 1, tiX)) : tdValue;
            return functionReturnValue;
        }
    }
}
