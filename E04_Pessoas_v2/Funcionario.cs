﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pessoas_v2
{
    
    class Funcionario : IPessoa
    {
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
        public int GetContact(int contact)
        {
            Contact = contact;
            return Contact;
        }
        public string GetLocation(string location)
        {
            Location = location;
            return Location;
        }
        public string ReadCompleteName(string firstName, string midleName, string lastName)
        {

            CompleteName = $"{firstName} {midleName} {lastName}";
            return CompleteName;
        }
        public string GetDepartment(string department)
        {
            Department = department;
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
