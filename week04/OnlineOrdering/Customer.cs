using System;
using System.Net.Sockets;
namespace OnlineOrdering
{
    public class Customer
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public override string ToString()
        {
            return $"Customer Name: {Name}, Price: ${Price}";
        }
        public bool IsUSAddress()
        {
            return Address.IsUSAddress();
        }
    }
}