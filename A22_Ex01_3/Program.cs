using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex01_3
{
    class MainClass
    {
        public static void Main()
        {
            RunEx3();

        }

        public static void RunEx3()
        {
            PrintSandclockByUserInputHeight();
            Console.WriteLine("Press Any key to quit");
            Console.ReadLine();
        }



        public static int GetUserInput()
        {
            Console.WriteLine("Enter an integer as the height of the sandclock:");
            string usersInputSandclockHeight = Console.ReadLine();
            bool userInputIsInt = int.TryParse(usersInputSandclockHeight, out int userInputAsInteger);
            while (!userInputIsInt)
            {
                Console.WriteLine("You entered an invalid integer\n");
                Console.WriteLine("Enter an integer as the height of the sandclock:");
                usersInputSandclockHeight = Console.ReadLine();
                userInputIsInt = int.TryParse(usersInputSandclockHeight, out userInputAsInteger);
            }
            return userInputAsInteger;

        }

        public static void PrintSandclockByUserInputHeight()
        {
            int userInput = GetUserInput();
            if (userInput % 2 == 0)
            {
                A22_Ex01_2.MainClass.RecursivePrintSandclock(userInput + 1, 0);
                return;
            }
            A22_Ex01_2.MainClass.RecursivePrintSandclock(userInput, 0);

        }
    }
}
