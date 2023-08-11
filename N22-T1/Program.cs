namespace N22_T1;

class Program
{
    static void Main()
    {

        var student1 = new Student<int, string>(1, "Firdavs", "A");
        var student2 = new Student<int, string>(2, "Aziz", "B");
        
        var course1 = new Course("Mathematics");
        var course2 = new Course("History");
        
        var university = new Univercity<Student<int, string>, int, string>();
        
        university.EnrollStudent(student1, course1);
        university.EnrollStudent(student2, course2);
        
        university.Display();
    }
}

