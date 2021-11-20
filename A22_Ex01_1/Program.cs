using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex01_1
{

    class MainClass
    {
        public static void Main()
        {
            RunEx1();
        }

        public static void RunEx1()
        {
            Console.WriteLine("Please Enter a valid 8 digits binary number");

            Console.WriteLine("Enter 1th num");
            int num1 = ReadBinaryInputFromUer();
            PrintStatisticsForEx01_A(num1);
            Console.WriteLine("Enter 2th num");
            int num2 = ReadBinaryInputFromUer();
            PrintStatisticsForEx01_A(num2);
            Console.WriteLine("Enter 3th num");
            int num3 = ReadBinaryInputFromUer();
            PrintStatisticsForEx01_A(num3);
            Console.WriteLine("Enter 4th num");
            int num4 = ReadBinaryInputFromUer();
            PrintStatisticsForEx01_A(num4);
            int[] arrayOfNumbers = new int[] { num1, num2, num3, num4 };
            Console.WriteLine("==================================================");
            Console.WriteLine("Greatest input =");
            Console.WriteLine(FindGreatestNumber(arrayOfNumbers));
            Console.WriteLine("==================================================");
        }
        public static int ReadBinaryInputFromUer()
        {

            string user_input = Console.ReadLine();
            while (!IsBinary(int.Parse(user_input)) || string.IsNullOrEmpty(user_input.ToString()) || user_input.Length != 8)
            {
                Console.WriteLine("Invalid input , Try Again :");
                Console.WriteLine("Please Enter a valid 8 digits binary number");
                user_input = Console.ReadLine();
            }  
            return int.Parse(user_input);

        }

        public static int FindGreatestNumber(int[] numbers)
        {
            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static void PrintStatisticsForEx01_A(int num)
        {
            if (!IsBinary(num))
            {
                Console.WriteLine("==================NT BINARY======================");
                return;
            }
            Console.WriteLine("==================================================");
            Console.WriteLine("Base 2=" + num);
            Console.WriteLine("Base 10=" + ToDecimal(num));
            Console.WriteLine("Num of Zeros =" + CountZerosAndOnes(num)["zeros"]);
            Console.WriteLine("Num of Ones =" + CountZerosAndOnes(num)["ones"]);
            Console.WriteLine("Is Power of 2 = " + IsPowOf2(ToDecimal(num)));
            Console.WriteLine("Is Increrasing series = " + IsIncreasingSeri(ToDecimal(num)));
            Console.WriteLine("==================================================");
}

        //1234
        public static bool IsIncreasingSeri(int num)
        {
            while (num >= 10)
            {
                int lastTwoDigits = num % 100;
                int a2 = lastTwoDigits % 10;
                int a1 = (lastTwoDigits / 10) % 10;
                if (a2 <= a1)
                {
                    return false;
                }
                num /= 10;
            }
            return true;
        }
       public static double GetBaseLog(int x, int y)
        {
            return Math.Log(y) / Math.Log(x);
        }

        public static bool IsPowOf2(int num)
        {
            return Math.Ceiling(GetBaseLog(2, num)) == Math.Floor(GetBaseLog(2, num));
        }

        public static IDictionary<string, int> CountZerosAndOnes(int bin)
        {
            IDictionary<string, int> kvp = new Dictionary<string, int>();
            int ones_counter = 0;
            int zeros_counter = 0;
            while (bin >= 10)
            {
                int currentDig = bin % 10;
                if (currentDig == 1)
                {
                    ones_counter += 1;
                }
                else if (currentDig == 0)
                {
                    zeros_counter += 1;
                }
                bin /= 10;


            }
            if (bin == 1)
            {
                ones_counter += 1;
            }
            else if (bin == 0)
            {
                zeros_counter += 1;
            }

            kvp.Add("zeros", zeros_counter);
            kvp.Add("ones", ones_counter);
            return kvp;

        }

        public static int ToDecimal(int binaryNum)
        {
            int sum = 0;
            int exponent = 0;
            int currentDigit;


            while (binaryNum >= 10)
            {
                currentDigit = binaryNum % 10;
                if (currentDigit == 1)
                {
                    sum += (int)Math.Pow(2, exponent);
                }
                binaryNum /= 10;
                exponent += 1;
            }

            sum += binaryNum * (int)Math.Pow(2, exponent);
            return sum;
        }



        public static bool IsBinary(int binNumber)
        {
            int lastDig;
            while (binNumber >= 10)
            {
                lastDig = binNumber % 10;
                if (lastDig != 1 && lastDig != 0)
                {
                    return false;
                }
                binNumber /= 10;
            }
            if (binNumber != 0 && binNumber != 1)
            {
                return false;
            }
            return true;
        }
    }
}
