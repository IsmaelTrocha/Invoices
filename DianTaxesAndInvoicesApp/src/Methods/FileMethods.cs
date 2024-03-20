using DianTaxesAndInvoicesApp.Files;
using DianTaxesAndInvoicesApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DianTaxesAndInvoicesApp.src.Methods
{
    public class FileMethods
    {


        public static void PaidInvoicesJanuary()
        {
            string[] invoices = FileContent.GetInvoices();
            string[] januaryMonth = { "Enero" }; 


            Console.WriteLine();
            Console.Write("ANSWER");
            Console.WriteLine();
            foreach (string item in invoices)
            {
                string[] parts = item.Split(';');
                ProcessInvoice(parts,januaryMonth , true);
            }
        }

        public static void GetAllInvoices(bool isPaid)
        {
            string[] invoices = FileContent.GetInvoices();
            string[] januaryMonth = { "Enero" };


            Console.WriteLine();
            string answer = isPaid ? " Factura pagada" : " Factura no pagada";
            Console.Write("ANSWER" +answer);
            Console.WriteLine();
            foreach (string item in invoices)
            {
                string[] parts = item.Split(';');
                ProcessInvoiceWithOutMonth(parts, isPaid);
            }
        }


        public static void GetInvoicesBySemester(string semester)
        {
            string[] invoices = FileContent.GetInvoices();
            string[] selectedMonths;

            if (semester.Equals("first", StringComparison.OrdinalIgnoreCase) || semester.Equals("primer", StringComparison.OrdinalIgnoreCase))
            {
                selectedMonths = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };
            }
            else if (semester.Equals("second", StringComparison.OrdinalIgnoreCase) || semester.Equals("segundo", StringComparison.OrdinalIgnoreCase))
            {
                selectedMonths = new string[] { "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            }
            else
            {
                Console.WriteLine("Semester input is not recognized. Please enter 'first' or 'second'.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("RESPUESTA #5: ");
            foreach (string item in invoices)
            {
                string[] parts = item.Split(';');
                ProcessInvoice(parts, selectedMonths, true);
            }
        }

        private static void ProcessInvoiceWithOutMonth(string[] parts,  bool checkPaid)
        {
            if (parts.Length == 6)
            {
                Invoice variable = new Invoice();
                variable.Number = parts[0];
                variable.TotalAmount = parts[1];
                variable.Taxes = parts[2];
                variable.TotalWithTaxes = parts[3];
                variable.Month = parts[4];
                variable.Paid = parts[5];

                if (!checkPaid || variable.Paid == "SI" )
                {
                    Console.WriteLine($"Facturas '{variable.Number}' del mes '{variable.Month}'");
                }
            }
            else
            {
                Console.WriteLine("La estructura del archivo está incompleta o excede los límites");
            }
        }


        private static void ProcessInvoice(string[] parts, string[] months, bool checkPaid)
        {
            if (parts.Length == 6)
            {
                Invoice variable = new Invoice();
                variable.Number = parts[0];
                variable.TotalAmount = parts[1];
                variable.Taxes = parts[2];
                variable.TotalWithTaxes = parts[3];
                variable.Month = parts[4];
                variable.Paid = parts[5];

                if (!checkPaid || variable.Paid == "SI" && months.Contains(variable.Month))
                {
                    Console.WriteLine($"Facturas '{variable.Number}' del mes '{variable.Month}'");
                }
            }
            else
            {
                Console.WriteLine("La estructura del archivo está incompleta o excede los límites");
            }
        }

    }
}
