using Client.Models;
using Client.Services;

namespace Client;

class Program
{
    static void Main()
    {
        Course course = new("Programering med C#")
        {
            Length = "10 veckor",
            Start = "2026-10-10",
            Stop = "2026-12-31",
            ClassRoom = true,
        };
        Console.WriteLine($"Lägger till en kurs: {course}");
        course.AddCourse();

        Console.WriteLine("===========================================================================");

        Student student = new("19501212 - 1234")
        {
            FirstName = "Alfred",
            LastName = "Wendt",
            Email = "affewendt@gmail.com",
            PhoneNumber = "0760-869095",
            Address = new Address { AddressLine = "Mölndalsvägen 69A", PostalCode = "412 85", City = "Göteborg" }
        };
        Console.WriteLine($"Lägger till en elev: {student}");
        student.AddStudent();

        Console.WriteLine("===========================================================================");

        Teacher teacher = new("19990101-9876")
        {
            FirstName = "Lukas",
            LastName = "Svensson",
            Email = "l.svensson@mail.se",
            PhoneNumber = "0760-987654",
            Address = new Address { AddressLine = "Vårlöksvägen 73", PostalCode = "446 36", City = "Älvängen" },
            Knowledge = "Programmering med olika spårk",
            Responsibility = "Programmering med C#"
        };

        Console.WriteLine($"Lägger till en lärare: {teacher}");
        teacher.AddTeacher();

        Console.WriteLine("===========================================================================");

        EducationalLeader educationalLeader = new("19900202-2345")
        {
            FirstName = "Håkan",
            LastName = "Johansson",
            Email = "johanssonhakan@outlook.com",
            PhoneNumber = "031-489562",
            Address = new Address { AddressLine = "Gatan 1", PostalCode = "123 45", City = "Mölndal" },
            EmploymentDate = "2020-05-23"
        };

        Console.WriteLine($"Lägger till en utbildningsledare: {educationalLeader}");
        educationalLeader.AddEducationLeader();

        Console.WriteLine("===========================================================================");

        Admin admin = new("19800303-5869")
        {
            FirstName = "Lisa",
            LastName = "Andersson",
            Email = "andersson@mail.com",
            PhoneNumber = "0805-258369",
            Address = new Address { AddressLine = "Vägen 24", PostalCode = "444 25", City = "Landvetter" },
            EmploymentDate = "2025-06-30"
        };

        Console.WriteLine($"Lägger till en administratör: {admin}");
        admin.AddAdmin();

        Console.WriteLine("===========================================================================");



        CourseService courseService = new();

        Console.WriteLine("Våra kurser");
        foreach (var item in courseService.listOfCourses)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("--------------------------------------------------------------------------------");

        Console.WriteLine("Våra studenter");
        StudentService studentService = new();
        foreach (var item in studentService.listOfStudents)
        {
            Console.WriteLine(item);
        }

    }
}
