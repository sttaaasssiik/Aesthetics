using Aesthetics.Rendering;

namespace Aesthetics.Base;

public class Canvas : UIElement
{
    public UIElementCollection Children { get; }

    public Canvas()
    {
        Children = new UIElementCollection(this);
    }

    protected internal override void OnRender(DrawingContext renderer) { }
}