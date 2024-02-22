using SkalpelSys.Application.Common.Interfaces.Presistence;
using SkalpelSys.Domain.Entities;

namespace SkalpelSys.Infrastructure.Presistance;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _user = new();
    public void Add(User user)
    {
        _user.Add(user);
    }

    public User? GetUserByEmail(string email)
    {
        return _user.SingleOrDefault(u => u.Email == email);
    }
}