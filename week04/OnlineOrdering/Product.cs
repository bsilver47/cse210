using System;
namespace OnlineOrdering
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Product Id: {Id}, Name: {Name}, Price: ${Price}, Stock: {Stock}";
        }
        public bool IsInStock()
        {
            return Stock > 0;
        }
        public void ReduceStock(int quantity)
        {
            if (quantity > Stock)
            {
                throw new InvalidOperationException("Not enough stock available.");
            }
            Stock -= quantity;
        }
        public void Restock(int quantity)
        {
            Stock += quantity;
        }

        public decimal GetTotalPrice(int quantity)
        {
            return Price * quantity;
        }
    }
}