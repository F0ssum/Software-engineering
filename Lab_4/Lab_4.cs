using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Payment
    {
        public string ContractorName { get; set; }
        public decimal Amount { get; set; }

        public Payment(string contractorName, decimal amount)
        {
            ContractorName = contractorName;
            Amount = amount;
        }
    }
    public class Program
    {
        public static void Main()
        {
            List<Payment> payments = new List<Payment>
            {
                new Payment("«Пиконсалт Диджитал» ООО", 1000m),
                new Payment("«Пиконсалт Диджитал» ООО", 1000m),
                new Payment("«Экшн Медиа» ООО,", 2000m),
                new Payment("«Пиксель Адс» ООО", 3000m),
                new Payment("«Пиксель Адс» ООО", 3000m),
                new Payment("«Пи-Консалт» ООО,", 4000m),
                new Payment("ПАО КБ «Восточный»", 5000m),
                new Payment("ПАО КБ «Восточный»", 5000m),
                
            };

            var groupedPayments = payments.GroupBy (p => p.ContractorName).Select (g => new { ContractorName = g.Key, TotalAmount = g.Sum(p => p.Amount) });

            foreach (var payment in groupedPayments)
            {
                Console.WriteLine($"Контрагент: {payment.ContractorName}, Общая сумма платежа: {payment.TotalAmount}");
            }
        }
    }
}