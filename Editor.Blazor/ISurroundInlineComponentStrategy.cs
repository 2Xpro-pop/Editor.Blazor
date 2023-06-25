using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Editor.Blazor;
public interface ISurroundInlineComponentStrategy
{
    void Surround(IJSObjectReference range, string componentName, Type componentType, )
}
