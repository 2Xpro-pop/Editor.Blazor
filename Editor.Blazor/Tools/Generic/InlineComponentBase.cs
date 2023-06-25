using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Editor.Blazor.Tools.Generic;
public abstract class InlineComponentBase<T> : ComponentBase, IInlineComponent<T>
{
    public T? Data
    {
        get;
        set;
    }
    object? IInlineComponent.Data
    {
        get => Data;
        set => Data = (T?)value;
    }

    public virtual ValueTask<T?> SaveAsync()
    {
        return new ValueTask<T?>(Data);
    }
    async ValueTask IInlineComponent.SaveAsync() => await SaveAsync();
}
