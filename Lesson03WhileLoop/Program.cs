using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson03WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("----------------------------");

            // By pressing enter this program counts how many students have entered the class. There are 30 students that should attend the class.
            counter = 0;
            Console.WriteLine("Press enter for every student that enters the class.");
            while (counter < 30)
            {
                Console.ReadLine();
                counter++;
                Console.Write(counter);
            }

            Console.ReadLine();

        }
    }
}
