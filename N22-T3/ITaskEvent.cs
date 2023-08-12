namespace N22_T3;

public interface ITaskEvent
{
    Guid Id { get; }
    string Name { get; }
    byte Priority { get; }
}