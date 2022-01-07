using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Calculadora_Interface
{

    class CalculadoraCientifica : ICalculadora
    {
        
        #region Properties
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Resultado { get; set; }
        #endregion

        #region Methods
        public double Dividir(double v1, double v2)
        {
            if (Valor2 == 0)
            {
                Resultado = 0;
                return Resultado;
            }
            else
            {
                Valor1 = v1;
                Valor2 = v2;
                Resultado = v1 / v2;
                return Resultado;
            }
        }
        public double Multiplicar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 * v2;
            return Resultado;
        }
        public double Somar(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 + v2;
            return Resultado;
        }
        public double RaizQuadrada(double v1)
        {
            Valor1 = v1;
            Resultado = Math.Sqrt(Valor1);
            return Resultado;
        }
        public double ValorAbslotulo(double v1)
        {
            Valor1 = v1;
            Resultado = Math.Abs(Valor1);
            return Resultado; 
        }
        public double Subtrair(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 - v2;
            return Resultado;
        }
        #endregion
        
    }

}
