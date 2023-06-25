using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Blazor.Services;
public class EditorData
{
    public dynamic EditorContext
    {
        get; set;
    }

    public IEnumerable<EditorBlock> Blocks
    {
        get;
        set;
    }
}
