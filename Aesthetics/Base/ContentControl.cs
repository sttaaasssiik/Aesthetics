using Aesthetics.Rendering;

namespace Aesthetics.Base;

public class ContentControl : Control
{
    public Control? Content { get; set; }

    protected internal override void OnRender(DrawingContext drawingContext)
    {
        Content?.OnRender(drawingContext);
    }

    protected internal override void OnUIEvent(UIEventArgs uIEventArgs) { }
}