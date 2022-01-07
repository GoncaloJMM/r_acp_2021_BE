using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoas_v1
{
    class Cliente : IPessoa
    {
        #region Properties
        public int Age { get; set; }
        public int Contact { get; set; }
        public string CompleteName { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
        public int ContractNumber { get; set; }
        #endregion

        #region Methods
        public int ReadAge(int age)
        {
            Age = age;
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
        public int GetContractNumber(int contractNumber)
        {
            ContractNumber = contractNumber;
            return ContractNumber;
        }
        #endregion
    }
}
