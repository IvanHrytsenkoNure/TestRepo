using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Anuitex
{
    class Program
    {
        static void Main(string[] args)
        {
            Company<Employee> instance = Company<Employee>.getInstance();
            Worker worker = new Worker() { Name = "worker", Expirience = 1 };
            Manager manager = new Manager() { Name = "manager", Expirience = 2 };
            Employee employee = new Employee() { Name = "employee", Expirience = 3 };
            Worker worker2 = new Worker() { Name = "worker2", Expirience = 1 };
            worker.Work();
            manager.Work();
            employee.Work();

            instance = instance + worker;
            instance = instance + worker2;
            instance = instance + manager;
            instance = instance + employee;

            if (instance.isExist(worker))
                Console.WriteLine("really Exist !");
            else
                Console.WriteLine("doesn`t Exist(");

            var Names = instance.EmployeeBase.Select(x => x.Name);

            var Workers = instance.getWorkers();

            foreach (var i in Workers)
                Console.WriteLine(i.Name);

            Console.ReadLine();
        }
    }
}
