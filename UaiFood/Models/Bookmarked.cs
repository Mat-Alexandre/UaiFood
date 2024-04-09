using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace UaiFood.Models;

[PrimaryKey(nameof(UserId), nameof(StoreId))]
public class Bookmarked
{
    [ForeignKey("Client")]
    [Column(Order = 1)]
    public String UserId { get; set; } = null!;
    [ForeignKey("Store")]
    [Column(Order = 2)]
    public String StoreId { get; set; } = null!;
}
