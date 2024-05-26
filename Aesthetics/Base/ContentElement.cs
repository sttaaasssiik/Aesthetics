using Aesthetics.Rendering;
using Cabinet;

namespace Aesthetics.Base;

public class ContentElement : UIElement
{
    public Visual? Content { get; set; }

    protected internal override void OnRender(DrawingContext drawingContext)
    {
        drawingContext.SetRenderDrawColor(Color.FromRgba(0, 0, 0, 0));
        Content?.OnRender(drawingContext);
    }

    protected internal override void OnUIEvent(UIEventArgs uIEventArgs) { }
}
