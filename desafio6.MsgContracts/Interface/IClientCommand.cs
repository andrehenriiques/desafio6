namespace desafio6.MsgContracts.Interface{
    public interface ClientAddressModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public AddressModel Address { get; set; }
    }

    public interface AddressModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}