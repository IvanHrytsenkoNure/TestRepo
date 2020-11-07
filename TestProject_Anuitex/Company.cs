using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Anuitex
{
    class Company<Employee>
    {
        private static Company<Employee> instance;
        private Company()
        {}
        public static Company<Employee> getInstance()
        {
            if (instance == null)
            {
                instance = new Company<Employee>
                {
                    EmployeeBase = new List<Employee> { }
                };
            }
            return instance;
        }

        public  List<Employee> EmployeeBase;

        public static Company<Employee> operator + (Company<Employee> inst , Employee emp)
        {
            inst.EmployeeBase.Add(emp);
            return getInstance();
        }
        public static Company<Employee> operator - (Company<Employee> inst, Employee emp)
        {
            inst.EmployeeBase.Remove(emp);
            return getInstance();
        }
        public  bool isExist(Employee emp)
        {
            ///return instance.EmployeeBase.Any(i => i.Equals(emp)); //alternative variant
            return instance.EmployeeBase.Contains(emp);
        }
        
        public int employeesAmount()
        {
            return instance.EmployeeBase.Count();
        }

        public List<Worker> getWorkers()
        {
            var workers = instance.EmployeeBase.OfType<Worker>();
            return workers.ToList();
        }
        public List<Brigadier> getBrigadiers()
        {
            var workers = instance.EmployeeBase.OfType<Brigadier>();
            return workers.ToList();
        }
        public List<Manager> getManagers()
        {
            var workers = instance.EmployeeBase.OfType<Manager>();
            return workers.ToList();
        }


        /*public void outrutEmps() 
        {
            Company<Employee> inst = getInstance();
            
        }*/

    }
}
