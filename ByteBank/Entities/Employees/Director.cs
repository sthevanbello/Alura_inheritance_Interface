using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    class Director : Employee
    {
        public Director(string name, string cpf) : base(name, cpf, 5000)
        {
            
        }

        public override double GetBonification()
        {
            return Salary * 0.5;
        }

        public override void PlusSalary()
        {
            Salary *= 1.15;
        }
    }
}
