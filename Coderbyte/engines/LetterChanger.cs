namespace Coderbyte.engines
{
    class LetterChanger
    {
        public static string ChangeLetters(string data)
        {
            string answer = "";
            string reply = "";
           
            foreach (char c in data)
            {
                if (c != 'z')
                {
                  answer += ((char)(((int)char.Parse(c.ToString())) + 1)).ToString();
                }
                else
                {
                    answer += 'a';
                }
            }

            foreach (char c in answer)
            {

                if ((c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u'))
                {
                    reply += c.ToString().ToUpper();
                }
                else
                {
                    reply += c.ToString();
                }
            }

            return reply;
        }
    }
}
