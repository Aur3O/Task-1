using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Give points : ");
            string input = Console.ReadLine();
            int point;
            if (int.TryParse(input, out point))
            {
                int grade = -1;

                if ((point >= 0) && (point <= 19))
                {
                    grade = 0;
                }

                else if ((point >= 20) && (point <= 29))
                {
                    grade = 1;
                }

                else if ((point >= 30) && (point <= 39))
                {
                    grade = 2;
                }

                else if ((point >= 40) && (point <= 49))
                {
                    grade = 3;
                }

                else if ((point >= 50) && (point <= 59))
                {
                    grade = 4;
                }

                else if ((point >= 60) && (point <= 70))
                {
                    grade = 5;
                }

                Console.WriteLine("Your grade is : " + grade);
            }

            else { Console.WriteLine("Please enter a number."); }
        }
    }
}
