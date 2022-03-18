namespace Coderbyte.engines
{
    class NEncoding
    {
        public static string NumberEncoding(string data)
        {
            string answer = "";
            int value = 0;

           foreach (char c in data)
            {
                // Get ASCII value of the character
                value = (int)char.Parse(c.ToString().ToLower());

                //If between a-z work out position
                if ((value > 96) && (value < 123))
                {
                    answer += (value-96).ToString();
                }
                else //just add raw char
                {
                    answer += c.ToString();
                }
            }

            return answer;
        }
    }
}
