using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_EF6_FirstDemo
{

    class Program
    {

        static void Main(string[] args)
        {
            //Usar a ConnectionString
            using (var db = new GestaoFormacaoDBEntities())     //Classe que herda o DbContext
            {

                #region AreaCurso
                #region Steps
                //1. Instanciamos a classe
                //2. Preenchemos as propriedades
                //3. Adicionamos o objeto ao dbset (que representa a tabela da base de dados em memória)
                //4. Fazer o SaveChange para gravar as alterações

                #endregion

                AreaCurso areaCurso = new AreaCurso();

                areaCurso.Area = "Soft Skills";
                db.AreaCurso.Add(areaCurso);
                db.SaveChanges();
                areaCurso.Area = "Artes";
                db.AreaCurso.Add(areaCurso);
                db.SaveChanges();

                #endregion

                #region SubareaCurso

                #endregion

                #region Curso

                #endregion
                Console.ReadKey();
            }


        }

    }

}
