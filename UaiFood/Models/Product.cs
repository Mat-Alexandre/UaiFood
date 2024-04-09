using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UaiFood.Models;

public class Product
{
    [Key]
    public String ProductId { get; set; } = null!;
    [Required]
    [MaxLength(25)]
    public String ProductName { get; set; } = null!;
    [Required]
    [Precision(6, 2)]
    public Decimal ProductPrice { get; set; }
    [MaxLength(100)]
    public String? ProductDescription { get; set; }
}
