using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UaiFood.Models;

public class Store : BaseUser
{
    [Key]
    [Column("StoreId")]
    public override String UserId { get; set; } = null!;
    public Address AddressInfo { get; set; } = null!;
    public String StoreName { get; set; } = null!;
    public int MinimumRequest { get; set; }
}
