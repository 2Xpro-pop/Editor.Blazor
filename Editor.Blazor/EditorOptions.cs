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
    } = null!;

    public IToolBlockCollection ToolBlocks
    {
        get;
    } = null!;

    /// <summary>
    /// Default strategy is ISurroundInlineComponentStrategy.RemoveAndPaste
    /// </summary>
    public ISurroundInlineComponentStrategy SurroundInlineComponentStrategy
    {
        get;
        set;
    } = null!;
}
