using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22_Ex01_2
{
    public class MainClass
    {
        public static void Main()
        {

            RunEx2();

        }

        public static void RunEx2()
        {
            Console.WriteLine("Yalla Ex2!");
            RecursivePrintSandclock(5, 0);
            Console.WriteLine("Press Any key to quit");
            Console.ReadLine();
        }

        public static void RecursivePrintSandclock(int width, int cur_iteration)
        {
            int mid = (int)Math.Floor((double)width / 2);

            if (cur_iteration <= mid)
            {
                PrintSandRow(width, width - (cur_iteration * 2));

            }
            else if (cur_iteration >= mid)
            {
                int formula = width - (2 * (mid - (cur_iteration - mid)));

                PrintSandRow(width, formula);
                if (cur_iteration + 1 == width)
                {
                    return;
                }
            }
            RecursivePrintSandclock(width, cur_iteration + 1);

        }

        public static void PrintSandRow(int width, int numOfStarsInARow)
        {
            StringBuilder sb = new StringBuilder(width);
            int left, right;
            int numOffEmptyCellsEachSide = (width - numOfStarsInARow) / 2;

            for (int i = 0; i < width; i++)
            {
                sb.Append("*");
            }
            if (numOffEmptyCellsEachSide == 0)
            {
                Console.WriteLine(sb.ToString());
                return;
            }

            left = 0;
            right = width - 1;


            for (int i = 0; i < numOffEmptyCellsEachSide; i++)
            {
                sb[left] = char.Parse(" ");
                sb[right] = char.Parse(" ");
                left += 1;
                right -= 1;

            }
            Console.WriteLine(sb.ToString());
            return;
        }




    }

}
