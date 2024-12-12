namespace Host.Shared;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Defines the methods for all module startup classes.
/// </summary>
public interface IStartup
{
    /// <summary>
    /// Configures the services for the module.
    /// </summary>
    /// <param name="services"></param>
    void ConfigureServices(IServiceCollection services);

    /// <summary>
    /// Configures the application and environment for the module.
    /// </summary>
    /// <param name="app"></param>
    /// <param name="env"></param>
    void Configure(IApplicationBuilder app, IWebHostEnvironment env);
}
