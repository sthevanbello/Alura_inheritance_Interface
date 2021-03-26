using ByteBank.Entities;
using ByteBank.Entities.Employees;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee(name: "Carlos", cpf: "229.845.028-14", salary: 2000);
            Director director1 = new Director(name: "Roberta", cpf: "254.658.148-03", salary: 5000);

            BonificationManager bonificationManager = new BonificationManager();

            bonificationManager.Register(employee1);
            bonificationManager.Register(director1);

            Console.WriteLine($"Employee: {employee1.Name}");
            Console.WriteLine($"Bonification: {employee1.GetBonification()}");

            Console.WriteLine($"Director: {director1.Name}");
            Console.WriteLine($"Bonification: {director1.GetBonification()}");

            Console.WriteLine($"Total of bonification: {bonificationManager.GetTotalBonification()}");

            Console.ReadKey();
        }
    }
}
