using Client.Interfaces;

namespace Client.Models;

public class Teacher(string personNumber) : IPerson
{
    public string PersonNumber { get; set; } = personNumber;
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string PhoneNumber { get; set; }
    public required Address Address { get; set; }
    public string? Knowledge { get; set; }
    public string? Responsibility { get; set; }

}
