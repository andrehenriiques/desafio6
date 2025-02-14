namespace desafio6.Api.Dto;

public class ClientAddressDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public AddressDto Address { get; set; }
}

public class AddressDto
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string PostalCode { get; set; }
}