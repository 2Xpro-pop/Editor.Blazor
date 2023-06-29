using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Editor.Blazor.Tools.Generic;

namespace Editor.Blazor.Tools;

/// <summary>
/// Don't implement this interface yourself, it's need for internal functionality.
/// Instead implementing this interface, implement <see cref="ToolBoxBase{T}"/>
/// </summary>
public interface IToolBox : IComponent
{
    /// <summary>
    /// Each time you generate a new block, raise an event indicating that it has been generated. 
    /// Generate the block in accordance with the UX (button click, opening a modal window, 
    /// configuring a component, and then generating it if necessary), rather than randomly.
    /// </summary>
    public IObservable<ToolBlockInstance> BlockGenerated
    {
        get;
    }
}
