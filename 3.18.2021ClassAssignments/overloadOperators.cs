using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._18._2021ClassAssignments
{
    public class circles //new class for circle making
    {

        private double radius; //some steady things we need
        private double pi = 3.14159;

        public void setradius(double rad) //allowing someone to set the radius of the circles
        {
            radius = rad;
        }
        public double Area() //gets the area of the given circle and returns the value 
        {
            return radius * radius * pi;
        }
        public static circles operator +(circles b, circles c) //allows me to add circles together easily by saying cirlce + circle
        {
            circles circle = new circles();
            circle.radius = b.radius + c.radius;
            return circle;
        }
        public static circles operator -(circles b, circles c) //same as above but subtracting 
        {
            circles circle = new circles();
            circle.radius = b.radius - c.radius;
            return circle;
        }

        public static void Circles2() //function to call in my main so I can open up the menu for circles
        {
            Console.WriteLine("Alright let's have some circle fun!");
            menu();
        }
        public static void menu() //this is the main menu 
        {
            circles circle1 = new circles();
            circles circle2 = new circles();
            circles circle3 = new circles();
            Console.WriteLine("Do you want to add the area of two circles or see what the difference is?");
            Console.WriteLine("1. Add the area! ");
            Console.WriteLine("2. See the difference!");
            Console.WriteLine("3. Exit");
            int pick = 0;
            try //makes sure they pick a valid option
            {
                pick = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You didn't pick one of the three options!");
                Console.WriteLine("**********************************************************************");
                menu();
            }
            if (pick == 1) //if they pick option one it adds the circles together so long as they don't try to input invalid stuff
            {
                Console.WriteLine("What is the radius of circle 1?");
                try
                {
                    circle1.setradius(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("What is the radius of circle 2?");
                    circle2.setradius(Convert.ToDouble(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("You put something that wasn't a number!");
                    Console.WriteLine("**********************************************************************");
                    menu();
                }
                Console.WriteLine("The area of circle 1 is {0} and circle 2 is {1}", circle1.Area(), circle2.Area());
                circle3 = circle1 + circle2;
                Console.WriteLine("The area of circle 3 (which is the sum of circle's 1 and 2) is {0}", circle3.Area());
                Console.WriteLine(" ");
                loopy(); //loops a menu to ask if they want to repeat this exercise 
            }
            else if(pick == 2) //pretty much same as above but with subtraction instead
            {
                Console.WriteLine("What is the radius of circle 1?");
                try
                {
                    circle1.setradius(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("What is the radius of circle 2?");
                    circle2.setradius(Convert.ToDouble(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("You put something that wasn't a number!");
                    Console.WriteLine("**********************************************************************");
                    menu();
                }
                if (circle1.radius < circle2.radius)
                {
                    double diff = (circle1.Area() - circle2.Area()) * (-1);
                    Console.WriteLine("The difference is {0}", diff);
                    loopy();
                }
                else
                {
                    Console.WriteLine("The area of circle 1 is {0} and circle 2 is {1}", circle1.Area(), circle2.Area());
                    circle3 = circle1 - circle2; //see this is where it does the circle thing I made above 
                    Console.WriteLine("The area of circle 3 (which is the difference of circle's 1 and 2) is {0}", circle3.Area());
                    Console.WriteLine(" ");
                    loopy();
                }
            }
            else
            {
                Console.WriteLine("Thanks for coming into the circles menu!");
            }
            
        }
        public static void loopy() //this is my "do you want to do another thing?" function, I like naming them loopy 
        {
            int choice = 0;
            Console.WriteLine("Do you want to perform another calculation? 1. Yes 2. No");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input 1 or 2 please.");
                loopy();
            }
            if(choice == 1)
            {
                Circles2();
            }
            else
            {
                Console.WriteLine("Thanks for having fun with circles!");
            }
        }

    }
}

