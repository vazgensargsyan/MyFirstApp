using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you are adult select enter.");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Please write your name");
                string name = Console.ReadLine();

                Console.WriteLine("Please write your surname");
                string surName = Console.ReadLine();

                Console.WriteLine("Please write your age");
                int age = int.Parse(Console.ReadLine());

                if (age < 1)
                {
                    Console.WriteLine("Please write correct age");
                }
                else
                {
                    Console.WriteLine("Your name is " + name + " " + surName + " and you are " + age + " years old.");
                }
            }
            else
            {
                Console.WriteLine("You are not allowed to fill form !!!");
            }
        }
    }
}