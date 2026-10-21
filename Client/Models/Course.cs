namespace Client.Models;

public class Course
{
    public string CourseNumber { get; set; } = Guid.NewGuid().ToString();
    public string CourseTitle { get; set; }
    public required string Length { get; set; }
    public string? Start { get; set; }
    public string? Stop { get; set; }
    public bool ClassRoom { get; set; }
    public bool CanBeBooked { get; set; }
    public List<Course> ListOfCourses { get; set; } = [];

    public Course(string courseTitle)
    {
        CourseTitle = courseTitle;

        if (string.IsNullOrWhiteSpace(Start) && string.IsNullOrWhiteSpace(Stop))
        {
            CanBeBooked = true;
        }
    }
}
