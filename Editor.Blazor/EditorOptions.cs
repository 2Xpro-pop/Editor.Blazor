using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Tools;

namespace Editor.Blazor;
public sealed class EditorOptions
{
    public IInlineToolCollection InlineTools
    {
        get;
    }

    public IToolBlockCollection ToolBlocks
    {
        get;
    }

    /// <summary>
    /// Default strategy is ISurroundInlineComponentStrategy.RemoveAndPaste
    /// </summary>
    public ISurroundInlineComponentStrategy SurroundInlineComponentStrategy
    {
        get;
        set;
    } 
}
