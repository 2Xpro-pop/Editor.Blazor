using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection;
public static class EditorBlazorServiceCollectionExtensions
{
    public static void AddEditorBlazor(this IServiceCollection services)
    {
        services.AddTransient<BlazorEditorJsInterop>();
    }
}
