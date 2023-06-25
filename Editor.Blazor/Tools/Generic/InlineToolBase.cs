using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Editor.Blazor.Tools.Generic;
public abstract class InlineToolBase<T> : ComponentBase, IInlineTool<T> where T : IInlineComponent
{
    [Parameter]
    public virtual EventCallback<MouseEventArgs> Click
    {
        get;
        set;
    }

    public virtual void Surround(ISection<T> section)
    {
    }
    public virtual void Surround(ISection section)
    {
    }
}
