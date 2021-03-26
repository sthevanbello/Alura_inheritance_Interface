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

        

        public Employee(string name, string cpf, double salary)
        {
            Name = name;
            CPF = cpf;
            Salary = salary;
            
        }

        public virtual double GetBonification()
        {
            return Salary * 0.1;
        }



    }
}
