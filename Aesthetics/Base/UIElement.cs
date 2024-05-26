namespace Aesthetics.Base;

public abstract class UIElement : Visual
{
    protected internal virtual void OnUIEvent(UIEventArgs uIEventArgs) { }
}