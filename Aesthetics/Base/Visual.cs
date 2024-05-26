﻿using Aesthetics.Rendering;
using Cabinet;

namespace Aesthetics.Base;

public abstract class Visual
{
    public Color Background { get; set; }

    internal Vector2 LocalPosition { get; set; }

    protected internal abstract void OnRender(DrawingContext renderer);
}