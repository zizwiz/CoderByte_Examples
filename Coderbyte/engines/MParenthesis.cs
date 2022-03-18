using System;

namespace Coderbyte.engines
{
    class MParenthesis
    {
        public static string MatchParenthesis(string data)
        {
            int count = 0;
            bool index = false;
            int[] OpenArray = new int[data.Length];
            int[] CloseArray = new int[data.Length];
            int OpenCount = 0;
            int CloseCount = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '(')
                {
                    OpenArray[OpenCount] = count;
                    OpenCount++;
                }
                else if (data[i] == ')')
                {
                    CloseArray[CloseCount] = count;
                    CloseCount++;
                }

                count++;
            }

            Array.Resize(ref OpenArray, OpenCount);
            Array.Resize(ref CloseArray, CloseCount);

           if ((CloseArray[0] > OpenArray[0]) && (CloseArray.Length == OpenArray.Length))
            {
                // Passed first checks of 
                        //We open before we close
                        //Closers and Openers are same amount

                //now check they are in pairs open before close but they can be nested.

                for (int i = 0; i < OpenArray.Length; i++)
                {
                    if (OpenArray[i] < CloseArray[i])
                    {
                        index = true;
                    }
                    else
                    {
                        index = false;
                    }
                }
            }

            return "Do all Parenthesis match = " + index;
        }
    }
}
