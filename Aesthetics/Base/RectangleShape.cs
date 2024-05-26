using Aesthetics.Rendering;
using Cabinet;

namespace Aesthetics.Base;

public class RectangleShape : UIElement
{
    public Color Background { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    protected internal override void Render(ImmediateRenderer renderer)
    {
        renderer.SetRenderDrawColor(Background);
        renderer.FillRectangle(new Rectangle() { Position = Position, Width = Width, Height = Height });
    }
}