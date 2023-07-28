
using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {

        var classRoom = new UltimateClassroomAttendance();
        classRoom.Mark("Abdurahmon", true);
        classRoom.Mark("Bunyod", true);
        classRoom.Mark("Azizbek", false, "Meeting");
        classRoom.Mark("Qurbonali", false, "Testing in Instite");

        classRoom.Display();
    }
}
