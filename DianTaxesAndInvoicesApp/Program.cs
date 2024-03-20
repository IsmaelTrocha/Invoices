using DianTaxesAndInvoicesApp.src.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DianTaxesAndInvoicesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileMethods.PaidInvoicesJanuary();
            FileMethods.GetAllInvoices(true);

            FileMethods.GetInvoicesBySemester("first");
            FileMethods.GetInvoicesBySemester("second");
        }
    }
}
