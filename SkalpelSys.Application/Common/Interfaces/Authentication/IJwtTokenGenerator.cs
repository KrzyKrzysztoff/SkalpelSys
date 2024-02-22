using SkalpelSys.Domain.Entities;

namespace SkalpelSys.Application.Common.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}