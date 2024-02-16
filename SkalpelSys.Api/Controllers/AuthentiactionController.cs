using Microsoft.AspNetCore.Mvc;
using SkalpelSys.Application.Services.Authentication;
using SkalpelSys.Contracts.Authentication;
namespace SkalpelSys.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authentiactionService)
    {
        _authenticationService = authentiactionService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
       var authResult = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);
        
        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.FirstName,
            authResult.LaseName,
            authResult.Email,
            authResult.Token
        );

        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationService.Login(
            request.Email,
            request.Password
        );

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.FirstName,
            authResult.LaseName,
            authResult.Email,
            authResult.Token
        );

        return Ok(response);
    }
}