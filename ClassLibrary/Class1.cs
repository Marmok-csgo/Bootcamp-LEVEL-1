namespace ClassLibrary
{
    public class ClassroomAttendance
    {
        protected Dictionary<string, string> Students = new Dictionary<string, string>();


        public virtual void Display()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
        }


        public void Mark( string fullName, bool isPresent)
        {
            Students[fullName] = isPresent ? "present" : "absert";
        }

        internal protected double GetStats()
        {
            var count = default(int);
            foreach (var std in Students)
            {
                if (std.Value == "present")
                    count++;
            }
            return ((double)count / Students.Count) * 100;
        }
    }

    public class UltimateClassroomAttendance : ClassroomAttendance
    {
        public new void Mark( string fullName, bool isPresent , string cause = "")
        {
            Students.Add(fullName, isPresent ? "present" : "absert " + cause);
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Qatnashishlik foizi: {GetStats()}%");
        }
    }
}