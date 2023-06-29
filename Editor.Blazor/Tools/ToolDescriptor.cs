using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Radzen;

namespace Editor.Blazor.Tools;
public sealed class ToolDescriptor
{
    public required string Name
    {
        get; set;
    }
    public required Type ToolType
    {
        get => _toolType;
        set
        {
            if (value == null)
            {
                throw new InvalidOperationException("ToolType must not be null!");
            }
            if (typeof(IToolBox).IsAssignableFrom(value))
            {
                _toolType = value;
                return;
            }
            if (typeof(IInlineTool).IsAssignableFrom(value))
            {
                _toolType = value;
                return;
            }
            throw new InvalidOperationException($"Invalid type. Type must be {nameof(IToolBox)} or {nameof(IInlineTool)}.");
        }
    }
    private Type _toolType = null!;


}
