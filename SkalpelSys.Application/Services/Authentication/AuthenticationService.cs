using SkalpelSys.Application.Common.Authentication;

namespace SkalpelSys.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _iJwtTokenGenerator;
    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    { 
        _iJwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // Check if user already exist

        // Create user (generate unique id)

        // Create JWT token
        Guid userId = Guid.NewGuid();

        string token = _iJwtTokenGenerator.GenerateToken(userId, firstName, lastName);

        return new AuthenticationResult(
            userId,
            firstName,
            lastName,
            email,
            token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "FirstName",
            "LastName",
            email,
            "token");
    }
}