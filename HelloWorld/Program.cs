using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            //Console.ReadKey(); // What happens if you run the app without this line?;

            Console.WriteLine("Please choose a greeting: 'Hello', 'GoodMorning', 'Hi Student'");
            var greeting = Console.ReadLine();
            Console.WriteLine($"I choose {greeting}!");

        }
    }
}
