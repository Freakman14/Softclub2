using System.Data;
using Domain.Models;

namespace Insfrastructure.Services;

public class TeacherService
{
    List<Teachers> t1 = new List<Teachers>();
    public List<Teachers> GetTeachers()
    {
        return t1;
    }
    public void AddTeachers(Teachers teachers)
    {
        t1.Add(teachers);
    }

    public string UpdateTeachers(Teachers teachers)
    {
        foreach (var teach in t1)
        {
            if (teach.Id == teachers.Id)
            {
                teach.Position = teachers.Position;
                teach.ExperianceAmount = teachers.ExperianceAmount;
                System.Console.WriteLine("Teachers successfully updated");
            }
        }
        return "Group not found";
    }

    public string Delete(int id)
    {
        foreach (var tea in t1)
        {
            if (tea.Id == id)
            {
                t1.Remove(tea);
                return "Group deleted successfully";
            }
        }
        return "Group not found";
    }
}
