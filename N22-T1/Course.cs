namespace N22_T1;

public class Course
{
    public Guid CourseId { get; set; }
    
    public string? Title { get; set; }


    public Course(string title)
    {
        CourseId = Guid.NewGuid();
        Title = title;
    }
}