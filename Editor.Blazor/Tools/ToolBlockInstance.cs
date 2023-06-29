using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Editor.Blazor.Tools;

public readonly struct ToolBlockInstance
{
    public required IToolBlock Instance
    {
        get
        {
            if (_instance is ToolBlockHolder holder)
            {
                return holder.ToolBlock ?? holder;
            }
            return _instance;
        }
        init => _instance = value;
    }
    private readonly IToolBlock _instance;

    public required RenderFragment View
    {
        get;
        init;
    }
}
