using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pessoas_v2_1
{
    
    interface IPessoa
    {
        #region Properties
        int Age { get; }
        int Contact { get; }
        string CompleteName { get; }
        string Location { get; }
        string Department { get; }
        #endregion

        #region Methods
        int ReadAge();
        int GetContact();
        string ReadCompleteName();
        string GetLocation();
        string GetDepartment();
        #endregion

    }

}
