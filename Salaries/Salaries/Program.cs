using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salaries
{
    class Employee
    {
        public string _f_name { get; }
        public string _l_name { get; }
        private double _salary;

        public Employee()
        {
            _f_name = "John";
            _l_name = "Smith";
            _salary = 500.00;
        }

        public Employee(string f, string l, double s)
        {
            _f_name = f;
            _l_name = l;
            _salary = s;
        }
        
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    value = 0.00;
                }
                else
                {
                    _salary = value;
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Bob", "Jones", 2875);
            Employee e2 = new Employee("Susan", "Baker", 3150.75);

            Console.WriteLine(
                $"Employee 1: {e1._f_name} {e1._l_name}; Yearly Salary: {String.Format("{0:0.00}", e1.Salary * 12)}"
                );
            Console.WriteLine(
                $"Employee 2: {e2._f_name} {e2._l_name}; Yearly Salary: {String.Format("{0:0.00}", e2.Salary * 12)}"
                );

            e1.Salary *= 1.1;
            e2.Salary *= 1.1;
            Console.WriteLine();

            Console.WriteLine(
                $"Employee 1: {e1._f_name} {e1._l_name}; Yearly Salary: {String.Format("{0:0.00}", e1.Salary * 12)}"
                );
            Console.WriteLine(
                $"Employee 2: {e2._f_name} {e2._l_name}; Yearly Salary: {String.Format("{0:0.00}", e2.Salary * 12)}"
                );
            Console.ReadKey();
        }
    }
}
