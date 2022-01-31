using System;

namespace dgh
{
    class DoTheMath
    {
        static void Main(string[] args)
        {
            Console.Write("\nPlease enter the numerator? ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Please enter the denominator? ");
            int den = int.Parse(Console.ReadLine());

            int rem = num%den;
            int quo = num/den;

            Console.WriteLine($"\nInteger division result = {quo} with a remainder {rem}");

            double quo2 = (double)(num/den);
            Console.WriteLine($"\nFloating point division result = {quo2}");

            Console.WriteLine($"\nThe result as a mixed fraction is {quo} {rem}/{den} ");
        }
    }
}
