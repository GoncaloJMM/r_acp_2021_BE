using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    //Acess modifiers: public, private
    //Por defeito as classes são publicas
    class Encapsulation
    {
        //Encapsulation
        //propriedades e métodos : public
        //variáveis e fields: private

        #region Variáveis (Publicas à classe, privadas fora da classe)
        int value01 = 0;
        #endregion

        #region Fields (variável privada de suporte à propriedade)
        private string name;
        #endregion

        #region Properties
        //Classic  requer um field privado de suporte
        // SurName = "Gonçalo";        //set
        // Console.WriteLine(SurName); //get
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }

        //Auto-implemented
        public string SurName { get; set; }

        //Bodied-expression(lambda operator => )
        #endregion

        #region Methods
        public void List01()
        {
            Console.WriteLine($"{Name} {SurName}");
        }

        //Por omissão do access modifier, o metodo é private
        // " void List02(){}
        #endregion
    }

}
