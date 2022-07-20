using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    public class Employee
    {
        int Empid;
       public string Empname;
        DateTime DOJ;
        float Salary;

       public void Accept()
        {
            Console.WriteLine("Enter Employee id, name, doj,salary");
            Empid = Convert.ToInt32(Console.ReadLine());
            Empname = Console.ReadLine();
            DOJ = Convert.ToDateTime(Console.ReadLine());
            Salary = Convert.ToSingle(Console.ReadLine());
        }

       public void Display()
        {
            Console.WriteLine($"Empid :{Empid}, Name :{Empname}, Doj: {DOJ} and Salary: {Salary}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Accept();
            employee.Display();
            employee.Empname = "Shinde";
            Console.Read();
        }
    }
}
