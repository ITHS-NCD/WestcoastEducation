using Client.Models;
using Client.Persistence;

namespace Client;

public class CourseService
{
    private readonly static string _path = string.Concat(Environment.CurrentDirectory, "/Data/courses.json");
    public List<Course> listOfCourses = [];

    public CourseService()
    {
        LoadCourse();
    }

    public void Add(Course course)
    {
        listOfCourses.Add(course);
        Storage<Course> storage = new();
        storage.Write(listOfCourses, _path);
    }

    public void LoadCourse()
    {
        Storage<Course> storage = new();
        listOfCourses = storage.Read(_path);
    }
}
