using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.JSInterop.Implementation;

namespace Editor.Blazor.Internal;
internal class BlazorEditorJsInterop : IAsyncDisposable
{
    private readonly IJSRuntime _jsRuntime;
    private readonly Lazy<ValueTask<IJSObjectReference>> _moduleTask;

    public BlazorEditorJsInterop(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
        _moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
            "import", "./_content/Editor.Blazor/blazorEditor.js"));
    }

    public async ValueTask<string> GetContentAsync(string id)
    {
        var module = await GetModule();

        return await module.InvokeAsync<string>("getContent", id);
    }

    public async ValueTask DisposeAsync()
    {
        if (_moduleTask.IsValueCreated)
        {
            var module = await _moduleTask.Value;
            await module.DisposeAsync();
        }
    }

    private ValueTask<IJSObjectReference> GetModule() => _moduleTask.Value;
}
