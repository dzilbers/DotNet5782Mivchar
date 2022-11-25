using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class UserLiar
    {
        static Random rand = new();
        Printer myPrinter;
        public UserLiar(Printer printer)
        {
            myPrinter = printer;
            printer.PageOver += Printer_PageOver;
        }

        ~UserLiar() => myPrinter.PageOver -= Printer_PageOver;

        private void Printer_PageOver(object sender, EventArgs args)
        {
            PrinterEventArgs pArgs = args as PrinterEventArgs;
            if (pArgs.Status) return;
            pArgs.Status = true;
            Console.WriteLine("I am not going to bring the paper anyway!!!");
        }
    }
}
