using System;

namespace Coderbyte.engines
{
    class Integer
    {
        public static bool IsInteger(string data)
        {
            if (Utils.IsItNumber(data))
            {
                if (Int64.Parse(data) <= 2147483647) //largest integer
                {
                    return true;
                }

                return false;
            }
            
            return false;
        }
    }
}
