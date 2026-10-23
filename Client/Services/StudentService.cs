using Client.Models;
using Client.Persistence;

namespace Client.Services;

public class StudentService
{
    private static readonly string _path = string.Concat(Environment.CurrentDirectory, "/Data/students.json");
    public List<Student> listOfStudents = [];

    public StudentService()
    {
        LoadStudents();
    }

    public void Add(Student student)
    {
        listOfStudents.Add(student);
        Storage<Student> storage = new();
        storage.Write(listOfStudents, _path);
    }

    public void LoadStudents()
    {
        Storage<Student> storage = new();
        listOfStudents = storage.Read(_path);
    }
}
