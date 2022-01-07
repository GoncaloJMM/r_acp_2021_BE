using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_Pessoas_v2_1
{
    
    class FuncionarioNormal : Funcionario
    {
        #region Properties
        public string Function { get; set; }
        #endregion

        #region Methods
        public string GetFunction(string funcion)
        {
            Function = funcion;
            return Function;
        }
        #endregion

    }

}
