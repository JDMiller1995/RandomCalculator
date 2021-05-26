using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._18._2021ClassAssignments
{
    class overloadedMethods
    {
        public static void Overload()
        {
            Console.WriteLine("ALLLLLRIGHTY THEN, let's get some stuff going! What calculations would you like to do?"); //menu
            Console.WriteLine("1. Add two whole numbers");
            Console.WriteLine("2. Add three whole numbers");
            Console.WriteLine("3. Multiply two decimals");
            Console.WriteLine("4. Mulitply 3 decimals");
            Console.WriteLine("5. Exit");
            Console.Write("Please input one of the numbers listed above to choose.");
            int choice = 0; //establishing an int and error handling, if they input something weird it loops.
            try { 
                    choice = Convert.ToInt32(Console.ReadLine()); 
                }
            catch {
                Console.WriteLine("Choose an option!");
                Console.WriteLine();
                Overload();
                  }
            if (choice == 1) //see what they picked, based on the choice this is choice 1
            {
                Console.WriteLine("What are the two numbers?"); //gets the two numbers to add
                try
                {
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    add(num1, num2); //calls add method 
                    Console.WriteLine("Do you want to do something else? Y/N"); //asks if they want to do something again
                    try
                    {
                        char choices = Convert.ToChar(Console.ReadLine());
                        if (choices == 'Y')
                        {
                            Overload();
                        }
                        else if (choices == 'y')
                        {
                            Overload();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You didn't put something that could be converted to a character.");
                    }
                }
                catch
                {
                    Console.WriteLine("You have to restart the whole thing because you tried to put in something to break me!");
                    Console.WriteLine();
                    Overload();
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("What are the three numbers?");
                try
                {
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    add(num1, num2, num3);
                    Console.WriteLine("Do you want to do something else? Y/N");
                    try
                    {
                        char choices = Convert.ToChar(Console.ReadLine());
                        if (choices == 'Y')
                        {
                            Overload();
                        }
                        else if (choices == 'y')
                        {
                            Overload();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You didn't put something that could be converted to a character.");
                    }
                }
                catch
                {
                    Console.WriteLine("You have to restart the whole thing because you tried to put in something to break me!");
                    Console.WriteLine();
                    Overload();
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("What are the two numbers?");
                try
                {
                    float num1 = float.Parse(Console.ReadLine());
                    float num2 = float.Parse(Console.ReadLine());
                    Multiply(num1, num2);
                    Console.WriteLine("Do you want to do something else? Y/N");
                    try
                    {
                        char choices = Convert.ToChar(Console.ReadLine());
                        if (choices == 'Y')
                        {
                            Overload();
                        }
                        else if (choices == 'y')
                        {
                            Overload();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You didn't put something that could be converted to a character.");
                    }
                }
                catch
                {
                    Console.WriteLine("You have to restart the whole thing because you tried to put in something to break me!");
                    Console.WriteLine();
                    Overload();
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("What are the three numbers?");
                try
                {
                    float num1 = float.Parse(Console.ReadLine());
                    float num2 = float.Parse(Console.ReadLine());
                    float num3 = float.Parse(Console.ReadLine());
                    Multiply(num1, num2, num3);
                    Console.WriteLine("Do you want to do something else? Y/N");
                    try
                    {
                        char choices = Convert.ToChar(Console.ReadLine());
                        if (choices == 'Y')
                        {
                            Overload();
                        }
                        else if (choices == 'y')
                        {
                            Overload();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("You didn't put something that could be converted to a character.");
                    }
                }
                catch
                {
                    Console.WriteLine("You have to restart the whole thing because you tried to put in something to break me!");
                    Console.WriteLine();
                    Overload();
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thanks for using my calculator!");
            }
            else
            {
                Console.WriteLine("Please choose one of the given options.");
                Console.WriteLine();
                Overload();
            }
        }
        public static void add(int a, int b) //takes input and performs below functions
        {
            int c = a + b;
            Console.WriteLine("The sum of {0} and {1} is {2}", a, b, c);
        }
        public static void add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine("The sum of {0}, {1}, and {2} is {3}", a, b, c, d);
        }
        public static void Multiply (float a, float b)
        {
            float c = a * b;
            Console.WriteLine("The product of {0} times {1} is {2}", a, b, c);
        }
        public static void Multiply(float a, float b, float c)
        {
            float d = a * b * c;
            Console.WriteLine("The product of {0} times {1} times {2} is {3}", a, b, c, d);
            
        }
    }
}

