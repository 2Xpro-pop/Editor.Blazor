using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Tools;

namespace Editor.Blazor;
public static class ToolBoxExtensions
{
    public static async Task WaitUntilReady(this IToolBlock toolBlock)
    {
        if (toolBlock is ToolBlockHolder holder)
        {
            await holder.ToolBoxSetted.Where(tb => tb != null).FirstAsync();
        }
    }

    public static async Task WaitUntilReady(this ToolBlockInstance toolBlock)
    {
        await toolBlock.Instance.WaitUntilReady();
    }
}
