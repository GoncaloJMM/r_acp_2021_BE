using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Pessoas_v1
{

    interface IPessoa
    {
        #region Properties
        int Age { get; }
        int Contact { get; }
        string CompleteName { get; }
        string Location { get; }
        string Department { get;  }
        #endregion

        #region Methods
        int ReadAge(int age);
        int GetContact(int contact);
        string ReadCompleteName(string firstName, string midleName, string lastName);
        string GetLocation(string location);
        string GetDepartment(string department);
        #endregion

    }

}
