using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class User
    {
        static Random rand = new();
        Printer myPrinter;
        public User(Printer printer)
        {
            myPrinter = printer;
            printer.PageOver += Printer_PageOver;
        }

        ~User() => myPrinter.PageOver -= Printer_PageOver;

        private void Printer_PageOver(object sender, PrinterEventArgs args)
        {
            //PrinterEventArgs pArgs = args as PrinterEventArgs;
            if (args.Status) return;
            if (rand.NextDouble() > 0.5) return;
            args.Status = true;
            Console.WriteLine("I am going to bring the paper!!!");
        }
    }
}
