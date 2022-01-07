using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pessoas_v2_1
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
            newTrainee.GetContact();
            newTrainee.GetLocation();
            newTrainee.ReadCompleteName();
            newTrainee.GetDepartment();
            newTrainee.GetIdentificationNumber();
            Console.ReadKey();
            Console.Clear();
            #endregion 
            #region Funcionario
            Console.WriteLine("\n Employee: \n");
            newEmployee.ReadAge();
            newEmployee.GetContact();
            newEmployee.GetLocation();
            newEmployee.ReadCompleteName();
            newEmployee.GetDepartment();
            Console.WriteLine($"Número de faltas anuais: {newEmployee.UnjustifiedAbsencesPerYear(2)}");
            Console.WriteLine($"Número de horas extras: {newEmployee.OvertimeHoursWorked(43)}H");
            Console.ReadKey();
            Console.Clear();
            #endregion 
            #region Funcionario Normal
            Console.WriteLine("\n Employee: \n");
            newNormalEmployee.ReadAge();
            newNormalEmployee.GetContact();
            newNormalEmployee.GetLocation();
            newNormalEmployee.ReadCompleteName();
            newNormalEmployee.GetDepartment();
            Console.WriteLine($"Número de faltas anuais: {newNormalEmployee.UnjustifiedAbsencesPerYear(2)}");
            Console.WriteLine($"Número de horas extras: {newNormalEmployee.OvertimeHoursWorked(43)}H");
            Console.WriteLine($"Função assumida: {newNormalEmployee.GetFunction("Administrativo")}");
            Console.ReadKey();
            Console.Clear();
            #endregion
            #region Cliente
            Console.WriteLine("\n Client: \n");
            newNormalEmployee.ReadAge();
            newClient.GetContact();
            newClient.GetLocation();
            newClient.ReadCompleteName();
            newClient.GetDepartment();
            newClient.GetContractNumber();
            Console.ReadKey();
            Console.Clear();
            #endregion

        }

    }

}
