using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._18._2021ClassAssignments
{
    class _2darray
    {
        public static void print()
        {
            int[,] plz2d = new int[2, 2]; //creates a 2d array
            plz2d[0, 0] = 1; //all below are assigning numbers to the array
            plz2d[0, 1] = 2;
            plz2d[1, 0] = 3;
            plz2d[1, 1] = 4;
            Console.WriteLine("-------");
            Console.WriteLine("|{0} | {1}|", plz2d[0, 0], plz2d[0, 1]); // prints the array top row
            Console.WriteLine("|{0} | {1}|", plz2d[1, 0], plz2d[1, 1]); //prints array bottom row 
            Console.WriteLine("-------");
        }
    }
}
