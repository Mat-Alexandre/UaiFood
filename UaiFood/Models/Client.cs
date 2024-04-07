namespace UaiFood.Models;

public class Client : BaseUser
{
    public String FirstName { get; set; } = null!;
    public String LastName { get; set; } = null!;
    public List<Address> AddressInfo { get; set; } = null!;
}
