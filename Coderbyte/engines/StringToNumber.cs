using System.Collections.Generic;

namespace Coderbyte.engines
{
    class StringToNumber
    {

        public static string ConvertStringToNumber(string data)
        {
            string[] NumWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string Num1 = "";
            string Num2 = "";
            string result = "";

            //parse string to extract the numbers
            foreach (char c in data.ToLower())
            {
                Num1 += c;

                switch (Num1)
                {
                    case "zero":
                        Num2 += "0";
                        Num1 = "";
                        break;
                    case "one":
                        Num2 += "1";
                        Num1 = "";
                        break;
                    case "two":
                        Num2 += "2";
                        Num1 = "";
                        break;
                    case "three":
                        Num2 += "3";
                        Num1 = "";
                        break;
                    case "four":
                        Num2 += "4";
                        Num1 = "";
                        break;
                    case "five":
                        Num2 += "5";
                        Num1 = "";
                        break;
                    case "six":
                        Num2 += "6";
                        Num1 = "";
                        break;
                    case "seven":
                        Num2 += "7";
                        Num1 = "";
                        break;
                    case "eight":
                        Num2 += "8";
                        Num1 = "";
                        break;
                    case "nine":
                        Num2 += "9";
                        Num1 = "";
                        break;
                    case "plus":
                        Num2 += "+";
                        Num1 = "";
                        break;
                    case "minus":
                        Num2 += "-";
                        Num1 = "";
                        break;
                }
            }

            //do the maths
           Num1 = DoMaths(Num2);


            //convert back to words
            foreach (char c in Num1)
            {
                if (c != '-')
                {
                    result += NumWords[int.Parse(c.ToString())];
                }
                else
                {
                    result = "negative";
                }
            }


            return result;
        }

        public static string DoMaths(string data)
        {
            data = data + ")"; //add so we know we got to the end
           
            List<string> NumbersList = new List<string>();
            List<string> OperatorsList = new List<string>();

            double result = 0;
            string value = "";
            bool flag = false;

            //parse string to extract the numbers
            foreach (char c in data.ToLower())
            {
                switch (c)
                {
                    case '+':
                        NumbersList.Add(value);
                        value = "";
                        flag = true;
                        OperatorsList.Add("+");
                        break;

                    case '-':
                        NumbersList.Add(value);
                        value = "";
                        flag = true;
                        OperatorsList.Add("-");
                        break;

                    case ')':
                        NumbersList.Add(value);


                        string[] Numbers = NumbersList.ToArray();
                        string[] operators = OperatorsList.ToArray();

                        result = double.Parse(Numbers[0]);

                        for (int i = 0; i < operators.Length; i++)
                        {
                            double num1 = double.Parse(Numbers[i+1]);
                            string op = operators[i];

                            if (op.Equals("+")) result += num1;
                            else if (op.Equals("-")) result -= num1;


                        }
                        break;
                }

                if (!flag)
                {
                    value += c;
                }
                else
                {
                    flag = false;
                }
            }
            
            return result.ToString();
        }


    }
}
