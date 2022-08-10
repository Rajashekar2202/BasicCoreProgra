using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Factors
    {
        public static void PrimeFactors()
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int value;   
            Console.WriteLine("Factors of " + num + " is " );
            for (value = 2; value * value <= num; value++)
            {
                while(num % value == 0)
                {
                    Console.WriteLine(value + ",");
                    num = num / value;
                }
            }
        }
    }
}
