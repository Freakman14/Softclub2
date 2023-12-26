using System.Net.WebSockets;
using Domain.Models;

namespace Insfrastructure.Services;

public class StudentService
{
    List<Student> st1 = new List<Student>();
    public List<Student> GetStudents()
    {
        return st1;
    }
    public void AddStudent(Student student)
    {
        st1.Add(student);
    }
    public string UpdateStudent(Student student)
    {
        foreach (var studen in st1)
        {
            if (studen.Id == student.Id)
            {
                studen.Firstname = student.Firstname;
                studen.Lastname = student.Lastname;
                System.Console.WriteLine("Student successfully updated");
            }
        }
        return "Group not found";
    }
    public string Delete(int id)
    {
        foreach (var student in st1)
        {
            if (student.Id == id)
            {
                st1.Remove(student);
                return "Group deleted successfully";
            }
        }
        return "Group not found";
    }
}
