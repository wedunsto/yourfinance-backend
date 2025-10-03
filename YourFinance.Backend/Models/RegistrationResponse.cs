namespace YourFinance.Backend.Models;

// DTO to handle data returned when a user creates a new account
public class RegistrationResponse {
    public string Id { get; set; } = default!;
    public string Username { get; set; } = default!;
    public string AccountStatus { get; set; } = "New"; // New, Valid, Admin, Guest
}