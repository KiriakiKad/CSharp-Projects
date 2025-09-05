using System;

namespace ProductEvents
{
    public class EmailNotificationService
    {
        // This method is the event handler (subscriber)
        // It will be called automatically when the event is raised
        public void OnStockDepleted(object sender, StockDepletedEventArgs e)
        {
            Console.WriteLine("Email: Stock for product" +  e.ProductName +  "is depleted!");
        }
    }
}
