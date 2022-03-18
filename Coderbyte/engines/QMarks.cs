using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte
{
    class QMarks
    {
        public static string QuestionMarks(string str)
        {
            char[] charArray = str.ToCharArray();
            bool flag = false;
            int num1 = 0;
            int count = 0;
            string MyAnswer = "?";

            foreach (char ch in charArray)
            {

                if (Utils.IsItNumber(ch.ToString()))
                {
                    if (!flag)
                    {
                        num1 = int.Parse(ch.ToString());
                        flag = true;
                        count = 0;
                    }
                    else
                    {
                        int num2 = int.Parse(ch.ToString());
                        flag = false;

                        if ((num1 + num2 == 10) && (count == 3))
                        {
                            if ((MyAnswer != "false\r") || (MyAnswer == "?"))
                            {
                                MyAnswer = "true\r";
                            }
                            else
                            {
                                MyAnswer = "false\r";
                            }
                        }
                        else if ((num1 + num2 == 10) && (count != 3))
                        {
                            MyAnswer = "false\r";
                        }

                        count = 0;
                    }
                }
                else
                {
                    if (ch == '?')
                    {
                        count++;
                    }
                }
            }

            if (MyAnswer == "?") MyAnswer = "false\r";

            return MyAnswer;
        }
    }
}
