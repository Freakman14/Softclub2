using Domain.Models;
using Insfrastructure.Services;

var student = new Student();
student.Id = 5;
student.Firstname = "Sanjar";
student.Lastname = "Tolibov";
student.BirthDate = 28;
student.Address = "Firdavsi";

var stud = new StudentService();
stud.AddStudent(student);

foreach (var studs in stud.GetStudents())
{
    System.Console.WriteLine(studs.Id);
    System.Console.WriteLine(studs.Firstname);
    System.Console.WriteLine(studs.Lastname);
    System.Console.WriteLine(studs.BirthDate);
    System.Console.WriteLine(studs.Address);
}

var update = new Student();
{
    update.Id = 2;
    update.Firstname = "Abdullo";
    update.BirthDate = 11;
}

System.Console.WriteLine();
System.Console.WriteLine(stud.UpdateStudent(update));

foreach (var studs in stud.GetStudents())
{
    System.Console.WriteLine(studs.Id);
    System.Console.WriteLine(studs.Firstname);
    System.Console.WriteLine(studs.BirthDate);
}

System.Console.WriteLine();
System.Console.WriteLine(stud.Delete(3));

foreach (var studs in stud.GetStudents())
{
    System.Console.WriteLine(studs.Id);
    System.Console.WriteLine(studs.Firstname);
    System.Console.WriteLine(studs.BirthDate);
}

System.Console.WriteLine("=======Student end========");


var teach = new Teachers();
teach.Id = 7;
teach.Firstname = "Polo";
teach.Lastname = "Boss";
teach.Position = "right";
teach.ExperianceAmount = 10;

var teaches = new TeacherService();
teaches.AddTeachers(teach);

foreach (var teachers in teaches.GetTeachers())
{
    System.Console.WriteLine(teachers.Id);
    System.Console.WriteLine(teachers.Firstname);
    System.Console.WriteLine(teachers.Lastname);
    System.Console.WriteLine(teachers.Position);
    System.Console.WriteLine(teachers.ExperianceAmount);
}

var tes = new Teachers();
{
    tes.Position = "Left";
    tes.ExperianceAmount = 10;
}
System.Console.WriteLine();
System.Console.WriteLine(teaches.UpdateTeachers(tes));

foreach (var it in teaches.GetTeachers())
{
    System.Console.WriteLine(it.Position);
    System.Console.WriteLine(it.ExperianceAmount);
}
System.Console.WriteLine();
System.Console.WriteLine(teaches.Delete(3));
foreach (var it in teaches.GetTeachers())
{
    System.Console.WriteLine(it.Firstname);
    System.Console.WriteLine(it.Position);
    System.Console.WriteLine(it.ExperianceAmount);
}

System.Console.WriteLine("=======Teachers end========");


var cur = new Course();
cur.Id = 12;
cur.Title = "Very Good";
cur.Description = "Beautiful";
cur.Fee = 14;
cur.HasDiscount = true;

var curs = new CourseService();
curs.AddCourses(cur);

foreach (var cu in curs.GetCourses())
{
    System.Console.WriteLine(cu.Id);
    System.Console.WriteLine(cu.Title);
    System.Console.WriteLine(cu.Description);
    System.Console.WriteLine(cu.Fee);
    System.Console.WriteLine(cu.HasDiscount);
}

var coursee = new Course();
{
    coursee.Title = "Very Bad";
    coursee.Fee = 18;
}
System.Console.WriteLine();
System.Console.WriteLine(curs.UpdateCourses(coursee));

foreach (var icors in curs.GetCourses())
{
    System.Console.WriteLine(icors.Title);
    System.Console.WriteLine(icors.Fee);
}
System.Console.WriteLine();
System.Console.WriteLine(curs.Delete(9));
foreach (var icors in curs.GetCourses())
{
    System.Console.WriteLine(icors.Title);
    System.Console.WriteLine(icors.Description);
    System.Console.WriteLine(icors.Fee);
}