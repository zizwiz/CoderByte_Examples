using System;
using System.Windows.Forms;
using Coderbyte.engines;

namespace Coderbyte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbobx_questions.SelectedIndex = 0;
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            rchtxtbx_output.Clear();
            rchtxtbx_instructions.Clear();
          
            switch (cmbobx_questions.Text)
            {
                case "Question Marks":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "acc?7??sss?3rr1??????5";
                    }
                    rchtxtbx_output.AppendText(QMarks.QuestionMarks(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText(
                        "Questions Marks\r\rCreate a function to take the str string parameter, which will contain single digit " +
                        "numbers, letters, and question marks, and check if there are exactly 3 question marks between every pair of two numbers " +
                        "that add up to 10. If so, then your program should return the string true, otherwise it should return the string false." +
                        "If there aren't any two numbers that add up to 10 in the string, then your program should return false as well.\r" +
                        "For example: if str is \r\"arrb6???4xxbl5???eee5\"\r then your program should return true because there are exactly 3 " +
                        "question marks between 6 and 4, and 3 question marks between 5 and 5 at the end of the string." +
                        "\r \"aa6?9\" = false" +
                        "\r \"acc?7??sss?3rr1??????5\" = true");
                    break;
                case "Fizz Buzz":
                    rchtxtbx_output.AppendText(FBuzz.FizzBuzz());
                    rchtxtbx_instructions.AppendText("FizzBuzz\r\rPrint all of the numbers from 1 to 100. However, for any number divisible by three, " +
                                                     "print the word “Fizz,” for any number divisible by five, print the word “Buzz,” and for " +
                                                     "any number divisible by both three and five, print the word “FizzBuzz.");
                    break;
                case "Two Sum Problem":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "63";
                    }
                    rchtxtbx_output.AppendText(TSum.TwoSumProblem(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Two Sum Problem \r\rAn array of number 0 to 100 is given. You choose a number between 0 and 100 and determine " +
                                                     "if any two numbers within the array sum to your number.");
                    break;
                case "Remove Vowels":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "Hello World";
                    }
                    rchtxtbx_output.AppendText(RVowels.RemoveVowels(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Remove Vowels\r\rRemove all the vowels from a string.");
                    break;
                case "Match Parenthesis":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "(He)((llo)())";
                    }
                    rchtxtbx_output.AppendText(MParenthesis.MatchParenthesis(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText(
                        "Check if Valid Number of Parenthesis\r\rYou are given a string with the symbols ( and ), and" +
                        " you need to write a function that will determine if the parenthesis are correctly nested " +
                        "in the string, which means every opening ( has a closing ). The parenthesis can be nested.");
                    break;
                case "Is it an Integer":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "43";
                    }
                    rchtxtbx_output.AppendText(Integer.IsInteger(txtbx_data.Text).ToString());
                    rchtxtbx_instructions.AppendText("check if a number is an integer ? To determine if a number is a decimal or an integer, " +
                                                     "divide it by one and look for a remainder.\r\rExamples\r4 = true\r12.2 = false\r0.3 = false");
                    break;
                case "Kaprekars Constant":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "3524";
                    }
                    rchtxtbx_output.AppendText(KConstant.KaprekarsConstant(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Kaprekars Constant\r\rTake a 4-digit number with at least two distinct digits. " +
                                                     "Write a program to perform the following routine on the number: Arrange the digits in" +
                                                     "descending order and in ascending order (adding zeroes to fit it to a 4-digit number), " +
                                                     "and subtract the smaller number from the bigger number. Then repeat the previous step. " +
                                                     "Performing this routine will always cause you to reach a fixed number: 6174. Then " +
                                                     "performing the routine on 6174 will always give you 6174 (7641 - 1467 = 6174). Your " +
                                                     "program should return the number of times this routine must be performed until 6174 is " +
                                                     "reached.\r\r" +
                                                     "For example: if num is 3524 your program should return 3 because of the following steps: " +
                                                     "\r(1) 5432 - 2345 = 3087,\r(2) 8730 - 0378 = 8352,\r(3) 8532 - 2358 = 6174.");
                    break;
                case "Consecutive Numbers":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "486";
                    }
                    rchtxtbx_output.AppendText(ConNumbers.ConsecutiveNumbers(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Create a function to return the minimum number of integers needed to make the contents of" +
                                                     " input string consecutive from the lowest number to the highest number.\r\r" +
                                                     "For example: If arr contains [4, 8, 6] then the output should be 2 because two numbers need" +
                                                     " to be added to the array (5 and 7) to make it a consecutive array of numbers from 4 to 8. " +
                                                     "Negative numbers may be entered as parameters and no array will have less than 2 elements.");
                    break;
                case "Number Encoding":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "af5c a#!";
                    }
                    rchtxtbx_output.AppendText(NEncoding.NumberEncoding(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Number Encoding\r\rFor this challenge you will encode a given string following a specific " +
                                                     "rule. Encode every letter into its corresponding numbered position in the alphabet. Symbols" +
                                                     " and spaces will also be used in the input.\r\r" +
                                                     "For example: if str is \"af5c a#!\" then your program should return 1653 1#!.");
                    break;
                case "String Compression":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "wwwggopp";
                    }
                    rchtxtbx_output.AppendText(SCompression.StringCompression(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Data Compression\r\rFor this challenge you will determine the Run Length Encoding of a " +
                                                     "string. The function takes a string parameter being passed and returns a compressed version" +
                                                     " of the string using the Run-length encoding algorithm. This algorithm works by taking the " +
                                                     "occurrence of each repeating character and outputting that number along with a single " +
                                                     "character of the repeating sequence.\r\rFor example: \r\"wwwggopp\" would return 3w2g1o2p. " +
                                                     "\r\rThe input string will not contain any numbers, punctuation, or symbols.");
                    break;
                case "Prime Number":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "71";
                    }
                    rchtxtbx_output.AppendText(PrimeNumber.IsNumberPrime(txtbx_data.Text).ToString());
                    rchtxtbx_instructions.AppendText("Take a number and work out if it is a prime number or not. A prime number (or a prime) is a " +
                                                     "natural number greater than 1 that cannot be formed by multiplying two smaller natural " +
                                                     "numbers");
                    break;
                case "Alphabet Sorter":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "hello";
                    }
                    rchtxtbx_output.AppendText(ASorter.AlphabetSorter(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Take a string parameter being passed and return the string with the letters in " +
                                                     "alphabetical order (ie. hello becomes ehllo). Assume numbers and punctuation symbols" +
                                                     " will not be included in the string.");
                    break;
                case "Change Letters":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "hazard";
                    }
                    rchtxtbx_output.AppendText(LetterChanger.ChangeLetters(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Take a string str parameter being passed and modify it using the following algorithm. " +
                                                     "Replace every letter in the string with the letter following it in the alphabet (ie. c " +
                                                     "becomes d, z becomes a). Then capitalize every vowel in this new string (a, e, i, o, u) and " +
                                                     "finally return this modified string.");
                    break;
                case "Binary to Decimal":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "0111";
                    }
                    rchtxtbx_output.AppendText(BinToDec.ConvertBinToDec(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Convert a binary number (base 2) into a decimal number (base 10)");
                    break;
                case "StringToNumber 1":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "foursixminustwotwoplusonezero";
                    }
                    rchtxtbx_output.AppendText(StringToNumber2.ConvertStringToNumber2(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Take a string where the numbers are their names in words. There is also only minus and plus" +
                                                     "work out the equation and present the answer in words" +
                                                     "all numbers are positive although the answer can be negative so include this case as well" +
                                                     "\r\rexample:\r" +
                                                     "foursixminustwotwoplusonezero \r= 46 - 22 + 10 \r= 34 \r= threefour");
                    break;
                case "StringToNumber 2":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "foursixminustwotwoplusonezero";
                    }
                    rchtxtbx_output.AppendText(StringToNumber2.ConvertStringToNumber2(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("Take a string where the numbers are their names in words. There is also only minus and plus" +
                                                     "work out the equation and present the answer in words" +
                                                     "all numbers are positive although the answer can be negative so include this case as well" +
                                                     "\r\rexample:\r" +
                                                     "foursixminustwotwoplusonezero \r= 46 - 22 + 10 \r= 34 \r= threefour");
                    break;
                case "Find Longest Word":
                    if (!chkbx_use_own_data.Checked)
                    {
                        txtbx_data.Text = "2 Ginger cats sit, on 1 red chair.";
                    }
                    rchtxtbx_output.AppendText(LongestWord.FindlongestWord(txtbx_data.Text));
                    rchtxtbx_instructions.AppendText("write a function that takes in a string and returns the longest word in the string. " +
                                                     "If two words are the same size then it asks to return the first one. The input will never " +
                                                     "be empty. Ignore any punctuation, words can also contain numbers");
                    break;




            }
        }


    }
}
