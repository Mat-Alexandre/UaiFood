using System.ComponentModel.DataAnnotations;

namespace UaiFood.Models;

public abstract class BaseUser
{
    [Key]
    public String UserId { get; set; } = null!;
    public String HashedPassword { get; set; } = null!;
    public String? Salt { get; set; }
    public String Email { get; set; } = null!;
    public String? PhoneNumber { get; set; }

}
