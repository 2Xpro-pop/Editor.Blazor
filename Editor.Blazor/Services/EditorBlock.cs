﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Editor.Blazor.Services;
public class EditorBlock
{
    public string Name
    {
        get; set;
    }

    public JsonDocument Data
    {
        get; set;
    }
}
