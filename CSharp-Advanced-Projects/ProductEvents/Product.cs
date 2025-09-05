using System;

namespace ProductEvents
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        // Event declaration: Notifies subscribers when stock is depleted
        public event EventHandler<StockDepletedEventArgs> StockDepleted;

        public Product(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public void Sell(int amount)
        {
            if (amount <= Quantity)
            {
                Quantity -= amount;
                Console.WriteLine($"{amount} units of {Name} sold. Remaining stock: {Quantity}");

                // If stock reaches zero, raise the event
                if (Quantity == 0)
                {
                    OnStockDepleted();
                }
            }
            else
            {
                // If trying to sell more than available, still trigger event
                Console.WriteLine($"Not enough stock of {Name} to sell {amount} units!");
                OnStockDepleted();
            }
        }

        // Protected method that raises the event
        protected virtual void OnStockDepleted()
        {
            // Invoke the event if there are subscribers
            // It returns the args to the subscribers
            StockDepleted?.Invoke(this, new StockDepletedEventArgs(Name));
        }
    }
}
