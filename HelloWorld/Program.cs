using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String strName;
            Console.WriteLine("Hello World!");
            Console.WriteLine("What's your name?");
            strName = Console.ReadLine();
            foreach (var item in strName)
            {
            }
            Console.WriteLine("Hello, my friend " + strName);
            Console.WriteLine("What's your name?");
            strName = Console.ReadLine();
            foreach (var item in strName)
            {
            }
            Console.WriteLine("Hello, my friend " + strName);
        }
    }
}
