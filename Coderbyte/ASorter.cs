using System;

namespace Coderbyte
{
    class ASorter
    {
        public static string AlphabetSorter(string data)
        {
            char[] CharArray = data.ToCharArray();
            Array.Sort(CharArray);
           
            return new string(CharArray);
        }



    }
}
