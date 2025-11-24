
using SRPRefactored.Domain;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPRefactored.Presentation
{
    internal class InvoiceHtmlPrinter
    {
        public static void PrintInvoice(Invoice invoice)
        {
            string template = $"Id :{invoice.Id} " +
                $",description:{invoice.Description}" +
                $" cost is :{invoice.Cost}" +
                $" tax amt is :{invoice.CalcuateTax()}" +
                $" discount amt is {invoice.CalculateDiscount()}" +
                $" Final cost is :{invoice.FinalCost()}";


            StreamWriter sw = new StreamWriter($"{invoice.Id}.html");

            sw.WriteLine(template);
            sw.Close();

        }
    }
}
