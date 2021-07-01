using InterfacePracticeModel.Interfaces;

namespace InterfacePracticeModel
{
    public class CustomerAddressModel : ICustomerAddressModel
    {
        public string StreetSuffix { get; set; }
        public string Street { get; set; }
        public short Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public CustomerAddressModel(string streetSuffix, string street, short number,
            string neighborhood, string city, string state, int zipCode)
        {
            this.StreetSuffix = streetSuffix;
            this.Street = street;
            this.Number = number;
            this.Neighborhood = neighborhood;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $" {StreetSuffix} {Street}, {Number} - {Neighborhood} - {City}/{State} - {ZipCode}.";
        }
    }
}
