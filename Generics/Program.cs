using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            //Initialising types of Arrays
            int[] intArray = { 1, 3, 5, 7, 9 };
            char[] charArray = { 'G', 'E', 'N', 'E', 'R', 'I', 'C', 'S' };
            double[] doubleArray = { 11.29, 29.03, 6.03 };

            //Invoking Generic classes
            new PrintArray<int>(intArray).toDisplay();
            new PrintArray<char>(charArray).toDisplay();
            new PrintArray<double>(doubleArray).toDisplay();
            //Invoking Generic methods
            /*  Program.toPrint<int>(intArray);
              Program.toPrint<char>(charArray);
              Program.toPrint<double>(doubleArray);
          }
          //Declaring a Generic Method to call types of arrays
          public static void toPrint<T>(T[] inputArray)
          {
              foreach(var element in inputArray)
              {
                  Console.WriteLine(element);
              }
              Console.WriteLine("-----------------------------------");
          }*/
        }
    }
}
