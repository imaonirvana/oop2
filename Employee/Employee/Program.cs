using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public enum Position
    {
        Cleaner ,
        Trainee,
        Junior,
        Middle,
        Senior,
        TeamLead,
        Manager
    }

    public class Employee
    {
        private string firstname;
        private string secondname;
        private double workPeriod;
        private Position position;
        private const int baseSalary = 5050;

        public Employee(string firstname, string secondname, double workPeriod, Position position)
        {
            Name = firstname;
            Surname = secondname;
            this.workPeriod = workPeriod;
            this.position = position;
        }

        public string Name { get => firstname; set => firstname = value; }
        public string Surname { get => secondname; set => secondname = value; }

        public double Salary => baseSalary * (int)position * (workPeriod / 1.5 + 1);
        public double Tax => baseSalary * (int)position * 0.2;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Nathan", "Meuwe", 3.5, Position.Middle);
            Console.WriteLine($"Salary: {employee.Salary, 0:0.00}");
            Console.WriteLine($"Tax: {employee.Tax}");
        }
    }
}