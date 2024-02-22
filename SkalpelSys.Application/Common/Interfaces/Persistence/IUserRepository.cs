using SkalpelSys.Domain.Entities;

namespace SkalpelSys.Application.Common.Interfaces.Presistence;
public interface IUserRepository
{
    void Add(User user);
    User? GetUserByEmail(string email);
}