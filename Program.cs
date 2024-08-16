// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        // create a calculator 

        Console.WriteLine("Enter a number: ");

        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter another number: ");

        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(x + y);

    }

}