namespace Aesthetics.Base;

public class UIElementCollection
{
    private readonly List<UIElement> uIElements = [];

    private readonly Canvas canvas;

    internal UIElementCollection(Canvas canvas) => this.canvas = canvas;

    public void Add(UIElement uIElement) => uIElements.Add(uIElement);

    public IEnumerator<UIElement> GetEnumerator() => uIElements.GetEnumerator();
}