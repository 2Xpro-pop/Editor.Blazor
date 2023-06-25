﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Editor.Blazor.Tools;
public interface IInlineComponent : IComponent
{
    public object? Data
    {
        get; set;
    }

    public ValueTask SaveAsync();
}
