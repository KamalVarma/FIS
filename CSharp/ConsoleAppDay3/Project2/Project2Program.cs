using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDay3;

namespace Project2
{
    class Project2Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Empname = "Mohit";
            Console.WriteLine(emp.Empname);
            emp.Accept();
            emp.Display();
            Console.Read();
        }
    }
}
