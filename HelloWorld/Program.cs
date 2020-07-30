using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            //Console.ReadKey(); // What happens if you run the app without this line?;

           
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Shark" };
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };

           Console.WriteLine("These are the animals with more than 2 Syllables.");
            foreach (var animal in animals)

            {
              var SyllableCount = 0;

                foreach(var c in animal)
                {
                    if (vowels.Contains(c))
                    {
                       
                        SyllableCount++;
                         
                    }
                    
                 }
               
                if (SyllableCount >=2)                  
                {
                    Console.WriteLine(animal);
                 }


            }
            Console.WriteLine("Please choose a greeting: 'Hello', 'GoodMorning', 'Hi Student'");
            var greeting = Console.ReadLine();
            Console.WriteLine($"I choose {greeting}!");

        }
    }
}
