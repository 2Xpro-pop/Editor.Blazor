using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Blazor.Internal;
internal static class EditorBlazorHelper
{
    public static FieldInfo? GetPrivateField(Type t, String name)
    {
        const BindingFlags bf = BindingFlags.Instance |
                                BindingFlags.NonPublic |
                                BindingFlags.DeclaredOnly;

        FieldInfo? fi;
        while ((fi = t.GetField(name, bf)) == null && (t = t.BaseType) != null) ;

        return fi;
    }
}
