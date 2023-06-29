using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Blazor.Services;
public class EditorData
{
    public ExpandoObject? EditorContext
    {
        get; set;
    }

    public required IEnumerable<EditorBlock> Blocks
    {
        get;
        set;
    } 
}
