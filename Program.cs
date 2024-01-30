using System;

class Program
{
    static void Main(string[] args)
    {
        // For loop
        Console.WriteLine("For loop:");
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Value of i: " + i);
        }
        Console.WriteLine();

        // While loop
        Console.WriteLine("While loop:");
        int j = 0;
        while(j < 5)
        {
            Console.WriteLine("Value of j: " + j);
            j++;
        }
        Console.WriteLine();

        // Do-while loop
        Console.WriteLine("Do-while loop:");
        int k = 0;
        do
        {
            Console.WriteLine("Value of k: " + k);
            k++;
        } while(k < 5);
        Console.WriteLine();

        // Foreach loop
        Console.WriteLine("Foreach loop:");
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach(int num in numbers)
        {
            Console.WriteLine("Number: " + num);
        }
    }
}
