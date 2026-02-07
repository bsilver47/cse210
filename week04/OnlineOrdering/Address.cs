using System;
namespace OnlineOrdering
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Street}, {City}, {State} {ZipCode}";
        }
        public bool IsUSAddress()
        {
            return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }
    }
}