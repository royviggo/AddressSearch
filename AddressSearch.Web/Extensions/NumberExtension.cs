using System.Globalization;

namespace AddressSearch.Web.Extensions
{
    public static class NumberExtension
    {
        public static string ToDecimalString(this double value)
        {
            return value.ToString(new NumberFormatInfo { NumberDecimalSeparator = "." });
        }
    }
}
