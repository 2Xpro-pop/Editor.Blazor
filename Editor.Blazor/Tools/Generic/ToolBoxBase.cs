using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Editor.Blazor.Tools.Generic;
public abstract class ToolBoxBase<T> : ComponentBase, IToolBox<T> where T : IToolBlock
{
    [Parameter]
    public EventCallback<MouseEventArgs> Click
    {
        get;
        set;
    }

    public abstract T GenerateComponent();
    IToolBlock IToolBox.GenerateComponent() => GenerateComponent();
}
