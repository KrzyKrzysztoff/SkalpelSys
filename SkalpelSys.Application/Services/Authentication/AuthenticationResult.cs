using SkalpelSys.Domain.Entities;

namespace SkalpelSys.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token);