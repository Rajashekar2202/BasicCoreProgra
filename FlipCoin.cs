using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
        public static void CalculatePercentage()
        {
            int headcount = 0;
            int tailcount = 0;
            double headpercentage;
            double tailpercentage;

            Console.WriteLine("Please enter the value for number of filp");
            int filpCoin = Convert.ToInt32(Console.ReadLine());

            if( filpCoin > 0 )
            {
                for(int i=0; i < filpCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    Console.WriteLine("the filp is " + number);

                    if ( number == 1 )
                    {
                        headcount++;
                    }
                    else
                    {
                        tailcount++;
                    }
                }
                headpercentage = headcount * 100 / filpCoin;
                tailpercentage = tailcount * 100 / filpCoin;    

                Console.WriteLine("Thr head Percentage is " + headpercentage);
                Console.WriteLine("The tail Percentage is " + tailpercentage);  

            }
            else
            {
                Console.WriteLine("Please enter the Positive Number");
                
            }


        }
    }
}
