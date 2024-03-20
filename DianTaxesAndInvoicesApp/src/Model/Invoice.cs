using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DianTaxesAndInvoicesApp.Model
{
    internal class Invoice
    {

        public string Number {  get; set; }
        public string TotalAmount { get; set; }
        public string Taxes { get; set; }
        public string TotalWithTaxes { get; set; }
        public string Month { get; set; }
        public string Paid { get; set; }

    }
}
