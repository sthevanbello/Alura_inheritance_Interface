using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Entities.Employees
{
    class Employee
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public double Salary { get; set; }

        // The correct thing would be to use enumeration
        private int _type;

        public Employee(string name, string cpf, double salary, int type)
        {
            Name = name;
            CPF = cpf;
            Salary = salary;
            _type = type;
        }

        public double GetBonification()
        {
            if (_type == 1)
            {
                return Salary;
            }
            return Salary * 0.1;
        }



    }
}
