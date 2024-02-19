using SkalpelSys.Application;
using SkalpelSys.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
    .AddApplication()
    .AddInfrastructure();  

}
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
    




