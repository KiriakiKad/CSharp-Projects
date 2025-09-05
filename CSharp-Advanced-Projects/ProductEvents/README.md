   PRODUCT EVENTS EXAMPLE (C# PROJECT)
=============================================

This project demonstrates how to use **events** in C# 
to notify multiple services when a specific action occurs 
in an object, without tightly coupling the services to the object.

The example models a product stock scenario where notifications 
are sent when the stock of a product is depleted.

---------------------------------------------
FEATURES
---------------------------------------------
- Product class
  * Tracks the product name and quantity
  * Provides a Sell() method to reduce stock
  * Fires a StockDepleted event when stock reaches zero or insufficient stock

- Event argument class: StockDepletedEventArgs
  * Contains relevant data for the event (ProductName)

- Multiple notification services
  * EmailNotificationService: sends an email alert when stock is depleted
  * SmsNotificationService: sends an SMS alert when stock is depleted
  * Both services subscribe to the StockDepleted event

- Event-driven design
  * Allows adding new services without changing the Product class
  * Promotes loose coupling and extensibility

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
Product product = new Product("Laptop", 5);

EmailNotificationService emailService = new EmailNotificationService();
SmsNotificationService smsService = new SmsNotificationService();

product.StockDepleted += emailService.OnStockDepleted;
product.StockDepleted += smsService.OnStockDepleted;

product.Sell(3); // Reduces stock, no event yet
product.Sell(3); // Triggers StockDepleted event

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
3 units of Laptop sold. Remaining stock: 2
Not enough stock of Laptop to sell 3 units!
Alert: Stock for product Laptop is depleted! (Email)
SMS: Stock for product Laptop is depleted! (SMS)

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- **Events & EventHandlers**: notify multiple subscribers when something happens
- **Loose coupling**: Product does not need to know about the services
- **Extensibility**: easily add new notification services
- **Custom EventArgs**: pass relevant data to subscribers

---------------------------------------------
NOTE
---------------------------------------------
This project is for educational purposes and simulates 
notifications via console output only.
