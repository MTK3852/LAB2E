using System;

namespace LAB2._5OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array:");
            int a;
            int b;
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int[,] array = new int[a, b];

                Console.WriteLine("Enter elemets of array");
                for(int i =0; i<array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        try
                        {
                            Console.WriteLine($"Element {i}{j}:");
                            array[i, j] = int.Parse(Console.ReadLine());
                        }
                        catch(FormatException)
                        {
                            Console.WriteLine("Enter numbers not symbols");
                            Console.WriteLine($"Element {i}{j}:");
                            array[i, j] = int.Parse(Console.ReadLine());

                        }


                    }
                }
                int sum = Sum(array);
               
            }
            catch (FormatException)
            {
                Console.WriteLine("HI!!!PLEASE ENTER NUMBERS NO SYMBOLS(THANK YOU)");
            }
        }
        public static int Sum(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[i, j] < 0)
                    {
                        sum += array[i, j];
                    }
                }
            }
            Console.WriteLine($"Sum of negative elements of array:" + sum);
            return sum;
        }
    }
}
