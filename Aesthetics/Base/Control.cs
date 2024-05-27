using Aesthetics.Rendering;
using Cabinet;

namespace Aesthetics.Base;

public abstract class Control
{
    internal Vector2 LocalPosition { get; set; }

    protected internal abstract void OnRender(DrawingContext renderer);


    protected internal virtual void OnUIEvent(UIEventArgs uIEventArgs) { }
}