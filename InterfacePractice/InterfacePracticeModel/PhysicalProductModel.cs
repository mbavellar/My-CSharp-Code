using InterfacePracticeModel.Abstract;
using InterfacePracticeModel.Interfaces;
using System;

namespace InterfacePracticeModel
{
	public class PhysicalProductModel : BaseProduct
	{
        public PhysicalProductModel(string name, double price) : base (name, price)
		{
            Name = name;
            Price = price;
            OrderCompleted = false;
		}

        public override void ShipItems(CustomerModel customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Simulating Shipping {Name} to {customer} to {customer.Address}");
                OrderCompleted = true;
            }
        }
    }
}