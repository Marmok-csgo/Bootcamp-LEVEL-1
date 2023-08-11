namespace N22_T1;

public class Student<TId, TGrade>
{
    public TId StudentId { get; set; }
    
    public string? Name { get; set; }
    
    public TGrade Grade { get; set; }


    public Student(TId studentid, string name, TGrade grade)
    {
        StudentId = studentid;
        Name = name;
        Grade = grade;
    }
}