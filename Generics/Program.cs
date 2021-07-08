using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intArray = { 1, 3, 5, 7, 9 };
            char[] charArray = { 'G', 'E', 'N', 'E', 'R', 'I', 'C', 'S' };
            double[] doubleArray = { 11.29, 29.03, 6.03 };

            Program.toPrint<int>(intArray);
            Program.toPrint<char>(charArray);
            Program.toPrint<double>(doubleArray);
        }

        public static void toPrint<T>(T[] inputArray)
        {
            foreach(var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------------");
        }
    }
}
