using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Editor.Blazor.Tools.Generic;
public interface IInlineComponent<T>: IInlineComponent
{
    public new T? Data
    {
        get; set;
    }

    public new ValueTask<T?> SaveAsync();
}
