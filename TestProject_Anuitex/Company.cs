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

        private List<T> EmployeeBase;
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
        public  bool isExist(T emp)
        {
            ///return instance.EmployeeBase.Any(i => i.Equals(emp)); //alternative variant
            return EmployeeBase.Contains(emp);
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

        public void outputAll()
        {                     
            EmployeeBase.ForEach( x=> Console.WriteLine(x.Name));
        }
    }
}
