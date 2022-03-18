using System;

namespace Coderbyte.engines
{
    class BinToDec
    {

        public static string ConvertBinToDec(string data)
        {
            return Convert.ToInt64(data, 2).ToString();
        }
    }
}
