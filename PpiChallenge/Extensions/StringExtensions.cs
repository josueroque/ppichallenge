using System.Globalization;
namespace PpiChallenge.Extensions
{
    public static class StringExtensions
    {
        public static string FormatPhoneNumber(this string val)
        {
            var formattedPhone = string.Empty;

            if (!string.IsNullOrWhiteSpace(val))
            {
                formattedPhone = Convert.ToInt64(val, CultureInfo.CurrentCulture).ToString("(###) ###-####", CultureInfo.CurrentCulture);
            }

            return formattedPhone;
        }
    }
}
