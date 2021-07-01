using InterfacePracticeModel.Interfaces;
using System;

namespace InterfacePracticeModel
{
	public class PhysicalProductModel : IProductModel
	{
        public string Name { get; set; }
        public double Price { get; set; }
        public bool OrderCompleted { get; private set; }
        public PhysicalProductModel(string name, double price)
		{
            Name = name;
            Price = price;
            OrderCompleted = false;
		}

        public void ShipItems(CustomerModel customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Simulating Shipping {Name} to {customer} to {customer.Address}");
                OrderCompleted = true;
            }
        }
    }
}