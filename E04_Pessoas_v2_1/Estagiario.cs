using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pessoas_v2_1
{
    
    class Estagiario : Funcionario
    {
        #region Properties
        public int IdentificationNumber { get; set; }
        #endregion

        #region Methods
        public int GetIdentificationNumber()
        {
            Console.Write("Insira o seu número de Identificação: ");
            IdentificationNumber = Convert.ToInt32(Console.ReadLine());
            return IdentificationNumber;
        }
        #endregion
    }

}
