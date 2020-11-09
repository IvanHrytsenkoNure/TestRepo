using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Anuitex
{
    class Company<T> where T : Employee 
    {
        private static Company<T> instance;

        public List<T> EmployeeBase { get; private set; }

        private Company()
        {}        
        public static Company<T> getInstance()
        {
            if (instance == null)
            {
                instance = new Company<T>
                {
                    EmployeeBase = new List<T> { }
                };                
            }
            return instance;
        }     

        public static Company<T> operator + (Company<T> inst , T emp)
        {
            inst.EmployeeBase.Add(emp);
            return getInstance();
        }
        public static Company<T> operator - (Company<T> inst, T emp)
        {
            inst.EmployeeBase.Remove(emp);
            return getInstance();
        }
                
        public int amountEmployeesOfType(T emp)
        {
            return EmployeeBase.Where(i =>i .GetType().Equals(emp.GetType())).Count();
        }

        public IEnumerable<T> getWorkers()
        {              
            return EmployeeBase.Where(i => i.GetType().Equals(typeof(Worker)));
        }
        public IEnumerable<T> getBrigadiers()
        {
            return EmployeeBase.Where(i => i.GetType().Equals(typeof(Brigadier)));
        }
        public IEnumerable<T> getManagers()
        {
            return EmployeeBase.Where(i => i.GetType().Equals(typeof(Manager)));
        }
       
    }
}
