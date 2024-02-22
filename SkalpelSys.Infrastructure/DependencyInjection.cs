using Microsoft.Extensions.DependencyInjection;
using SkalpelSys.Application.Common.Authentication;
using SkalpelSys.Application.Common.Interfaes.Services;
using SkalpelSys.Infrastructure.Authentication;
using SkalpelSys.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using SkalpelSys.Application.Common.Interfaces.Presistence;
using SkalpelSys.Infrastructure.Presistance;

namespace SkalpelSys.Infrastructure;

public static class DependencyInjcetion
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
         ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}