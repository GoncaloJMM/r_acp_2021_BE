using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Calculadora_Abstract
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                CalculadoraSimples novaOperacao01 = new CalculadoraSimples();
                CalculadoraCientifica novaOperacao02 = new CalculadoraCientifica();



                Console.WriteLine(novaOperacao01.Multiplicacao(10, 1, 10, 10));
                Console.WriteLine(novaOperacao02.ValorAbsoluto(-10));
                
                
                #region v2
                /*novaOperacao01.EscreverOperacoesPossiveis();
                                novaOperacao01.LerValor1();
                                novaOperacao01.LerValor2();
                                novaOperacao01.LerOperador();


                                if (novaOperacao01.TestarOperador())
                                {
                                    novaOperacao01.UsarOperador();
                                    novaOperacao01.EscreverResultado();
                                }
                                else
                                {
                                    Console.WriteLine("Não foi posssivel realizar a operação");
                                }*/
                #endregion
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Atenção ao Argumento");
            }

            Console.ReadKey();


        }

    }

}
