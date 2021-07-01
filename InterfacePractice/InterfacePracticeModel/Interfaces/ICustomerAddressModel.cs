namespace InterfacePracticeModel.Interfaces
{
    public interface ICustomerAddressModel
    {
        string City { get; set; }
        string Neighborhood { get; set; }
        short Number { get; set; }
        string State { get; set; }
        string Street { get; set; }
        string StreetSuffix { get; set; }
        int ZipCode { get; set; }
    }
}