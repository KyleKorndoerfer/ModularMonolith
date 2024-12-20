﻿namespace Host.ModuleIntegration;

using Microsoft.AspNetCore.Mvc.ApplicationParts;

/// <summary>
/// Registers a module in the service collection.
/// </summary>
public static class ModuleServiceCollection
{
    /// <summary>
    /// Adds a module.
    /// </summary>
    /// <param name="services"></param>
    /// <param name="routePrefix">The prefix of the routes to the module.</param>
    /// <typeparam name="TStartup">The type of the startup class of the module.</typeparam>
    /// <returns></returns>
    public static IServiceCollection AddModule<TStartup>(this IServiceCollection services, string routePrefix)
        where TStartup : Host.Shared.IStartup, new()
    {
        // Register assembly in MVC so it can find controllers of the module
        services.AddControllers().ConfigureApplicationPartManager(manager =>
                manager.ApplicationParts.Add(new AssemblyPart(typeof(TStartup).Assembly)));

        var startup = new TStartup();
        startup.ConfigureServices(services);

        services.AddSingleton(new Module(routePrefix, startup));

        return services;
    }
}
