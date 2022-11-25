using System;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new();
            User u1 = new User(printer);
            User u2 = new User(printer);
            UserLiar u3 = new UserLiar(printer);
            User u4 = new User(printer);
            //printer.PageOver();
            Console.WriteLine("Please enter pages to print:");
            int x = int.Parse(Console.ReadLine());
            printer.Print(x);

        }
    }
}
