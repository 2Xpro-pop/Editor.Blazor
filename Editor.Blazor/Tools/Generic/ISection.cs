using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Blazor.Tools.Generic;
public interface ISection<T>: ISection where T : IInlineComponent
{
    /// <summary>
    /// NOT RECOMMENDED TO USE
    /// </summary>
    /// <param name="data">data which pass to IInlineComponent</param>
    void SurroundWithComponent(object data);
    void AppendComponent(object data);
    void PrependComponent(object data);
}
