using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculadora_Abstract
{
    
    class CalculadoraSimples : Calculadora
    {
        //public double resultado;
        #region Properties
        public override double Valor1 { get; set; }
        public override double Valor2 { get; set; }
        public double Valor3 { get; set; }
        public double Valor4 { get; set; }
        public override double Resultado { get; set; }
        //public override string Operador { get; set; }
        #endregion

        #region Methods
        /*public override void EscreverOperacoesPossiveis()
        {
            Console.Write("Operações:\n");
            //Console.Write("\n[+]\n[-]\n[*]\n[/]\n\n");
            string[] mostrarOperacoes = new string[]
            {
                "[+]",
                "[-]",
                "[*]",
                "[/]"
            };
            foreach (string escreverOps in mostrarOperacoes)
            {
                Console.WriteLine(escreverOps);
            }
        }
        public override void LerValor1()
        {
            Console.Write("Valor 1: ");
            Valor1 = Double.Parse(Console.ReadLine());
        }
        public override void LerValor2()
        {
            Console.Write("Valor 2: ");
            Valor2 = Double.Parse(Console.ReadLine());
        } 
        public void LerValor3()
        {
            Console.Write("Valor 3: ");
            Valor3 = Double.Parse(Console.ReadLine());
        }
        public override void LerOperador()
        {
            Console.Write("Operação: ");
            Operador = Console.ReadLine();
        }
        public override bool TestarOperador()
        {
            var validado = false;

            switch (Operador)
            {
                case "+":
                    validado = true;
                    break;
                case "-":
                    validado = true;
                    break;
                case "*":
                    validado = true;
                    break;
                case "/":
                    validado = true;
                    break;
                default:
                    validado = false;
                    Console.Write("Erro");
                    break;
            }
            return validado;
        }
        public override void UsarOperador()
        {
            switch (Operador)
            {
                case "+":
                    Soma(Valor1, Valor2);
                    break;
                case "-":
                    Subtracao(Valor1, Valor2);
                    break;
                case "*": 
                    Multiplicacao(Valor1, Valor2);
                    break;
                case "/":
                    Divisao(Valor1, Valor2);
                    break;
            }
        }*/
        public override double Soma(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 + v2;
            return Resultado;
        }
        public double Soma(double v1, double v2, double v3)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor2 = v3;
            Resultado = v1 + v2 + v3;
            return Resultado;
        }
        public double Multiplicacao(double v1, double v2, double v3, double v4)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor3 = v3;
            Valor4 = v4;
            Resultado = v1 * v2 * v3 * v4;
            return Resultado;
        }
        public double Multiplicacao(double v1, double v2, double v3)
        {
            Valor1 = v1;
            Valor2 = v2;
            Valor3 = v3;
            Resultado = v1 * v2 * v3 ;
            return Resultado;
        }
        public override double Multiplicacao(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 * v2;
            return Resultado;
        }
        public override double Subtracao(double v1, double v2)
        {
            Valor1 = v1;
            Valor2 = v2;
            Resultado = v1 - v2;
            return Resultado;
        }
        public override double Divisao(double v1, double v2)
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
        /*public override void EscreverResultado()
        {
            Console.Write($"\n\nResultado: {Resultado}");
        }*/

        #endregion
    }

}
