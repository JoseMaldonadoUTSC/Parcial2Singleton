using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    /// <summary>

    /// The 'ObjectStructure' class

    /// </summary>

    class Employees

    {
        private List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in _employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }

    // Three employee types


    class Clerk : Employee

    {
        // Constructor

        public Clerk()
          : base("Hank", 25000.0, 14)
        {
        }
    }

    class Director : Employee

    {
        // Constructor

        public Director()
          : base("Elly", 35000.0, 16)
        {
        }
    }

    class President : Employee

    {
        // Constructor

        public President()
          : base("Dick", 45000.0, 21)
        {
        }
    }
}
