namespace SkalpelSys.Application.Services.Authentication;

public record AuthenticationResult(
    Guid Id,
    string FirstName,
    string LaseName,
    string Email,
    string Token);