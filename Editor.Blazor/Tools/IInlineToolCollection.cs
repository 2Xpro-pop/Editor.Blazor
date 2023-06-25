using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Tools;
using Editor.Blazor.Tools.Generic;

namespace Editor.Blazor.Tools;
public interface IInlineToolCollection: IReadOnlyList<IInlineTool>
{
    void AddTool<T,U>(string inlineComponentName) where U: IInlineComponent<U> where T : IInlineTool<U>;
    void AddTool<T>() where T: IInlineTool;
}
