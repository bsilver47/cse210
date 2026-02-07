using System;
using System.Net.Http.Headers;

namespace OnlineOrdering
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public decimal ShippingCost { get; private set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; private set; }

        public override string ToString()
        {
            return $"Order Id: {Id}, Customer: {Customer.Name}, Date: {OrderDate.ToShortDateString()}, Total: ${TotalPrice}";
        }
        public void AddProduct(Product product)
        {
            if (Products == null)
            {
                Products = new List<Product>();
            }
            Products.Add(product);
        }
        public void SetShippingCost()
        {
            if (Customer.IsUSAddress())
            {
                ShippingCost = 5.00m;
            }
            else
            {
                ShippingCost = 35.00m;
            }
        }
        public void CalculateTotalPrice()
        {
            TotalPrice = Products.Sum(p => p.Price) + ShippingCost;
        }
        public void PackingLabel()
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine("Products:");
            foreach (var product in Products)
            {
                Console.WriteLine($"- {product.Name} (${product.Id})");
            }
        }
        public void ShippingLabel()
        {
            Console.WriteLine("Shipping Label:");
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Address: {Customer.Address}");
        }
    }
}