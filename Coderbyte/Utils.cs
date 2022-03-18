using System.Text.RegularExpressions;

namespace Coderbyte
{
    class Utils
    {

        public static bool IsItNumber(string data)
        {
            return Regex.IsMatch(data, @"^\d+$");
        }

    }
}
