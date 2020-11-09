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
            Worker worker2 = new Worker() { Name = "worker2", Expirience = 2 };
            Manager manager = new Manager() { Name = "manager", Expirience = 3 };
            Manager manager2 = new Manager() { Name = "manager2", Expirience = 4 };
            Employee employee = new Employee() { Name = "employee", Expirience = 5 };
            Employee employee2 = new Employee() { Name = "employee2", Expirience = 6 };
            Brigadier brigadier = new Brigadier() { Name = "brigadier", Expirience = 7 };
            Brigadier brigadier2 = new Brigadier() { Name = "brigadier2", Expirience = 8 };

            worker.Work();
            manager.Work();
            brigadier.Work();
            employee.Work();
            manager.ToGiveATask();
            brigadier.WorkersCheck();

            Console.WriteLine();

            instance += worker;
            instance += worker2;
            instance += manager;
            instance += employee;
            instance += brigadier;
            instance += brigadier2;

            Console.WriteLine(instance.amountEmployeesOfType(worker).ToString());

            if (instance.isExist(worker))
                Console.WriteLine("really еxist!");
            else
                Console.WriteLine("doesn`t еxist(");

            instance -= worker;
            
            if (instance.isExist(worker))
                Console.WriteLine("really Exist!");
            else
                Console.WriteLine("doesn`t Exist(");
            Console.WriteLine(instance.amountEmployeesOfType(worker).ToString());

            Console.WriteLine();

            var Brigadiers = instance.getBrigadiers();

            foreach (var i in Brigadiers)
                Console.WriteLine(i.Name);


            Console.WriteLine();

            instance.outputAll();       

            Console.ReadLine();
        }
    }
}
