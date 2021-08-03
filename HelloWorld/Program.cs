using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Revature!");
            Console.WriteLine("The curent time is " + DateTime.Now);

            Console.WriteLine("Enter something: ");
            string input = Console.ReadLine();
            Console.WriteLine("You Entered " + input);

            if (input == ""){
                Console.WriteLine("You Entered " + input);
            }

        }
    }
}
