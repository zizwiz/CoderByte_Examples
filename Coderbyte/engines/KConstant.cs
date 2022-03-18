using System;

namespace Coderbyte.engines
{
    class KConstant
    {
        public static string KaprekarsConstant(string data)
        {
            string answer = "Check input number is correct";
            int count = 0;
            int result = 0; //needs to = 6174 at the end

            if ((Utils.IsItNumber(data)) && (data.Length == 4))
            {
                do
                {
                    char[] charArray = data.ToCharArray();
                    Array.Sort(charArray);
                    int num1 = int.Parse(new string(charArray));


                    Array.Reverse(charArray);
                    int num2 = int.Parse(new string(charArray));

                    result = num2 - num1;

                    data = result.ToString();
                    count++;

                } while (result != 6174);

            }

            return "Number of interations = " + count.ToString();
        }
    }
}
