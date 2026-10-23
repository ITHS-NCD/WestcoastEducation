namespace Client.Models;

public class Admin(string personNo) : EducationalLeader(personNo)
{
    public void AddAdmin()
    {
        AdminService service = new();
        service.Add(this);
    }
}
