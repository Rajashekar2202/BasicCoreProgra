using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LargestNumber
    {
        public static void LargestOfNumber()
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + " is largest number ");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is largest number");
            }
            else
            {
                Console.WriteLine(num3 + " is largest number");
            }
        }
    }
}
