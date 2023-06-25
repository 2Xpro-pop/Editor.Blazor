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
/// If you are using a custom Blazor component, 
/// it is not necessary to implement this interface. 
/// However, if you are using simple tags (e.g., 'b', 'i', 'a'), 
/// you can go ahead and implement this interface. 
/// For other cases, it is recommended to implement <see cref="IInlineTool{T}"/> instead.
/// </summary>
public interface IInlineTool: IComponent
{
    public EventCallback<MouseEventArgs> Click
    {
        get; set;
    }

    public void Surround(ISection section);
}
