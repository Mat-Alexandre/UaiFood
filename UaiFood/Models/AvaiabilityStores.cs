using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UaiFood.Models;

[PrimaryKey(nameof(StoreId), nameof(Availability))]
public class AvaiabilityStores
{
    [ForeignKey("Store")]
    [Column(Order = 1)]
    public String StoreId { get; set; } = null!;
    [Required]
    [Column(Order = 2)]
    public DateTime Availability { get; set; }
}
