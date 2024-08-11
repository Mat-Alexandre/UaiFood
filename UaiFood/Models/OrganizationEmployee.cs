using System.ComponentModel.DataAnnotations;

namespace UaiFood.Models;

public class OrganizationEmployee : BaseUser
{
    [Key]
    public override string UserId { get; set; } = null!;
    public String FirstName { get; set; } = null!;
    public String LastName { get; set; } = null!;
    public String Role { get; set; } = null!;

    public override string? ToString()
    {
        var phones = String.Join(" ", PhoneNumber.ToArray());
        return $"{LastName}, {FirstName} - userId=[{UserId}] - role=[{Role}] - pwd=[{HashedPassword}] salt=[{Salt}] - email=[{Email}] - phones=[{phones}]";
    }
}
