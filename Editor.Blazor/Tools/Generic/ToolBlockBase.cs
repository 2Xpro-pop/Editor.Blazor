using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Editor.Blazor.Tools.Generic;
public abstract class ToolBlockBase<T> : ComponentBase, IToolBlock<T>
{
    [Parameter]
    public virtual T? Data
    {
        get;
        set;
    }

    object? IToolBlock.Data
    {
        get => Data;
        set => Data = (T?)value;
    }
    public virtual ValueTask<T?> SaveAsync()
    {
        return new(Data);
    }
    async ValueTask IToolBlock.SaveAsync() => await SaveAsync();
}
