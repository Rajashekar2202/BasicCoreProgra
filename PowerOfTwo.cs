using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class PowerOfTwo
    {
        public static void PowerOfTheTwo()
        {
            Console.Write("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0 && num < 31)
            {
                for (int i = 0; i <= num; i++)
                {
                    Console.WriteLine(Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Enter the Number between upto 31 only ");
            }
        }
    }
}
