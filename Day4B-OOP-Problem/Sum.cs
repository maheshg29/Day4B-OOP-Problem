using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_OOP_Problem
{
    public class Sum
    {
        public static void SumOfDigit()
        {
            Console.WriteLine("Please Enter Number For Sum of Each Digit");
            int value = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int remainder=0;
            while (value != 0)
            {
                remainder = value % 10;
                sum += remainder;
                value /= 10;
            }
            Console.WriteLine("Sum of Each Digit of Given number is "+sum);
        }
    }
}
