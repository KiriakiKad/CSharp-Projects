using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEvents
{
    public class SmsNotificationService
    {
        public void OnStockDepleted(object sender, StockDepletedEventArgs e)
        {
            Console.WriteLine("SMS: Stock for product " + e.ProductName + " is depleted!");
        }
    }
}
