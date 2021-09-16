using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson05Challenge
{
    /* Imagine you are a developer and get a job in which you need to create a program for a teacher. 
     * He needs a program written in C# that calculates the average score of his students. 
     * So he wants to be able to enter each score individually and then get the final average score once he enters -1.
     * So the tool should check if the entry is a number and should add that to the sum. Finally once he is done entering scores,
     * the program should write onto the console what the average score is. 
     * The numbers entered should only be between 0 and 20. Make sure the program doesn't crash if the teacher enters an incorrect value.
     * Test your program thoroughly.*/
    class Program
    {
        static void Main(string[] args)
        {
            double studentGrade = 0;
            double sum = 0;
            int numberOfStudents = 0;

            Console.WriteLine("Please enter your student's grade and press Enter. Repeat for every student. " +
                               "\nTo end the program and calculate the average score, enter -1 and press Enter.");

            // Stay in the loop until -1 is entered
            while(studentGrade != -1)
            {
                // Check if user entered a number. If yes, convert that string to a double. If not, isNumber is false
                bool isNumber = double.TryParse(Console.ReadLine(), out studentGrade);
                // In case the entered value is not a number, alert the user and enable another input.
                if(!isNumber)
                {
                    Console.WriteLine("Please enter a number value.");
                    continue;
                }
                // Stop the loop in case the entered value is -1
                else if (studentGrade == -1)
                {
                    break;
                }
                // In case the entered value is not in range 0 - 20, alert the user and enable another input.
                else if (studentGrade < 0 || studentGrade > 20)
                {
                    Console.WriteLine("Please enter a number from 0 to 20");
                    continue;
                }
                // Add the student's grade to the sum of all grades and increase the number of students whose grade has been added to the program.
                else
                {
                    sum += studentGrade;
                    numberOfStudents++;
                }
            }
            Console.WriteLine($"There are {numberOfStudents} students, and the average score of the class is {sum / numberOfStudents}.");
            Console.ReadLine();
        }
    }
}
