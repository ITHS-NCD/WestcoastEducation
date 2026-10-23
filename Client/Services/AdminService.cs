using Client.Models;
using Client.Persistence;

namespace Client;

public class AdminService
{
    private static readonly string _path = string.Concat(Environment.CurrentDirectory, "/Data/admins.json");
    public List<Admin> listOfAdmins = [];


    public void Add(Admin admin)
    {
        listOfAdmins.Add(admin);
        Storage<Admin> storage = new();
        storage.Write(listOfAdmins, _path);
    }
}
