namespace Coderbyte
{
    class TSum
    {

        public static string TwoSumProblem(string data)
        {
            int _sumNum = 0;

            if (Utils.IsItNumber(data))
            {
                _sumNum = int.Parse(data);
            }
            else
            {
                return "Entered data needs to be Integer";
            }

            string answer = "";
            int[] Data = new int[100];

            for (int i = 0; i <100; i++)
            {
                Data[i] = i;
            }
            
            for (int i = 0; i < 100; i++)
            {
                int num1 = Data[i];

                for (int j = i; j < 100; j++)
                {
                    int num2 = Data[j];
                    
                    if (num1 + num2 == _sumNum)
                    {
                        answer += i + " + " + j + " = " + _sumNum + "\r";
                    }
                }
            }
            
            if (answer == "") answer = "Nothing in the array adds up to " + _sumNum;
            
            return answer;
        }
    }
}
