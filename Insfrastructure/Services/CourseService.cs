using Domain.Models;

namespace Insfrastructure.Services;

public class CourseService
{
    List<Course> c1 = new List<Course>();
    public List<Course> GetCourses()
    {
        return c1;
    }
    public void AddCourses(Course course)
    {
        c1.Add(course);
    }
    public string UpdateCourses(Course course)
    {
        foreach (var courseet in c1)
        {
            if (courseet.Id == course.Id)
            {
                courseet.Fee = course.Fee;
                System.Console.WriteLine("Course successfully updated");
            }
        }
        return "Group not found";
    }

    public string Delete(int id)
    {
        foreach (var cou in c1)
        {
            if (cou.Id == id)
            {
                c1.Remove(cou);
                return "Group deleted successfully";
            }
        }
        return "Group not found";
    }
}
