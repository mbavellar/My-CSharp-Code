using InterfacePracticeModel.Interfaces;
using System;

namespace InterfacePracticeModel
{
    public class CourseProductModel : IProductModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool OrderCompleted { get; private set; }

        public CourseProductModel(string name, double price)
        {
            Name = name;
            Price = price;
            OrderCompleted = false;
        }

        public void ShipItems(CustomerModel customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Added the {Name} course to {customer.FirstName}'s account. ");
                OrderCompleted = true;
            }
        }
    }
}
