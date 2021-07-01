using InterfacePracticeModel.Interfaces;

namespace InterfacePracticeModel.Abstract
{
    public abstract class BaseProduct : IProductModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool OrderCompleted { get; set; }
        public BaseProduct(string name, double price)
        {
            Name = name;
            Price = price;
            OrderCompleted = false;
        }

        public abstract void ShipItems(CustomerModel customerModel);
    }
}
