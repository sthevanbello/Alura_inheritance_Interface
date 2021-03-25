using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    class Director
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Salary { get; set; }


        public Director(string name, string cpf, double salary)
        {
            Name = name;
            CPF = cpf;
            Salary = salary;

        }

        public double GetBonification()
        {
            return Salary;
        }
    }
}
