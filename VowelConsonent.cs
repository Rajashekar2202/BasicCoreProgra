using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class VowelConsonent
    {
        public static void VowelOrConsonent()
        {
            
            Console.WriteLine("Enter a Letter");
            char c = Convert.ToChar(Console.Read());
            if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'||
               c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U' )
            {
                Console.WriteLine(c + " is Vowel");
            }
            else
            {
                Console.WriteLine(c + " is Consonent");
            }

        }
    }
}
