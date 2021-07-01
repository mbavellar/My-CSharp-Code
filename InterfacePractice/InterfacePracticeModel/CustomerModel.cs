using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeModel
{
    public class CustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellphoneNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public CustomerAddressModel Address { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
