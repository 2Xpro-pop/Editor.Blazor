using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Editor.Blazor.Tools.Generic;
public interface IToolBlock<T>: IToolBlock
{
    public new T? Data
    {
        get; set;
    }

    new ValueTask<T?> SaveAsync();
}
