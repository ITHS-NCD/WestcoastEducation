using System;
using Client.Models;
using Client.Persistence;

namespace Client.Services;

public class TeacherService
{
    private static readonly string _path = string.Concat(Environment.CurrentDirectory, "/Data/teachers.json");
    public List<Teacher> listOfTeachers = [];


    public void Add(Teacher teacher)
    {
        listOfTeachers.Add(teacher);
        Storage<Teacher> storage = new();
        storage.Write(listOfTeachers, _path);
    }

}
