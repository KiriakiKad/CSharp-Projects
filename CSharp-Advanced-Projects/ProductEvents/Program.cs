using System;

namespace ProductEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a product with initial stock = 5
            Product product = new Product("Laptop", 5);

            // Create the service that will handle the event
            EmailNotificationService emailService = new EmailNotificationService();

            SmsNotificationService  smsNotificationService = new SmsNotificationService();

            // Subscribe the services method to the product's StockDepleted event
            product.StockDepleted += emailService.OnStockDepleted;
            product.StockDepleted += smsNotificationService.OnStockDepleted;

            // First sale - stock decreases but does not reach zero
            product.Sell(3);

            // Second sale - this will deplete the stock and trigger the event
            product.Sell(3);
        }
    }
}
