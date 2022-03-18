namespace Coderbyte
{
    class SCompression
    {
        public static string StringCompression(string data)
        {
            string result = "";
            char previous = data[0]; //what is our 1st character
            int count = 0;

            foreach (char c in data)
            {
                if (c == previous) //if next char = last char
                {
                    count++;
                }
                else //if a new char
                {
                    result += count.ToString() + previous.ToString();
                    previous = c;
                    count = 1;
                }
            }
            
            return result += count.ToString() + previous.ToString();
        }
    }
}
