using System.Diagnostics;
using SkalpelSys.Application.Common.Authentication;
using SkalpelSys.Application.Common.Interfaces.Presistence;
using SkalpelSys.Domain.Entities;

namespace SkalpelSys.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;
    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    { 
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        if(_userRepository.GetUserByEmail(email) is not null)
        {
            throw new Exception("User with given email already exists.");
        }

        var user = new User
        {
            FirstName = firstName,
            Email = email,
            Password = password,
            LastName = lastName
        };

        _userRepository.Add(user);

        string token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }

    public AuthenticationResult Login(string email, string password)
    {

        if(_userRepository.GetUserByEmail(email) is not User user)
        {
            throw new Exception("User with given email doesnt not exist.");
        }

        if(user.Password != password)
        {
            throw new Exception("Invalid password.");
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token);
    }
}