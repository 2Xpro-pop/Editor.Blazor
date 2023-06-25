using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Tools.Generic;

namespace Editor.Blazor.Tools;
public interface IToolBlockCollection: IReadOnlyList<IToolBox>
{
    void AddTool<T, U>(string name) where U : IToolBlock where T : IToolBlock<U>;
}
