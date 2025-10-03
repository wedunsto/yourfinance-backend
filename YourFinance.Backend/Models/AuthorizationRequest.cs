namespace YourFinance.Backend.Models;

// DTO to handle users registering for new accounts and logging into existing accounts
public record AuthorizationRequest(string Username, string Password);