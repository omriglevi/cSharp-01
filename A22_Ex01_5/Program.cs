using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex01_5
{








    class MainClass
    {
       
        public static void Main()
        {
            RunEx5();
           
        }



        public static void RunEx5()
        {
            Console.WriteLine("Yalla Ex5");
            int userInput = GetUserInput();
            Console.WriteLine("Greatest User Input=" + FindGreatestDigit(userInput));
            Console.WriteLine("Avg Sum of digits= " + SumDigsAvg(userInput));
            Console.WriteLine("Number of digits that divides by3=" + CountHowManyDigitsDevidesBy3(userInput));
            Console.WriteLine("Number of digits that are smaller than the rightest digit=" + CountDigsThatAreSmallerThenRightestDig(userInput));
            Console.WriteLine("Press Any key to quit");
            Console.ReadLine();

        }

        public static int CountHowManyDigitsDevidesBy3(int num)
        {
            int counter = 0;
            while (num > 9)
            {
                if ((num % 10) % 3 == 0)
                {
                    counter += 1;
                }
                num /= 10;
            }
            if (num % 3 == 0)
            {
                counter += 1;
            }
            return counter;
        }

        public static int CountDigsThatAreSmallerThenRightestDig(int num)
        {
            int counter = 0;
            int dig = num % 10;

            if (num <= 9)
            {
                return counter;
            }
            num /= 10;


            while (num > 9)
            {
                if (num % 10 < dig)
                {
                    counter += 1;
                }
                num /= 10;

            }

            return num < dig ? counter + 1 : counter;
        }


        public static int FindGreatestDigit(int num)
        {
            int max = 0;
            while (num > 10)
            {
                if (num % 10 > max)
                {
                    max = num % 10;
                }
                num /= 10;
            }
            if (num % 10 > max)
            {
                max = num % 10;
            }
            return max;
        }

        public static bool IsValidInput(int num)
        {
            return (num.ToString().Length == 7 && num >= 0);
        }



        public static int SumDigs(int num)
        {
            if (num < 10)
            {
                return num;
            }
            int dig = num % 10;
            return dig + SumDigs(num / 10);

        }
        public static int SumDigsAvg(int num)
        {
            return SumDigs(num) / num.ToString().Length;

        }

        public static int GetUserInput()
        {
            Console.WriteLine("Enter a 7 digit integer");
            string userInput = Console.ReadLine();
            
            bool isInputValidAsString = int.TryParse(userInput, out int userInputAsInt);

            while (!isInputValidAsString)
            {
                Console.WriteLine("Enter a 7 digit integer");
                userInput = Console.ReadLine();
                isInputValidAsString = int.TryParse(userInput, out userInputAsInt);

            }
            return userInputAsInt;
        }



    }















}
