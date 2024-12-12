namespace Host.ModuleIntegration;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

/// <summary>
/// Post configure options implementation so we can inject <seealso cref="Module"/> and pass it to <seealso cref="ModuleRoutingConvention"/>.
/// </summary>
public class ModuleRoutingMvcOptionsPostConfigure : IPostConfigureOptions<MvcOptions>
{
    private readonly IEnumerable<Module> _modules;

    /// <summary>
    /// Initializes a new instance.
    /// </summary>
    /// <param name="modules"></param>
    public ModuleRoutingMvcOptionsPostConfigure(IEnumerable<Module> modules)
    {
        _modules = modules;
    }

    /// <inheritdoc />
    public void PostConfigure(string? name, MvcOptions options)
    {
        options.Conventions.Add(new ModuleRoutingConvention(_modules));
    }
}
