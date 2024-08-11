using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UaiFood.Models;

public class Client : BaseUser
{
    [Key]
    [Column("ClientId")]
    public override String UserId { get; set; } = null!;
    public String FirstName { get; set; } = null!;
    public String LastName { get; set; } = null!;
    public List<Address> AddressInfo { get; set; } = null!;
}
