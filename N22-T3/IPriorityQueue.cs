namespace N22_T3;

public interface IPriorityQueue<TEvent> where TEvent : ITaskEvent
{
    void Enqueue(TEvent eventItem);

    TEvent Dequeue();

    TEvent Peek();
}