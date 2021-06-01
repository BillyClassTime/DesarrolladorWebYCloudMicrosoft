using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using UsingLINQtoEntity.Database;
using UsingLINQtoEntity.Models;
using static System.Console;
namespace UsingLINQtoEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                DbInitializer.Initialize(context);

                var courses = from c in context.Courses select c;

                foreach (var course in courses)
                {
                    WriteLine($"Course: {course.Name}");
                    foreach (var student in course.Students)
                    {
                        WriteLine($"Student name: {student.Name}");
                    }
                }
            }
        }
    }
}
