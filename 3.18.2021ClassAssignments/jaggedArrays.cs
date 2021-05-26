using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._18._2021ClassAssignments
{
    class jaggedArrays //created a class to seperate th emain code space
    {
        

        public static void fillGrades() //making a function callable in main
        {
            char[][] studentgrades = new char[5][]; //setting up a jagged array 
            Console.WriteLine("Hello! Let's get some grade inputs for these 5 students.");
            Console.WriteLine("How many classes do you have a grade for, for student one?");
            int stugrades = Convert.ToInt32(Console.ReadLine()); //letting th eperson pick how many grades a student has
            Console.WriteLine("Great, student 1 took {0} classes! Now let's get grades for each class.", stugrades);
            studentgrades[0]= new char[stugrades]; //initializing the array based on user input
            for(int i = 0; i < studentgrades[0].Length; i++) //taking the grade input and storing in the array
            {
                Console.Write("Please input a single character grade for the student! ");
                studentgrades[0][i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Student 1's grades are as follows:"); //outputting the grades 
            for(int b = 0; b <studentgrades[0].Length; b++)
            {
                Console.Write(studentgrades[0][b] + " ");
            }
            Console.WriteLine();
            //just used these for breaks, basically same code as above but with each array changed to match the student
            Console.WriteLine("How many classes do you have a grade for, for student two?");
            stugrades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great, student 2 took {0} classes! Now let's get grades for each class.", stugrades);
            studentgrades[1] = new char[stugrades];
            for (int i = 0; i < studentgrades[1].Length; i++)
            {
                Console.Write("Please input a single character grade for the student! ");
                studentgrades[1][i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Student 2's grades are as follows:");
            for (int b = 0; b < studentgrades[1].Length; b++)
            {
                Console.Write(studentgrades[1][b] + " ");
            }
            Console.WriteLine();
            //
            Console.WriteLine("How many classes do you have a grade for, for student three?");
            stugrades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great, student 3 took {0} classes! Now let's get grades for each class.", stugrades);
            studentgrades[2] = new char[stugrades];
            for (int i = 0; i < studentgrades[2].Length; i++)
            {
                Console.Write("Please input a single character grade for the student! ");
                studentgrades[2][i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Student 3's grades are as follows:");
            for (int b = 0; b < studentgrades[2].Length; b++)
            {
                Console.Write(studentgrades[2][b] + " ");
            }
            Console.WriteLine();
            //
            Console.WriteLine("How many classes do you have a grade for, for student four?");
            stugrades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great, student 4 took {0} classes! Now let's get grades for each class.", stugrades);
            studentgrades[3] = new char[stugrades];
            for (int i = 0; i < studentgrades[3].Length; i++)
            {
                Console.Write("Please input a single character grade for the student! ");
                studentgrades[3][i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Student 4's grades are as follows:");
            for (int b = 0; b < studentgrades[3].Length; b++)
            {
                Console.Write(studentgrades[3][b] + " ");
            }
            Console.WriteLine();
            //
            Console.WriteLine("How many classes do you have a grade for, for student five?");
            stugrades = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great, student 5 took {0} classes! Now let's get grades for each class.", stugrades);
            studentgrades[4] = new char[stugrades];
            for (int i = 0; i < studentgrades[4].Length; i++)
            {
                Console.Write("Please input a single character grade for the student! ");
                studentgrades[4][i] = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Student 5's grades are as follows:");
            for (int b = 0; b < studentgrades[4].Length; b++)
            {
                Console.Write(studentgrades[4][b] + " ");
            }
            Console.WriteLine();
            //finally done getting all the grades, now we're going to print them beside the student name 
            Console.WriteLine("Wow, that was a lot of work to enter grades!");
            Console.WriteLine("Here's the grades for each student!");
            Console.Write("Student1: "); //just prints each grade in the array for the student 
            for (int i = 0; i < studentgrades[0].Length; i++)
            {
                Console.Write(studentgrades[0][i] + " ");
            }
            Console.WriteLine();
            //
            Console.Write("Student2: ");
            for (int i = 0; i < studentgrades[1].Length; i++)
            {
                Console.Write(studentgrades[1][i] + " ");
            }
            Console.WriteLine();
            //
            Console.Write("Student3: ");
            for (int i = 0; i < studentgrades[2].Length; i++)
            {
                Console.Write(studentgrades[2][i] + " ");
            }
            Console.WriteLine();
            //
            Console.Write("Student4: ");
            for (int i = 0; i < studentgrades[3].Length; i++)
            {
                Console.Write(studentgrades[3][i] + " ");
            }
            Console.WriteLine();
            //
            Console.Write("Student5: ");
            for (int i = 0; i < studentgrades[4].Length; i++)
            {
                Console.Write(studentgrades[4][i] + " ");
            }
            Console.WriteLine();
        }
    }
}
