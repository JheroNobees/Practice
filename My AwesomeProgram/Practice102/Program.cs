using System;

namespace Practice102
{
    class Practice102
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string Username = Console.ReadLine();

            Console.WriteLine("HI," +Username+ "\nHow are you today?");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("That's good");
            Console.ReadKey();
        }
    }
}
