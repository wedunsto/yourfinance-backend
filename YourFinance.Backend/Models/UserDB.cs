using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourFinance.Backend.Models;

[Table("users")] // matches the yourfinance SQL table name
public class User
{
    [Key] 
    [Required]
    public string username { get; set; } = default!;

    [Required]
    public string password { get; set; } = default!;

    [Required]
    public string account_status { get; set; } = "new";

    public DateTimeOffset created_at { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset updated_at { get; set; } = DateTimeOffset.UtcNow;
}