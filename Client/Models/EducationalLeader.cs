using Client.Interfaces;
using Client.Persistence;

namespace Client.Models;

public class EducationalLeader(string personNr) : Teacher(personNr)
{
    public required string EmploymentDate { get; set; }

    public void AddEducationLeader()
    {
        EducationalService service = new();
        service.Add(this);
    }

}
