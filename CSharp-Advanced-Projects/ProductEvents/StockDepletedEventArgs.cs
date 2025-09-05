using System;

namespace ProductEvents
{
    // Custom EventArgs class that carries extra information (ProductName)
    public class StockDepletedEventArgs : EventArgs
    {
        public string ProductName { get; set; }

        public StockDepletedEventArgs(string productName)
        {
            ProductName = productName;
        }
    }
}
