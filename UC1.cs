using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProgram
{
    class UC1
    {
        public static void CartesianProgram()
        {
            Console.WriteLine("Enter X1 value :-");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y1 value :-");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X2 value :-");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y2 value :-");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            var distance = Math.Sqrt((Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2)));
            Console.WriteLine("Length of a line is " + distance);
        }
    }
}
