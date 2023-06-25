using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Blazor.Tools;
public interface ISection
{
    void SwitchWithTag(string tag);
    void AppendTag(string tag);
    void PrependTag(string tag);
}
