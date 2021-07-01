namespace InterfacePracticeModel
{
    public class CustomerModelBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellphoneNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public CustomerAddressModel Address { get; set; }

        public override string ToString() => FirstName + " " + LastName;
    }
}