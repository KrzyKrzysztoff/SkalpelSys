using Microsoft.Extensions.DependencyInjection;
using SkalpelSys.Application.Common.Authentication;
using SkalpelSys.Infrastructure.Authentication;

namespace SkalpelSys.Infrastructure;

public static class DependencyInjcetion
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
    }
}