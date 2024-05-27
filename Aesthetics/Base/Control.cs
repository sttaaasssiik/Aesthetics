namespace Aesthetics.Base;

public abstract class Control : Visual
{
    protected internal virtual void OnUIEvent(UIEventArgs uIEventArgs) { }
}