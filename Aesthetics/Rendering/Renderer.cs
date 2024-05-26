using Aesthetics.Base;
using Cabinet;

namespace Aesthetics.Rendering;

internal class Renderer
{
    private readonly DrawingContext drawingContext;

    public Renderer(DrawingContext drawingContext)
    {
        this.drawingContext = drawingContext;
    }

    public void Render(Visual visual)
    {
        drawingContext.SetRenderDrawColor(Color.FromRgba(0, 0, 0, 0));
        drawingContext.Clear();
        visual.OnRender(drawingContext);
        drawingContext.Present();
    }
}