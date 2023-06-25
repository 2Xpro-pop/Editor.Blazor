using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Editor.Blazor.Tools;
public interface IInlineTool: IComponent
{
    public EventCallback<MouseEventArgs> Click
    {
        get; set;
    }

    public void Surround(ISection section);
}
