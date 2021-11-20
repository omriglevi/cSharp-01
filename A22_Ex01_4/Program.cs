using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex01_4
{
    
        class MainClass
        {
            public static void Main()
            {
            RunEx4();

            }


        public static void RunEx4()
        {
            AnalyzeString();
            Console.WriteLine("Press Any key to quit");
            Console.ReadLine();
        }

            public static void AnalyzeString()
            {
                string userInput = GetUserInput();
                Console.WriteLine("Is plyndrom = "+IsPlyndrom(userInput));
                if (!IsPureIntegersString(userInput))
                {
                    Console.WriteLine("Upper case chars="+CountUpperCaseLetters(userInput));
                    return;
                }
                Console.WriteLine("Does Divide by 4="+DoesDividesBy4(int.Parse(userInput)));

            }




            public static string GetUserInput()
            {
                Console.WriteLine("Enter  string that contains 6 characters ");

                string userInput = Console.ReadLine();
                while (!IsValidInput(userInput))
                {
                    Console.WriteLine("You entered an invalid input . Please try again .");
                Console.WriteLine("Enter  string that contains 6 characters :");

                userInput = Console.ReadLine();
                }

                return userInput;
            }

            public static bool IsValidStringLength(string str)
            {
                return str.Length == 6;
            }
            public static bool IsValidInput(string str)
            {
                return (IsValidStringLength(str) &&
                (IsPureEnglishString(str) || IsPureIntegersString(str)));

            }


            public static int CountUpperCaseLetters(string str)
            {
                int upperCaseLettersCounter = 0;
                StringBuilder sb = new StringBuilder(str);
                for (int i = 0; i < sb.Length; i++)
                {
                    if (Char.IsUpper(sb[i]))
                    {
                        upperCaseLettersCounter++;
                    }
                }
                return upperCaseLettersCounter;
            }




            public static bool IsPureEnglishString(string str)
            {
                StringBuilder sb = new StringBuilder(str);

                for (int i = 0; i < sb.Length; i++)
                {
                    if (!Char.IsLetter(sb[i]))
                    {
                        return false;
                    }
                }
                return true;
            }


            public static bool IsPureIntegersString(string str)
            {
                StringBuilder sb = new StringBuilder(str);

                for (int i = 0; i < sb.Length; i++)
                {
                    if (!char.IsNumber(sb[i]))
                    {
                        return false;
                    }
                }
                return true;
            }



            public static bool DoesDividesBy4(int num)
            {
                return num % 4 == 0;
            }



            public static bool IsPlyndrom(string str)

            {
                StringBuilder sb = new StringBuilder(str);
                if (sb.Length <= 2)
                {
                    if (sb.Length == 1)
                    {
                        return true;
                    }
                    if (sb[0] == sb[1])
                    {
                        return true;
                    }
                    return false;
                }
                if (sb[0] != sb[sb.Length - 1])
                {
                    return false;
                }
                sb.Remove(0, 1);
                sb.Remove(sb.Length - 1, 1);
                return IsPlyndrom(sb.ToString());

            }
        }
    
}
