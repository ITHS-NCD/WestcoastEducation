using Client.Models;
using Client.Persistence;

namespace Client;

public class EducationalService
{
    private static readonly string _path = string.Concat(Environment.CurrentDirectory, "/Data/educationalLeaders.json");
    public List<EducationalLeader> listOfeducationalLeaders = [];


    public void Add(EducationalLeader educationalLeader)
    {
        listOfeducationalLeaders.Add(educationalLeader);
        Storage<EducationalLeader> storage = new();
        storage.Write(listOfeducationalLeaders, _path);
    }
}
