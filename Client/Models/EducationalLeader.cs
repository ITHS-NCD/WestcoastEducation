using Client.Interfaces;
using Client.Persistence;

namespace Client.Models;

public class EducationalLeader(string personNr) : IPerson
{
    public string PersonNumber { get; set; } = personNr;
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required Address Address { get; set; }
    public required string EmploymentDate { get; set; }
}
