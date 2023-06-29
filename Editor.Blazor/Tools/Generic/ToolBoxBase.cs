using System.Reactive.Subjects;
using Microsoft.AspNetCore.Components;

namespace Editor.Blazor.Tools.Generic;
public abstract class ToolBoxBase<T, U> : ComponentBase, IToolBox where T : IToolBlock<U>
{
    public IObservable<ToolBlockInstance> BlockGenerated => _blockGenerated;

    protected readonly Subject<ToolBlockInstance> _blockGenerated = new();

    protected void Generate(U? data = default)
    {
        var holder = new ToolBlockHolder();
        _blockGenerated.OnNext(new()
        {
            Instance = holder,
            View = builder =>
        {
            builder.OpenComponent<T>(0);
            builder.AddAttribute(1, "Data", data);
            builder.AddComponentReferenceCapture(2, instance => holder.ToolBlock = (IToolBlock)instance);
            builder.CloseComponent();
        }
        });
    }

}
