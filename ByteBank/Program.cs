using ByteBank.Entities;
using ByteBank.Entities.Employees;
using ByteBank.System;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculateBonification();

            UseSystem();

            Console.ReadKey();
        }

        public static void UseSystem()
        {
            InternalSystem internalSystem = new InternalSystem();
            Director roberta = new Director(name: "Roberta", cpf: "159.753.398-04");
            roberta.Password = "1234";
            internalSystem.Login(roberta, "1234");
            
            ManagerOfAccount camila = new ManagerOfAccount(name: "Camila", cpf: "326.985.628-89");
            camila.Password = "abcd";
            internalSystem.Login(camila, "abcd");

            ComercialPartner comercialPartner = new ComercialPartner();
            comercialPartner.Password = "456";
            internalSystem.Login(comercialPartner, "456");
            
        }


        public static void CalculateBonification()
        {
            // You cannot create an abstract class instance
            // Employee employee = new Employee("", "", 500);

            Designer pedro = new Designer(name: "Pedro", cpf: "833.222.048-39");

            Director roberta = new Director(name: "Roberta", cpf: "159.753.398-04");

            Auxiliary igor = new Auxiliary(name: "Igor", cpf: "981.198.778-53");

            ManagerOfAccount camila = new ManagerOfAccount(name: "Camila", cpf: "326.985.628-89");

            Developer guilherme = new Developer(name: "Guilherme", cpf: "228546789-54");

            BonificationManager.Register(pedro);
            BonificationManager.Register(roberta);
            BonificationManager.Register(igor);
            BonificationManager.Register(camila);
            BonificationManager.Register(guilherme);

            Console.WriteLine($"Total of bonification of this month: {BonificationManager.GetTotalBonification()}");
        }
    }
}
