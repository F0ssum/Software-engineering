using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5 /*Вариант 3 */
{
    public class Invoice
    {
        public DateTime InvoiceDate { get; set; }

        public Invoice(DateTime InvoiceDate)
        {
            try
            {
                if (InvoiceDate < DateTime.Now)
                {
                    throw new PastDateException("Дата выставления счёта уже прошла!");
                }
                else
                {
                    InvoiceDate = InvoiceDate;
                }
            }
            catch (PastDateException ex)
            {
                Console.WriteLine(ex.Message);
                InvoiceDate = DateTime.Now;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"Дата выставления счёта: {InvoiceDate}");
            }
        }
    }
}