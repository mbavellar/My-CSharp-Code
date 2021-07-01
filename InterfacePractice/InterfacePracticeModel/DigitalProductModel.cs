using InterfacePracticeModel.Interfaces;
using System;

namespace InterfacePracticeModel
{
    public class DigitalProductModel : IDigitalProductModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool OrderCompleted { get; private set; }
        public byte DownloadsLeft { get; private set; } = 5;

        public DigitalProductModel(string name, double price)
        {
            Name = name;
            Price = price;
            OrderCompleted = false;
        }

        public void ShipItems(CustomerModel customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Simulating emailing {Name} to {customer.Email}");
                DownloadsLeft -= 1;
                if (DownloadsLeft == 1)
                    OrderCompleted = true;
            }
        }
    }
}
