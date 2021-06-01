using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FourthCoffee.Employees
{
    class Program
    {
        static void Main(string[] args)
        {

            using var db = new FourthCoffeeEntities();
            //Print a list of employees
            WriteLine("Lista de empleados");
            foreach (FourthCoffee.Employees.Employee e in db.Employees)
            {
                WriteLine($"Nombre:{e.FirstName}, Apellido:{e.LastName}");
            }
            PressKey();
            WriteLine("Modificando empleados");
            Employee emp = db.Employees.FirstOrDefault(e => e.LastName == "Prescott"); //Cambiamos First para evitar el error
            if (emp != null)
            {
                emp.LastName = "Forsyth";
                db.SaveChanges();
            }
            PressKey();
            Write("Lista de empleados usando LINQ");
            IQueryable<Employee> emps = from em in db.Employees select em;
            foreach (var e in emps)
            {
                WriteLine($"Nombre:{e.FirstName}, Apellido:{e.LastName}");
            }
            PressKey();
            IQueryable<Employee> emps1 = from e in db.Employees
                                         where e.LastName == "Forsyth"
                                         select e;
            foreach (var e in emps1)
            {
                WriteLine($"Nombre:{e.FirstName}, Apellido:{e.LastName}");
            }
            PressKey();
            WriteLine("Filtering for two columns");
            new Program().FilteringDataByColumn();
            PressKey();
            WriteLine("Grouping Queries");
            var emps2 = from e in db.Employees
                       group e by e.JobTitle into eGroup
                       select new { Job = eGroup.Key, Names = eGroup };
            foreach (var e in emps2)
            {
                WriteLine($"Job:{e.Job}, Names:{e.Names}");
            }
            PressKey();
            WriteLine("Aggregate Queries");
            var emps3 = from e in db.Employees
                       group e by e.JobTitle into eGroup
                       select new { Job = eGroup.Key, CountOfEmployees = eGroup.Count() };
            foreach (var e in emps3)
            {
                WriteLine($"Job:{e.Job}, Count of Employees:{e.CountOfEmployees}");
            }
            PressKey();
            WriteLine("Using Dot notation to navigate related entities");
            var emps4 = from e in db.Employees
                       select new
                       {
                           FirstName = e.FirstName,
                           LastName = e.LastName,
                           Job =
                      e.JobTitle1.Job
                       };

        }

        private void FilteringDataByColumn()
        {
            using var db = new FourthCoffeeEntities();
            IQueryable<FullName> names = from e in db.Employees
                                         select new FullName
                                         {
                                             Forename = e.FirstName,
                                             Surname = e.LastName
                                         };
            foreach (var emp in names)
            {
                WriteLine($"Nombre:{emp.Forename}, Apellido:{emp.Surname}");
            }
        }

        private class FullName
        {
            public string Forename { get; set; }
            public string Surname { get; set; }
        }


        static void PressKey()
        {
            WriteLine("Press Any Key to Continue...");
            ReadKey();
        }
    }


}
