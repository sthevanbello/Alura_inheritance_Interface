using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    class ManagerOfAccount : Employee
    {
        public ManagerOfAccount(string name, string cpf) : base(name, cpf, 4000)
        {
            Name = name;
            CPF = cpf;
        }
        public override double GetBonification()
        {
            return Salary * 0.25;
        }

        public override void PlusSalary()
        {
            Salary *= 1.05;
        }
    }
}
