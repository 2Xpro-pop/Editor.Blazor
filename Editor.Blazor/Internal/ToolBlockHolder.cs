using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Tools;
using Microsoft.AspNetCore.Components;

namespace Editor.Blazor;
internal class ToolBlockHolder : IToolBlock
{
    public IObservable<IToolBlock?> ToolBoxSetted => _toolBoxSubject;
    private readonly BehaviorSubject<IToolBlock?> _toolBoxSubject = new(null);

    public IToolBlock? ToolBlock
    {
        get => _toolBoxSubject.Value;
        set => _toolBoxSubject.OnNext(value);
    }
    public object? Data
    {
        get => ToolBlock?.Data;
        set => ToolBlock!.Data = value;
    }

    public ValueTask SaveAsync() => ToolBlock!.SaveAsync();
    public void Attach(RenderHandle renderHandle) => ToolBlock!.Attach(renderHandle);
    public Task SetParametersAsync(ParameterView parameters) => ToolBlock!.SetParametersAsync(parameters);
}
