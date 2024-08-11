using System.ComponentModel.DataAnnotations;

namespace UaiFood.Models;

public abstract class BaseUser
{
    [Key]
    public virtual String UserId { get; set; } = null!;
    public String HashedPassword { get; set; } = null!;
    public String Email { get; set; } = null!;
    public String? Salt { get; set; }
    public List<String> PhoneNumber { get; set; } = null!;

}
