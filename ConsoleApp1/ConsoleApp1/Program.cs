using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int alpha = Convert.ToInt32(Console.ReadLine());

            double z1 = Math.Cos(alpha) + Math.Cos(2 * alpha) + Math.Cos(6 * alpha) + Math.Cos(7 * alpha);
            double z2 = 4 * Math.Cos(alpha / 2) * Math.Cos((5 / 2) * alpha) * Math.Cos(4 * alpha);

            Console.WriteLine($"z1 = {z1}, z2 = {z2}");
        }
    }
}
