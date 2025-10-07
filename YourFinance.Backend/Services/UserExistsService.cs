namespace YourFinance.Backend.Services;

public class UserExistsService {
    // Will return string or null
    public bool UserExists(string username)
    {
        // TODO: Query database for username
        var dbUsername = username;
        return !string.IsNullOrWhiteSpace(dbUsername);
    }
}