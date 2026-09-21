using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Inheritance
{
    class Person
    {
        public string Name;
        public int age;
    }

    class Employee :Person
    {
        public int EmpId;
        public string Role;
        public double salary;

        public void DisplayEmpDetails()
        {
            Console.WriteLine("Employee Id: " + EmpId);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee Salary: " + salary);
            Console.WriteLine("Employee Role: " + Role);
            Console.WriteLine("Emp Age: " + age);
        }

    }

    class Manager : Employee
    {

        public void DisplayDetails()
        {
            Console.WriteLine("Employee Id: "+ EmpId);
            Console.WriteLine("Employee Name: "+ Name);
            Console.WriteLine("Employee Salary: "+ salary);
            Console.WriteLine("Employee Role: "+ Role);
            Console.WriteLine("Emp Age: "+ age);
        }
    }
    internal class MultilevelDemo
    {

        static void Main()
        {
            Manager emp = new Manager();

            emp.Name = "Raj";
            emp.salary = 30000;
            emp.Role = "Developer";

            emp.DisplayDetails();

            Console.WriteLine();

            Employee emp2 = new Employee();

            emp2.DisplayEmpDetails();
        }
    }
}
