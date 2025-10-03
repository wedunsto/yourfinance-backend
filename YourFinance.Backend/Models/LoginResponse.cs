namespace YourFinance.Backend.Models;

// DTO to handle data returned when a user logs into an existing account
public class LoginResponse  {
    public string AccessToken { get; set; } = default!;
    public string AccountStatus { get; set; } = "New"; // New, Valid, Admin, Guest
}