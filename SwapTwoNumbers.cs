using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwapTwoNumbers
    {
        public static void SwapTheTwoNumbers()
        {
            Console.Write("Enter Number1: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c;

            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swapping Num1: " + a);
            Console.WriteLine("After swapping Num2: " + b);

        }
    }
}
