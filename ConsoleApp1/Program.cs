using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "math":
                    Console.WriteLine("Cool! Math is my favorite subject as well");
                    break;
                case "science":
                    Console.WriteLine("Oooo.. Science sucks :P!");
                    break;
                case "english":
                    Console.WriteLine("English is my first language and I still can't write an essey worth reading haha");
                    break;
                case "history":
                    Console.WriteLine("A very neccisary class for us to understand many things" );
                    break;
                case "art":
                    Console.WriteLine("Art is cool! Watercolor is my personal favorite");
                    break;
                default:
                    Console.WriteLine("Please pick from our directory of classes: Math, Science, English, History, or Art");
                    break;
            }
        }
    }
}
