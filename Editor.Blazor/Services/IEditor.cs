using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Tools;

namespace Editor.Blazor.Services;
public interface IEditor : IList<IToolBlock>
{
    bool IsEditorMode
    {
        get; set;
    }
    Task LoadDataAsync(EditorData editorData);
    ValueTask<EditorData> SaveAsync();

}
