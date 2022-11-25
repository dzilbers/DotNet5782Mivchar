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

        private void handlePageOver(bool real) => PageOver?.Invoke(this, new PrinterEventArgs(real));

        public void Print(int pages)
        {
            if (pages <= pageCount) pageCount -= pages;
            else { pageCount = 0; handlePageOver(false); }
        }
    }

    internal class PrinterEventArgs : EventArgs
    {
        public bool Status = false;
        public PrinterEventArgs(bool status) => Status = status;
    }
}
