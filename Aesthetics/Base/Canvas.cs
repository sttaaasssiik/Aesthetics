using Aesthetics.Rendering;
using Cabinet;

namespace Aesthetics.Base;

public class Canvas : UIElement
{
    public UIElementCollection Children { get; }

    public Canvas()
    {
        Children = new UIElementCollection(this);
    }

    public static void SetPosition(Visual visual, Vector2 vector2) => visual.LocalPosition = vector2;

    protected internal override void OnRender(DrawingContext drawingContext)
    {
        foreach (var child in Children)
        {
            child.OnRender(drawingContext);
        }
    }

    protected internal override void OnUIEvent(UIEventArgs uIEventArgs) { }
}