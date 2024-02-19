using Microsoft.Extensions.DependencyInjection;
using SkalpelSys.Application.Services.Authentication;

namespace SkalpelSys.Application;

public static class DependencyInjcetion
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}