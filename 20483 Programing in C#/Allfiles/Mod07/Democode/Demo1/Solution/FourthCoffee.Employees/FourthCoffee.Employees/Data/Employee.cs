using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace FourthCoffee.Employees
{
    public partial class Employee
    {
        public int GetAge()
        {
            DateTime DOB = (DateTime)DateOfBirth;
            TimeSpan difference = DateTime.Now.Subtract(DOB);
            int ageInYears = (int)(difference.Days / 365.25);
            return ageInYears;
        }

        
    }
}
