using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Editor.Blazor.Tools.Generic;

namespace Editor.Blazor.Tools;

/// <summary>
/// Don't implement this interface yourself, it's need for internal functionality.
/// Instead implementing this interface, implement <see cref="InlineComponentBase{T}"/>
/// </summary>
public interface IInlineComponent : IComponent
{
    public object? Data
    {
        get; set;
    }

    public ValueTask SaveAsync();
}
