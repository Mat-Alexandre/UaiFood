using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UaiFood.Models;

[PrimaryKey(nameof(StoreId), nameof(UserId), nameof(ProductId))]
public class Order
{
    [Column(Order = 1)]
    [ForeignKey("Store")]
    public int StoreId { get; set; }
    [Column(Order = 2)]
    [ForeignKey("Client")]
    public int UserId { get; set; }
    [Column(Order = 3)]
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    [DataType(DataType.Date)]
    public DateTime OrderStartDate { get; set; }
    [DataType(DataType.Date)]
    public DateTime OrderEndDate { get; set; }
    public String OrderStatus { get; set; } = null!;
}
