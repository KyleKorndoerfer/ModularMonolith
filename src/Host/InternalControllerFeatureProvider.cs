namespace Host;

using System.Reflection;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

/// <summary>
/// Registers controllers that have 'internal' protection with the application.
/// </summary>
public class InternalControllerFeatureProvider : ControllerFeatureProvider
{
    /// <summary>
    /// Determines if a controller has the 'internal' protection level
    /// </summary>
    /// <param name="typeInfo"></param>
    /// <returns></returns>
    protected override bool IsController(TypeInfo typeInfo)
    {
        var isCustomController = !typeInfo.IsAbstract && typeof(ControllerBase).IsAssignableFrom(typeInfo) && IsInternal(typeInfo);

        return isCustomController || base.IsController(typeInfo);

        static bool IsInternal(TypeInfo t) => t is
        {
            IsVisible: false,
            IsPublic: false,
            IsNotPublic: true,
            IsNested: false,
            IsNestedPublic: false,
            IsNestedFamily: false,
            IsNestedAssembly: false,
            IsNestedFamORAssem: false,
            IsNestedFamANDAssem: false
        };
    }
}
