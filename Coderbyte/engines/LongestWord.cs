
using System;
using System.Linq;

namespace Coderbyte.engines
{
    class LongestWord
    {

        public static string FindlongestWord(string data)
        {
            string word = "";
            int charcount = 0;

            data = new string(data.Where(c => !char.IsPunctuation(c)).ToArray()); //Strip Punctuation


            string[] words = data.Split(new[] { " " }, StringSplitOptions.None);
            
            foreach (string s in words)
            {
                if (s.Length > charcount)
                {
                    word = s;
                    charcount = s.Length;
                }
            }

            return word;
        }

    }
}
