using System.Text.Json;
using System.Text.Json.Serialization;

namespace N31_Practice1;

class Program
{
    static void Main()
    {
        var studentPath = @"C:\Users\ferfe\Downloads\Telegram Desktop\Student.json";
        var locationPath = @"C:\Users\ferfe\Downloads\Telegram Desktop\Location.json";
        var specialityPath = @"C:\Users\ferfe\Downloads\Telegram Desktop\Speciality.json";

        var jsonStudents = File.ReadAllText(studentPath);
        var jsonLocation = File.ReadAllText(locationPath);
        var jsonSpeciality = File.ReadAllText(specialityPath);


        var students = JsonSerializer.Deserialize<List<Student>>(jsonStudents);
        var location = JsonSerializer.Deserialize<List<Location>>(jsonLocation);
        var speciality = JsonSerializer.Deserialize<List<Speciality>>(jsonSpeciality);

        // Task - 1
        // var groupedStudents = speciality.GroupJoin(
        //     students,
        //     speciality => speciality.id,
        //     student => student.speciality_id,
        //     (speciality, students) => new
        //     {
        //         Speciality = speciality,
        //         Students = students
        //     });
        //
        // foreach (var item in groupedStudents)
        // {
        //     Console.WriteLine($"{item.Speciality.speciality_name} - {item.Students.Count()}");
        // }
        
        // Task - 2
            var groupedByLocation = students
                .Join(location, 
                    student => student.location_id, 
                    location => location.id, 
                    (student, location) => new
                {
                    student.birth_day,
                    location.lacation_name
                })
                .ToList();
        
            var studentsByLocation = groupedByLocation
                .GroupBy(entry => entry.lacation_name)
                .ToDictionary(
                    group => group.Key,
                    group => group
                        .Select(entry => CalculateAge(entry.birth_day))
                        .ToList());
        
            foreach (var item in studentsByLocation)
            {
                double averageAge = item.Value.Any() ? item.Value.Average() : 0;
                Console.WriteLine($"Location: {item.Key}, Average Age: {averageAge}");
            }
        
        static double CalculateAge(string birthDay)
        {
            DateTime today = DateTime.Today;
            DateTime birthDate = DateTime.ParseExact(birthDay, "d/M/yyyy", null);
            int age = today.Year - birthDate.Year;
            if (today < birthDate.AddYears(age)) age--;
            return age;
        }
    }

}