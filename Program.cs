// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {

        static void Main(string[] args)
        {
            String[] studentName = new String[5]; // Name and corresponding grade have the same index number, ex: David (0), B (0)
            String[] studentGrade = new String[5];
            String[] gradeParameters = { "F", "D", "C", "B", "A" };
            int i = 0;
            Boolean done = false;
            do //ensures five inputs will be made
            {
                Console.WriteLine("Please enter the name of the student: (" + (5 - i) + " spaces left)");
                String rName = Console.ReadLine();

                while (!done)
                {
                    Console.WriteLine("Please enter the grade of the student from (A - F)");
                    String rGrade = Console.ReadLine();

                    if (gradeParameters.Any(rGrade.Contains))
                    {
                        studentGrade[i] = rGrade; // only after the grade has been checked both the grade and name are inserted.
                        studentName[i] = rName;
                        done = true; 
                    }
                    else
                        Console.WriteLine("Invalid input, please try again");
                }
            
                i++;
                done = false;
            } while (i < 5);

            for(int k = 0; k < 5; k++)
            {
                Console.WriteLine("Student name:" + studentName[k]);
                Console.WriteLine("Student grade:" + studentGrade[k]);
                Console.Write("--------------------------------------------");
            }

        }
    }
}
