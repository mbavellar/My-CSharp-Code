using InterfacePracticeModel.Abstract;
using InterfacePracticeModel.Interfaces;
using System;

namespace InterfacePracticeModel
{
    public class CourseProductModel : BaseProduct
    {        
        public CourseProductModel(string name, double price) : base(name, price)
        {
            Name = name;
            Price = price;
            OrderCompleted = false;
        }

        public override void ShipItems(CustomerModel customer)
        {
            if (!OrderCompleted)
            {
                Console.WriteLine($"Added the {Name} course to {customer.FirstName}'s account. ");
                OrderCompleted = true;
            }
        }
    }
}
