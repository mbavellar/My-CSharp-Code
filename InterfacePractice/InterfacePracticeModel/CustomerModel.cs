using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeModel
{
    public class CustomerModel : BaseCustomerModel
    {
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
