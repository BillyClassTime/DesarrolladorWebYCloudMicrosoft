using System;
using System.Linq;
using CRUD.Database;
using CRUD.Models;
using static System.Console;
namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Initializing the database and populating seed data
                DbInitializer.Initialize(context);

                // CREATE
                Student firstStudent = new Student() {Name = "Thomas Anderson"};
                Student secondStudent = new Student() {Name ="Terry Adams"};
                
                // READ
                Course ASPCourse = (from course in context.Courses where course.Name == "ASP.NET Core" select course).Single();
                ASPCourse.Students.Add(firstStudent);       // REalizando el CREATE
                ASPCourse.Students.Add(secondStudent); 
                
                // UPDATE
                WriteLine($"Salario del profe:{ASPCourse.CourseTeacher.Salary}");
                ASPCourse.CourseTeacher.Salary += 10000;     //NO SOLO AL DE ASP.NET

                // DELETE 
                Student studentToRemove = ASPCourse.Students.FirstOrDefault((student) => student.Name == "Student_1");
                ASPCourse.Students.Remove(studentToRemove);

                context.SaveChanges();
                WriteLine(ASPCourse);
                ReadLine();
               
            }
        }
    }
}
