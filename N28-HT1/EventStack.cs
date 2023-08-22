namespace N28_HT1;

public class EventStack<T> where T : IEvent
{
    private List<T> _events = new List<T>();

    public void Push(T evt)
    {
        if (_events.Count == 0 || evt.Date >= _events[_events.Count - 1].Date)
        {
            _events.Add(evt);
        }
        else
        {
            throw new InvalidOperationException("Cannot push");
        }
        
    }

    public T Peek()
    {
        if (_events.Count > 0)
        {
            return _events[_events.Count - 1];
        }
        else
        {
            throw new InvalidOperationException("The stack is empty!");
        }
    }

    public T Pop()
    {
        if (_events.Count > 0)
        {
            T popedEvent = _events[_events.Count - 1];
            _events.RemoveAt(_events.Count - 1);
            return popedEvent;
        }
        else
        {
            throw new InvalidOperationException("The stack is empty!");
        }
    }
}