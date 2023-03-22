using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4B_OOP_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Day 4B- Object Orianted Problem");
            Console.WriteLine("Please Select any one option \n 1. Count of total number of duplicate elements\n" +
                " 2. To find Unique Element\n 3.count the frequency of each element");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    DuplicateElement.DuplicateIntElement();
                    break;

                case 2:
                    UniqueElements.UniqueIntElement();
                    break;
                case 3:
                    DuplicateElement.FrequencyOfIntElement();   
                    break;
                default:
                    Console.WriteLine("Please Select Right option from Given");
                    break;
            }
        }
    }
}
