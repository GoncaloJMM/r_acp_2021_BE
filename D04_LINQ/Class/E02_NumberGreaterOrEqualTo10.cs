using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_LINQ
{
    
    class NumberGreaterOrEqualTo10
    {
        #region Constructor
        public NumberGreaterOrEqualTo10()
        {
            // Declarar uma lista generica de inteiros
            List<int> randomList = new List<int>();
            // Chamar o metodo para criar a lista enviando a lista vazia
            CreateList(randomList);
            //Chamar o metodo para filtrar e listar, enviando a lista já preenchida
            FilterAndShowListMethodSyntax(randomList);
            FilterAndShowListQuerySyntax(randomList);
        }
        
        #endregion

        #region Create random numeric List
        public void CreateList(List<int> randomList)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)  // 10 VEZES
            {
                int random = rnd.Next(1, 50); // N aleatórios entre 1 e 50
                randomList.Add(random);
                
            }


        }
        #endregion

        #region Filter and show the random List (method syntax)
        public void FilterAndShowListMethodSyntax(List<int> randomList)
        {
            var numbers = randomList.Where(n => n >= 10).OrderBy(n => n);

            Console.WriteLine("Method Syntax\n");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        #endregion

        #region Filter and show the random List (query syntax)
        public void FilterAndShowListQuerySyntax(List<int> randomList)
        {
            //var numbers = randomList.Where(n => n >= 10).OrderBy(n => n);
            var numbers =
                from n in randomList
                where n >= 10
                orderby n
                select n;

            Console.WriteLine("Query Syntax\n");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        #endregion


    }

}
