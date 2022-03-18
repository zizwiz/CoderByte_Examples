namespace Coderbyte
{
    class FBuzz
    {

        public static string FizzBuzz()
        {
            string Reply = "";

            for (int i = 1; i <= 100; i++)
            {
                string answer = i.ToString();
                
                if (i % 3 == 0)
                {
                    answer = "Fizz";
                }

                if (i % 5 == 0)
                {
                    if (answer == "Fizz") answer += "Buzz";
                    else answer = "Buzz";
                }

                Reply += answer + "\r";
            }
            
            return Reply;
        }
    }
}
