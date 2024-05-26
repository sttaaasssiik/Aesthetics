using Aesthetics.Rendering;
using Cabinet;

namespace Aesthetics.Base;

public class RectangleShape : UIElement
{
    public Color Background { get; set; }

    public Rectangle Rectangle { get; set; }

    protected internal override void Render(ImmediateRenderer renderer)
    {
        renderer.SetRenderDrawColor(Background);
        renderer.FillRectangle(Rectangle);
    }
}