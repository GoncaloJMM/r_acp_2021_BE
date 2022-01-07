using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pessoas_v2_1
{
    
    class Funcionario : IPessoa
    {
        #region Var
        string firstName;
        string midleName;
        string lastName;
        #endregion
        
        #region Properties
        public int Age { get; set; }
        public int Contact { get; set; }
        public string CompleteName { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public int UnjustifiedAbsences { get; set; }
        public int OvertimeHours { get; set; }
        #endregion
        
        #region Methods
        public int ReadAge()
        {
            Console.Write("Escreva a sua idade: ");
            Age = Convert.ToInt32(Console.ReadLine());
            return Age;
        }
        public int GetContact()
        {
            Console.Write("Insira o contacto: ");
            Contact = Convert.ToInt32(Console.ReadLine());
            return Contact;
        }
        public string GetLocation()
        {
            Console.Write("Insira a localidade: ");
            Location = Console.ReadLine();
            return Location;
        }
        public string ReadCompleteName()
        {
            Console.Write("Insira o seu primeiro nome: ");
            var firstName = Console.ReadLine();
            Console.Write("Insira o seu nome do meio: ");
            var midleName = Console.ReadLine();
            Console.Write("Insira o seu último nome: ");
            var lastName = Console.ReadLine();
            CompleteName = $"{firstName} {midleName} {lastName}";
            return CompleteName;
        }
        public string GetDepartment()
        {
            Console.Write("Insira o seu departamento: ");
            Department = Console.ReadLine();
            return Department;
        }
        public int UnjustifiedAbsencesPerYear(int unjustifiedabsences)
        {
            UnjustifiedAbsences = unjustifiedabsences;
            return UnjustifiedAbsences;
        }
        public int OvertimeHoursWorked(int overtimehours)
        {
            OvertimeHours = overtimehours;
            return OvertimeHours;
        }
        #endregion

    }

}
