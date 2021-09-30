using System;

namespace ConsoleApp5
{
    class Human
    {
        int id;
        protected string firstName;
        protected string secondName;

        public Human(string fName, string sName)
        {
            firstName = fName;
            secondName = sName;
        }
        public void Show()
        {
            Console.WriteLine($" Фамилия: {secondName} " +
                $" Имя: {firstName} ");
        }
    }
    class Employee : Human
    {
        protected double salary;
        public Employee(string fName, string sName, double sal) : base(fName, sName)
        {

            salary = sal;
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine($" Зарплата: {salary} ");
        }
    }
    class Scientist : Employee
    {
        string discipline;
        public Scientist(string fName, string sName, double sal, string discipline) : base(fName, sName, sal)
        {
            this.discipline = discipline;
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine($" Дисциплина: {discipline}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan", "Ivanov", 2365.5);
            employee.Show();
            Scientist sc = new Scientist("Petr", "Petrov", 544221, "Math");
            sc.Show();

        }
    }
}
