using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_OOP_Problem
{
    public class StarPattern
    {
        public static void RightAngleTrangle()
        {
            Console.WriteLine("Please Enter Number for How much lines you want in Pattern");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
