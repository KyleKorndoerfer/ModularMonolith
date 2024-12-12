namespace Host.ModuleIntegration;

using Microsoft.AspNetCore.Mvc.ApplicationModels;

/// <summary>
/// Defines a routing convention for modules.
/// </summary>
public class ModuleRoutingConvention : IActionModelConvention
{
    private readonly IEnumerable<Module> _modules;

    /// <summary>
    /// Initializes a new instance.
    /// </summary>
    /// <param name="modules"></param>
    public ModuleRoutingConvention(IEnumerable<Module> modules)
    {
        _modules = modules;
    }

    /// <summary>
    /// Applies the routing convention to the supplied action.
    /// </summary>
    /// <param name="action"></param>
    public void Apply(ActionModel action)
    {
        var module = _modules.FirstOrDefault(m => m.Assembly == action.Controller.ControllerType.Assembly);
        if (module is null)
        {
            return;
        }

        action.RouteValues.Add("module", module.RoutePrefix);
    }
}
