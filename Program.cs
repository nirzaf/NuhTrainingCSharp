// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Console.BackgroundColor = ConsoleColor.Yellow;
        // Console.ForegroundColor = ConsoleColor.Red;

        int age = 7;

        string name = "Nuh";

        bool girl = false;

        if (girl)
        {
            Console.WriteLine($"I am a girl, my name is {name}");
        }
        else
        {
            Console.WriteLine("I am a boy, my name is " + name);

            Console.WriteLine($"My age is {age}");

            string[] weapons = new string[3];


            weapons[0] = "axe";
            weapons[1] = "gun";
            weapons[2] = "Sword";
            Console.WriteLine($"My weapon is {weapons[2]}");
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Please enter a key");
                string key = Console.ReadKey().KeyChar.ToString();

                if (key == "x")
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine($"You entered {key}");
            }
        }
    }

}