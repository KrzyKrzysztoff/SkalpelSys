using SkalpelSys.Application.Common.Interfaes.Services;

namespace SkalpelSys.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}