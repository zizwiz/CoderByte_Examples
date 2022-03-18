namespace Coderbyte.engines
{
    class RVowels
    {
        public static string RemoveVowels(string data)
        {
            string answer = "";
            string str = "aeiou";

            foreach (char c in data)
            {
                if (!str.Contains(c.ToString().ToLower()))
                {
                    answer += c;
                }
            }

            return answer;
        }
    }
}
