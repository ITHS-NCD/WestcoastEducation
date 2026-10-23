using Client.Persistence;

namespace Client.Models;

public class Course
{
    public string CourseNumber { get; set; } = Guid.NewGuid().ToString();
    public string CourseTitle { get; set; }
    public required string Length { get; set; }
    public required bool ClassRoom { get; set; }
    public string? Start { get; set; }
    public string? Stop { get; set; }
    public List<Student> Students { get; set; } = [];

    public Course(string courseTitle)
    {
        CourseTitle = courseTitle;
    }

    public void AddCourse()
    {
        CourseService service = new();
        service.Add(this);
    }

    public override string ToString()
    {
        return $"Kurs titel: {CourseTitle} - Längd: {Length} - Start: {Start} - Slut: {Stop} - Lektion i klassrummet: {ClassRoom}";
    }

}
