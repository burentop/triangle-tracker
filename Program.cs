using System;
using System.Collections.Generic;

namespace TriangleTracker{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("We're going to make a triangle, and check to see what kind it is.");
            Console.WriteLine("Enter the length of side 1: ");
            string stringSideOne = Console.ReadLine();
            Console.WriteLine("Enter the length of side 2: ");
            string stringSideTwo = Console.ReadLine();
            Console.WriteLine("Enter the length of side 3: ");
            string stringSideThree = Console.ReadLine();

            int sideOne = int.Parse(stringSideOne);
            int sideTwo = int.Parse(stringSideTwo);
            int sideThree = int.Parse(stringSideThree);

            Triangle userTriangle = new Triangle(sideOne, sideTwo, sideThree);

            if (userTriangle.IsEquilateral())
            {
                Console.WriteLine("It's equilateral!");
            }
            else if (userTriangle.IsIsosceles())
            {
                Console.WriteLine("It's isosceles!");
            }
            else{
                Console.WriteLine("It's scalene!");
            }
        }
    }
}