using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    class Employee
    {
        public string name;
     
       
        public void LogIn()
        {
            Console.WriteLine($"Employee {name} LogedIn to his System");
        }
    }
    
    class Manger : Employee
    {
  
        public void Work()
        {
            Console.WriteLine($"{name} is working as Manager Position");
        }
    }

    class HR : Employee
    {
        public void ManagerTask()
        {
            Console.WriteLine($" Manager {name}and working as the company");
        }
    }

    class Developer : Employee
    {
        public void Work()
        {
            Console.WriteLine("Developer is creating modules for the project");
        }
    }

    internal class Casting
    {
        static void Main()
        {
            //upcasting

            //Employee obj;

            //obj = new Manger();

            //obj.name = "Saran";

            //obj.LogIn();

            //obj.role = "Manager";

            //obj.Work();

            //obj = new HR();

            Manger Managerobj = new Manger();

            Managerobj.name = "Madhan";

            Employee emp = Managerobj;


            emp.LogIn();

            Managerobj.Work();

            Console.WriteLine();

            //DownCasting 

            Employee employee = new Manger();

            Manger manage = (Manger)employee;

            manage.name = "Hari";

            manage.Work();

            if(employee is Developer)
            {
                Developer dev = (Developer)employee;

                dev.Work();
            }
            else
            {
                Console.WriteLine("can't be downcast to developer");
            }


            Developer dev1 = null;

            Console.WriteLine(dev1.name);
        }
    }
}
