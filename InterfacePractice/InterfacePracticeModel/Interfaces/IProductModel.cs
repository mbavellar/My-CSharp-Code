using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeModel.Interfaces
{
    public interface IProductModel
    {
        string Name { get; set; }
        double Price { get; set; }
        bool OrderCompleted { get; }

        void ShipItems(CustomerModel customerModel);
    }
}
