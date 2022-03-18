using System;

namespace Coderbyte.engines
{
    class ConNumbers
    {
        public static string ConsecutiveNumbers(string data)
        {
            int count = 0;

            if (Utils.IsItNumber(data))
            {
                char[] charArray = data.ToCharArray();
                Array.Sort(charArray);
                Array.Reverse(charArray);
                
                for (int i = 0; i < charArray.Length - 1; i++)
                {
                    int num1 = int.Parse(charArray[i].ToString());
                    int num2 = int.Parse(charArray[i + 1].ToString());

                    while (num2+1 < num1)
                    {
                        num2++;
                        count++;
                    }
                }
            }

            return count.ToString();
        }
    }
}
