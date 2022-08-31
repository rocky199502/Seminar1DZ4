using System;

namespace DZ4Seminar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string first = Console.ReadLine();
            int number = int.Parse(first);
            int i = 0;
            Console.WriteLine("Последовательность четных чисел: ");
            while (i<number-1)
            {
                i+=2;
                Console.WriteLine(i);
            }
        }

    }
}
