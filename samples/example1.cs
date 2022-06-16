// C# Program to Check whether the Entered Number is Even or Odd
using System;
class Program
{
    public static void Main(string[] args)
    {
        int i;
        Console.Write("Enter a number : ");
        i = int.Parse(Console.ReadLine());
        if (i % 2 == 0)
        {
            Console.Write("Even Number");
            Console.Read();
        }
        else
        {
            Console.Write("Odd Number");
            Console.Read();
        }
    }
}