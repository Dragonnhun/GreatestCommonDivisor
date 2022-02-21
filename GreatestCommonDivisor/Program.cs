using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg két egész számot!\n");

            Console.Write("a: ");
            var a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            var b = int.Parse(Console.ReadLine());

            var result = GreatestCommonDivisorEuclidean(a, b);

            Console.WriteLine("\n{0} és {1} legnagyobb közös osztója: {2}", a, b, result);

            Console.ReadKey();
        }

        static int GreatestCommonDivisorEuclidean(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;

            Console.WriteLine("\nEuklideszi algoritmus:\n");

            if (a > b)
            {
                return EuclideanAlgorithm(a, b);
            }

            return EuclideanAlgorithm(b, a);
        }

        static int EuclideanAlgorithm(int a, int b)
        {
            Console.WriteLine($"{a} = {b} * {a / b} + {a % b}");

            var remainder = a % b;

            if (remainder == 0)
            {
                return b;
            }

            return EuclideanAlgorithm(b, remainder);
        }
    }
}
