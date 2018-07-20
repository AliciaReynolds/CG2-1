using System;

namespace HelloWorld1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please Type Your First Name");
            string x = Console.ReadLine();
            Console.WriteLine("Please Type Your Last Name");
            string y = Console.ReadLine();
            Console.WriteLine("Hello" + x + " " + y + "!");
            Console.ReadLine();

        }
    }
}
