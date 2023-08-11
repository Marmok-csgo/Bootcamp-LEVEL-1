namespace N22_T1;

public class Univercity<TStudent, TId, TGrade> where TStudent : Student<TId, TGrade>
{
    private List<TStudent> Students = new List<TStudent>();
    private List<Course> Courses = new List<Course>();
    
    public void EnrollStudent(TStudent student, Course course)
    {
        Students.Add(student);
        Courses.Add(course);
    }


    public void Display()
    {
        for (int i = 0; i < Students.Count; i++)
        {
            Console.WriteLine($"{Students[i].StudentId}||{Students[i].Name}||{Students[i].Grade}| ---- |{Courses[i].CourseId}||{Courses[i].Title}");
        }
    }
}