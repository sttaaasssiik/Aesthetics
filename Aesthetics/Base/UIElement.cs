using Aesthetics.Rendering;
using Cabinet;

namespace Aesthetics.Base;

public abstract class UIElement
{
    public Vector2 Position { get; set; }

    protected internal abstract void Render(CommandRenderer renderer);
}