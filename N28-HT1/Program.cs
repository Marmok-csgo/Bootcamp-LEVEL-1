namespace N28_HT1;

class Program
{
    static void Main()
    {
        EventStack<Event> eventStack = new EventStack<Event>();

        var event1 = new Event(1, "Conference", DateTime.Now);
        var event2 = new Event(2, "Seminar", DateTime.Now.AddDays(1));
        var event3 = new Event(3, "Lecture", DateTime.Now.AddDays(2));
        
        eventStack.Push(event1);
        eventStack.Push(event2);
        eventStack.Push(event3);

        Console.WriteLine($"Peeked event: {eventStack.Peek().Name}");
        var popedEvent = eventStack.Pop();
        Console.WriteLine($"Poped event: {popedEvent.Name}");
        Console.WriteLine($"Peeked event: {eventStack.Peek().Name}");
        
    }
}