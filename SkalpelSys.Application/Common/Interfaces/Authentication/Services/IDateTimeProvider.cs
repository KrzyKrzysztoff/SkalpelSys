namespace SkalpelSys.Application.Common.Interfaes.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}