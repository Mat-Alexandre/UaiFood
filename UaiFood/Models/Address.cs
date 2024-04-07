using Microsoft.EntityFrameworkCore;

namespace UaiFood.Models;

[Owned]
public class Address
{
    public int AddressNumber { get; set; }
    public String? AddressComplement { get; set; }
    public String AddressStreet { get; set; } = null!;
    public String AddressPostalCode { get; set; } = null!;
    public String AddressBlock { get; set; } = null!;
    public String AddressCity { get; set; } = null!;
    public String AddressState { get; set; } = null!;
}
