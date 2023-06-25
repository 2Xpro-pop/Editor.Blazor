using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Internal;
using Microsoft.Extensions.DependencyInjection;
using Radzen;

namespace Microsoft.Extensions.DependencyInjection;
public static class EditorBlazorServiceCollectionExtensions
{
    public static void AddEditorBlazor(this IServiceCollection services)
    {
        services.AddScoped<DialogService>();
        services.AddScoped<NotificationService>();
        services.AddScoped<TooltipService>();
        services.AddScoped<ContextMenuService>();
        services.AddSingleton<BlazorEditorJsInterop>();
    }
}
