using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Editor.Blazor.Tools.Generic;

namespace Editor.Blazor.Tools.Generic;
public interface IToolBox<T>: IToolBox where T: IToolBlock
{
    new T GenerateComponent();
}
