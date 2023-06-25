using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Blazor.Tools.Generic;
public interface IInlineTool<T>: IInlineTool where T: IInlineComponent
{
    public void Surround(ISection<T> section);
}
