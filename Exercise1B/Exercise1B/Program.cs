using System;

namespace Exercise1B
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double slen;
            double clen;
            double pi = 3.14;
            Console.WriteLine("Alyssa Hanson");
            Console.WriteLine("Welcome to C#\n");

            Console.WriteLine("Enter Length of Square: \n");
            slen = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Area of The Square is: {slen * slen}\n");

            Console.WriteLine("Enter Length of Cube: \n");
            clen = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Volume of The Cube is: {clen * clen * clen}\n");

            Console.WriteLine("Enter Radius of Circle: \n");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The Area of The Circle: {pi * radius * radius}\n");

            Console.WriteLine($"The Perimeter of The Square is: {4 * slen}\n");

            Console.WriteLine($"The Circumference of The Circle is: {2 * pi * radius}\n");

        }
    }
}
