using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LeapYear
    {
        public static void CheckLeapYear()
        {
            int year;
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 ==0) && (year % 100 !=0)) || (year % 400 ==0))
            {
                Console.WriteLine("Given year is Leap year");
            }
            else
            {
                Console.WriteLine("Given year is not a Leap year");
            }



        }
    }
}
