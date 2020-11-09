using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Anuitex
{
    static class CompanyExtensions
    {
        public static bool isExist(this Company<Employee> e, Employee emp)
        {
            ///return instance.EmployeeBase.Any(i => i.Equals(emp)); //alternative variant
            return Company<Employee>.getInstance().EmployeeBase.Contains(emp);   
            
        }
        public static void outputAll(this Company<Employee> e)
        {
             Company<Employee>.getInstance().EmployeeBase.ForEach(x => Console.WriteLine(x.Name));
        }
    }
}
 