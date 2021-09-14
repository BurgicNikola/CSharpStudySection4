using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 50; counter += 5)
            {
                Console.WriteLine(counter);
            }
           

            // Odd numbers only
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
