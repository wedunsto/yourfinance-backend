using YourFinance.Backend.Models; // Use the DTOs in the Models folder

namespace YourFinance.Backend.Services;

// Business logic used to handle registration and login requests
public class AuthenticationService {

    // Business logic used to handle registration requests
    public RegistrationResponse Register (AuthorizationRequest request) {
        var newUser = new RegistrationResponse {
            Username = request.Username,
            AccountStatus = "New",
        };

        // TODO: Create new SQL database entry in the YourFinance database - Users table

        return newUser;
    }

    // Business logic used to handle login requests
    public LoginResponse Login (AuthorizationRequest request) {
        // TODO: Query database for username in request
        
        // TODO: Validate username and password
        /*
        if (user == null)
        {
            throw new UnauthorizedAccessException("User not found");
        }
        */

        return new LoginResponse {
            AccessToken = "fake-token-123", // Stub JWT
            AccountStatus = "New" // Stub account status existing user
        };
    }
}