using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        public static void HormonicSeries()
        {
            int i, n;
            double s = 0.0;
            Console.WriteLine("input the number of terms:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("1/{0} +", i);
                s += 1 / (float)i;
            }
        }
    }
}
