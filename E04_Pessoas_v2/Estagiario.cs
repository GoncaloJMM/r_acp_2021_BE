using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pessoas_v2
{
    
    class Estagiario : Funcionario
    {
        #region Properties
        public int IdentificationNumber { get; set; }
        #endregion

        #region Methods
        public int GetIdentificationNumber(int identificationNumber)
        {
            IdentificationNumber = identificationNumber;
            return IdentificationNumber;
        }
        #endregion
    }

}
