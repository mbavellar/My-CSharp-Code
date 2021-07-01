namespace InterfacePracticeModel.Abstract
{
    internal abstract class ProductBase
    {
        protected abstract string Name { get; set; }
        protected abstract  double Price { get; set; }
        protected abstract bool OrderCompleted { get; set; }
        protected ProductBase(string name, double price)
        {
            Name = name;
            Price = price;
            OrderCompleted = false;
        }
    }
}
