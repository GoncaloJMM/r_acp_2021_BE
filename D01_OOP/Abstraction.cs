using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    // Uma classe abstrata:
    //      não pode ser instanciada
    //      tem de ser herdada para se poder trabalhar com ela
    //      pode ter membros abstratos e não abstratos
    //      todos os membros abstratos têm de ser implementados
    abstract class AbstractAnimal
    {
        #region Properties
        public abstract string Name { get; set; }
        public string Color { get; set; }
        public abstract bool Pet { get; set; }
        #endregion

        #region Methods
        // Um método abstrato não pode ser implementado na clasee abstrata
        // Tem de ser implementado na classe derivada com override e com a mesma assinatura
        public void Register()
        {
            Console.WriteLine($"\nA registar o animal.\n");
        }

        public abstract void List(string name);
        public abstract void Domesticate();
        #endregion
    }
    
    class Vertebrate : AbstractAnimal
    {
        #region Constants
        public const string TYPE = "Vertebrate";
        #endregion
 
        #region Properties
        public override string Name { get; set; }

        public override bool Pet { get; set; }
        #endregion
        
        #region Methods

        public override void Domesticate()
        {
            Pet = true;
        }

        public override void List(string name)
        {
            Name = name;

            Console.WriteLine($"Animal: {Name} ({TYPE})");
        }
        #endregion

       


    }

    class Invertebrate : AbstractAnimal
    {
        #region Constants
        public const string TYPE = "Invertebrate";
        #endregion

        #region Properties
        public override string Name { get; set; }

        public override bool Pet { get; set; }
        #endregion

        #region Methods

        public override void Domesticate()
        {
            Pet = true;
        }

        public override void List(string name)
        {
            Name = name;

            Console.WriteLine($"Animal: {Name} ({TYPE})");
        }
        #endregion
    }

}
