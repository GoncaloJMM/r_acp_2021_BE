using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Calculadora_Interface
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CalculadoraSimples novaOperacao01 = new CalculadoraSimples();
            CalculadoraCientifica novaOperacao02 = new CalculadoraCientifica();

            Console.WriteLine(novaOperacao01.Somar(10, 20));
            Console.WriteLine(novaOperacao01.Dividir(20, 5));
            Console.WriteLine(novaOperacao01.Multiplicar(10, 10, 1, 10));

            Console.Write("\n\n");

            Console.WriteLine(novaOperacao02.RaizQuadrada(9));
            Console.WriteLine(novaOperacao02.Multiplicar(10, 5));
            Console.WriteLine(novaOperacao02.ValorAbslotulo(-10));
            Console.ReadKey();
        }
    
    }

}
