using System;

namespace _01_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i + ",");
            }

            Console.WriteLine();
            Console.WriteLine(" ------- ");

            for (int i = 100; i >= 1; i--)
            {
                Console.Write(i + ",");
            }

            Console.WriteLine();
            Console.WriteLine(" ------- ");
            Console.WriteLine("Please enter a number for calculation: ");

            int number = 0;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("You entered an invalid number!!!");
                Console.Write("Please enter a number for calculation: ");
            }

            Console.WriteLine("Sum_A= " + Sum_A(number));

            Console.WriteLine("Sum_B= " + Sum_A(number));
        }


        public static int Sum_A(int n)//Constant time O(1)
        {
            return (n * (n + 1)) / 2;
        }

        public static int Sum_B(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++) sum += i;
            return sum;
        }
    }
}
