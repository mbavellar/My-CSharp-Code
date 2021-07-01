using InterfacePracticeModel.Abstract;
using InterfacePracticeModel.Interfaces;
using System;

namespace InterfacePracticeModel
{
    public class DigitalProductModel : BaseProduct, IDigitalProductModel
    {
        public byte DownloadsLeft { get; private set; } = 5;

        public DigitalProductModel(string name, double price) : base (name, price)
        {
            Name = name;
            Price = price;
            OrderCompleted = false;
        }

        public override void ShipItems(CustomerModel customer)
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