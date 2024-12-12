namespace WeatherForecast;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;

using IStartup = Host.Shared.IStartup;

/// <summary>
/// Register services for the Weather Forecast Module.
/// </summary>
public class Startup : IStartup
{
    /// <inheritdoc />
    public void ConfigureServices(IServiceCollection services)
    {
    }

    /// <inheritdoc />
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
    }
}
