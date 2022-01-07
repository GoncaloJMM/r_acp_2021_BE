using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Calculadora_Interface
{

    interface ICalculadora
    {
        #region Properties
        double Valor1 { get; }
        double Valor2 { get; }
        double Resultado { get; }
        #endregion

        #region Methods
        double Somar(double v1, double v2);
        double Subtrair(double v1, double v2);
        double Dividir(double v1, double v2);
        double Multiplicar(double v1, double v2);
        #endregion

    }

}
