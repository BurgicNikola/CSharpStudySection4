using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i == 4)
                {
                    Console.WriteLine("We stop here.");
                    // Break out of the for loop
                    break;
                }
            }
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < 10; i++)
            {
                
                if (i == 3)
                {
                    Console.WriteLine("We skip this.");
                    // Go back to the beginning of the loop without going through the rest of the code in the loop
                    continue; ;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
