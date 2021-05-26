using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._18._2021ClassAssignments
{
    class Program
    {
        static void Main(string[] args)
        {
            menu(); //calls my menu function
            
        }
        static void menu()
        {
            Console.WriteLine("Which function would you like to choose?"); //menu
            Console.WriteLine("1. Print a 2d array!");
            Console.WriteLine("2. Input some grades!");
            Console.WriteLine("3. Do some basic calculations!");
            Console.WriteLine("4. Play around with circles!!");
            Console.WriteLine("5. Exit!");
            int menupick = 0; //initializing menu integer
            try
            {
                 menupick = Convert.ToInt32(Console.ReadLine()); //gets their pick and checks for error handling
            }
            catch
            {
                Console.WriteLine("Please pick 1, 2, 3, 4, or 5!");
                Console.WriteLine();
                menu();
            }
            if (menupick == 1) //choice is made, and it calls the function they chose then asks if they want to do something else
            {
                _2darray.print();
                Console.WriteLine("Do you want to try something else from the program?Y/N");
                char repeat = 'y';
                try
                {
                    repeat = Convert.ToChar(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Because you input an invalid character, taking you to main menu.");
                    menu();
                }
                if (repeat == 'y')
                {
                    menu();
                }
                else if (repeat == 'Y')
                {
                    menu();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
            else if (menupick == 2)
            {
                jaggedArrays.fillGrades();
                Console.WriteLine("Do you want to try something else from the program?Y/N");
                char repeat = 'y';
                try
                {
                    repeat = Convert.ToChar(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Because you input an invalid character, taking you to main menu.");
                    menu();
                }
                if (repeat == 'y')
                {
                    menu();
                }
                else if (repeat == 'Y')
                {
                    menu();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
            else if (menupick == 3)
            {
                overloadedMethods.Overload();
                Console.WriteLine("Do you want to try something else from the program?Y/N");
                char repeat = 'y';
                try
                {
                    repeat = Convert.ToChar(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Because you input an invalid character, taking you to main menu.");
                    menu();
                }
                if (repeat == 'y')
                {
                    menu();
                }
                else if (repeat == 'Y')
                {
                    menu();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
            else if (menupick == 4)
            {
                circles.Circles2();
                Console.WriteLine("Do you want to try something else from the program?Y/N");
                char repeat = 'y';
                try
                {
                    repeat = Convert.ToChar(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Because you input an invalid character, taking you to main menu.");
                    menu();
                }
                if (repeat == 'y')
                {
                    menu();
                }
                else if (repeat == 'Y')
                {
                    menu();
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                }
            }
            else if (menupick == 5)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please choose an option!");
                menu();
            }
        }
    }
}
