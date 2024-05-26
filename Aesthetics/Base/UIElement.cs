using Aesthetics.Rendering;

namespace Aesthetics.Base;

public abstract class UIElement : Visual
{
    protected internal abstract void OnRender(DrawingContext renderer);
}