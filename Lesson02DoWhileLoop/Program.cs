using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson02DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);

            Console.WriteLine("--------------------");

            counter = 15;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);

            Console.WriteLine("--------------------");
            string allNames = "";
            int allNamesLength = 0;

            do
            {
                Console.WriteLine("Please enter a name of a friend: ");
                string friendName = Console.ReadLine();
                int nameLength = friendName.Length;
                allNames += friendName + " ";
                allNamesLength += nameLength;
            } while (allNamesLength < 30);
            Console.WriteLine("Thanks, that was enough. Names: " + allNames);

            Console.Read();
        }
    }
}
