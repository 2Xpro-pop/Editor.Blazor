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
/// Instead implementing this interface, implement <see cref="IToolBox{T}"/>
/// </summary>
public interface IToolBox : IComponent
{
    public EventCallback<MouseEventArgs> Click
    {
        get; set;
    }
    IToolBlock GenerateComponent();
}
