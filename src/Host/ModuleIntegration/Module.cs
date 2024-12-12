namespace Host.ModuleIntegration;

using System.Reflection;

using Shared;

/// <summary>
/// Contains information about a module.
/// </summary>
public class Module
{
    /// <summary>
    /// Gets the route prefix to all controller endpoints in the module.
    /// </summary>
    public string RoutePrefix { get; }

    /// <summary>
    /// Gets the startup class of the module.
    /// </summary>
    public IStartup Startup { get; }

    /// <summary>
    /// Gets the assembly of the module
    /// </summary>
    public Assembly Assembly => Startup.GetType().Assembly;

    /// <summary>
    /// Initializes a new instance.
    /// </summary>
    /// <param name="routePrefix">Routing prefix.</param>
    /// <param name="startup">The startup class for the module.</param>
    public Module(string routePrefix, IStartup startup)
    {
        RoutePrefix = routePrefix;
        Startup = startup;
    }
}
