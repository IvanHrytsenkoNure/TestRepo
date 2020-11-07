using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Anuitex
{

    class Employee 
    {
        
        public string Name { get; set; }
        public int Expirience { get; set; }

        public virtual void Work()
        {
            Console.WriteLine("Base employee work");
        }

    }
    class Worker : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Production release");
        }
    }

    class Manager : Employee
    {

        public override void Work()
        {
            Console.WriteLine("Collecting orders");
        }
        public void ToGiveATask()
        {
            Console.WriteLine("The task has been given");
        }
    }
    class Brigadier : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Purchase of materials");
        }
        public void WorkersCheck()
        {
            Console.WriteLine("Personnel check in progress");
        }
    }

}
