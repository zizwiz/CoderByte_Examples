using System;

namespace Coderbyte.engines
{
    class PrimeNumber
    {
        public static bool IsNumberPrime(string data)
        {

            Int64 Num1 = Int64.Parse(data);

            if (Num1 == 1) return false;
            if (Num1 == 2) return true;

            double limit = Math.Ceiling(Math.Sqrt(Num1));

            for (int i = 2; i <= limit; ++i)
            {
                if (Num1 % i == 0) return false;

            }

            return true;
        }
    }
}
