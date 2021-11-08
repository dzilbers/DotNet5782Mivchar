using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    
    public class Printer
    {
        internal event EventHandler<PrinterEventArgs> PageOver = null;
        private int pageCount = 20;

        private void handlePageOver() => PageOver?.Invoke(this, new PrinterEventArgs());

        public void Print(int pages)
        {
            if (pages <= pageCount) pageCount -= pages;
            else { pageCount = 0; handlePageOver(); }
        }
    }

    internal class PrinterEventArgs : EventArgs
    {
        public bool Status = false;
    }
}
