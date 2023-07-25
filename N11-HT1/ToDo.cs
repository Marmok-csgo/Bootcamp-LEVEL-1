namespace N11_HT1;
public class ToDo
{
    public string Task;
    public bool IsDone;



    public ToDo(string task)
    {
        Task = task;
    }



    public override string ToString()
    {
        return $"{Task}";
    }
}