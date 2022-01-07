using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pessoas_v2
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Estagiario newTrainee = new Estagiario();
            Funcionario newEmployee = new Funcionario();
            FuncionarioNormal newNormalEmployee = new FuncionarioNormal();
            Cliente newClient = new Cliente();

            #region Estagiario
            Console.WriteLine("\n Trainee: \n");
            newTrainee.ReadAge();
            Console.WriteLine($"Contacto: {newTrainee.GetContact(917366433)}");
            Console.WriteLine($"Localidade: {newTrainee.GetLocation("Lisboa")}");
            Console.WriteLine($"Nome Completo: {newTrainee.ReadCompleteName("António", "José", "Milhazes")}");
            Console.WriteLine($"Departamento: {newTrainee.GetDepartment("Secretaria")}");
            Console.WriteLine($"Número de identificação: {newTrainee.GetIdentificationNumber(053215)}");

            Console.ReadKey();
            #endregion 
            #region Funcionario
            Console.WriteLine("\n Employee: \n");
            newEmployee.ReadAge();
            Console.WriteLine($"Contacto: {newEmployee.GetContact(967353436)}");
            Console.WriteLine($"Localidade: {newEmployee.GetLocation("Lisboa")}");
            Console.WriteLine($"Nome Completo: {newEmployee.ReadCompleteName("Maria", "Antonieta", "Coutinho")}");
            Console.WriteLine($"Departamento: {newEmployee.GetDepartment("Recursos Humanos")}");
            Console.WriteLine($"Número de faltas anuais: {newEmployee.UnjustifiedAbsencesPerYear(2)}");
            Console.WriteLine($"Número de horas extras: {newEmployee.OvertimeHoursWorked(43)}H");
            Console.ReadKey();
            #endregion
            #region Funcionario Normal
            Console.WriteLine("\n Employee: \n");
            newNormalEmployee.ReadAge();
            Console.WriteLine($"Contacto: {newNormalEmployee.GetContact(967353436)}");
            Console.WriteLine($"Localidade: {newNormalEmployee.GetLocation("Lisboa")}");
            Console.WriteLine($"Nome Completo: {newNormalEmployee.ReadCompleteName("Maria", "Antonieta", "Coutinho")}");
            Console.WriteLine($"Departamento: {newNormalEmployee.GetDepartment("Recursos Humanos")}");
            Console.WriteLine($"Número de faltas anuais: {newNormalEmployee.UnjustifiedAbsencesPerYear(2)}");
            Console.WriteLine($"Número de horas extras: {newNormalEmployee.OvertimeHoursWorked(43)}H");
            Console.WriteLine($"Função assumida: {newNormalEmployee.GetFunction("Administrativo")}");
            Console.ReadKey();
            #endregion
            #region Cliente
            Console.WriteLine("\n Client: \n");
            newNormalEmployee.ReadAge();
            Console.WriteLine($"Contacto: {newClient.GetContact(966336435)}");
            Console.WriteLine($"Localidade: {newClient.GetLocation("Porto")}");
            Console.WriteLine($"Nome Completo: {newClient.ReadCompleteName("Gonçalo", "Moutinho", "Moreira")}");
            Console.WriteLine($"Departamento: {newClient.GetDepartment("Cliente")}");
            Console.WriteLine($"Numero do contrato: {newClient.GetContractNumber(324568432)}");
            Console.ReadKey();
            #endregion


        }

    }

}
