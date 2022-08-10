using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class QuotientRemainder
    {

        public static void CalculateQuotientRemanider()
        {
            Console.Write("Enter a num1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a num2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int quotient = num1/num2;
            int remainder = num1 % num2;
           
            Console.WriteLine("Quotient ; " + quotient);
            Console.WriteLine("Remainder : " + remainder);  

        }
    }
}
