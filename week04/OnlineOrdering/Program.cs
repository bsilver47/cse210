using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order
        {
            Id = 1,
            Customer = new Customer
            {
                Name = "Rick Oak",
                Address = new Address
                {
                    Street = "1 Infinite Loop",
                    City = "Cupertino",
                    State = "CA",
                    ZipCode = "95014",
                    Country = "USA"
                }
            },
            OrderDate = DateTime.Now
        };
        order1.AddProduct(new Product { Id = 101, Name = "Laptop", Price = 799.99m, Stock = 10 });
        order1.AddProduct(new Product { Id = 102, Name = "Mouse", Price = 15.50m, Stock = 50 });
        order1.SetShippingCost();
        order1.CalculateTotalPrice();
        Console.WriteLine(order1.ToString());
        order1.PackingLabel();
        order1.ShippingLabel();

        Order order2 = new Order
        {
            Id = 2,
            Customer = new Customer
            {
                Name = "Eliza Oak",
                Address = new Address
                {
                    Street = "37 Hills Road",
                    City = "Cambridge",
                    State = "England",
                    ZipCode = "CB2 1NT  ",
                    Country = "United Kingdom"
                }
            },
            OrderDate = DateTime.Now
        };
        order2.AddProduct(new Product { Id = 103, Name = "Smartphone", Price = 299.99m, Stock = 20 });
        order2.AddProduct(new Product { Id = 104, Name = "Headphones", Price = 49.99m, Stock = 30 });
        order2.AddProduct(new Product { Id = 105, Name = "Charger", Price = 14.99m, Stock = 100 });
        order2.SetShippingCost();
        order2.CalculateTotalPrice();
        Console.WriteLine(order2.ToString());
        order2.PackingLabel();
        order2.ShippingLabel();
    }
}