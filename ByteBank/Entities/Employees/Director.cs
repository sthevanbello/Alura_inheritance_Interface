using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    class Director : Employee
    {
        public Director(string name, string cpf, double salary) : base(name, cpf, salary)
        {
            Name = name;
            CPF = cpf;
            Salary = salary;
        }

        public override double GetBonification()
        {
            return Salary + base.GetBonification();
        }

        public override void PlusSalary()
        {
            Salary *= 1.15;
        }
    }
}
