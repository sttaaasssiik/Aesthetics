using Aesthetics.Rendering;

namespace Aesthetics.Base;

public class ContentElement : UIElement
{
    public Visual? Content { get; set; }

    protected internal override void OnRender(DrawingContext renderer) { }
}
