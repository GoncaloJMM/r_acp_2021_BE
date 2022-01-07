using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    
    class Polimorphism
    {
        #region Properties
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Location { get; set; }
        #endregion

        #region Methods
        //Overloading de métodos
        // Method overload == sobrecarga de métodos --> mesmo método com assinaturas diferentes
        
        public void ListFullName()
        {
            Console.WriteLine($"Full Name: {Name} {SurName}");
        }
        public void ListFullName(string name, string surname)
        {
            Name = name;
            SurName = surname;
            Console.WriteLine($"Full Name: {Name} {SurName}");
        }
        public void ListFullNameUS(string surname, string name)
        {
            Name = name;
            SurName = surname;
            Console.WriteLine($"Full Name: {SurName} {Name}");
        }
        //Marcar o método para overriding com virtual
        public virtual void ListAll(string name, string surname, string location)
        {
            Name = name;
            SurName = surname;
            Location = location;
            Console.WriteLine($"{Name} {SurName} mora em {Location}.");
        }
        #endregion
    }

    class PolimorphismChild : Polimorphism
    {
        //Overriding de métodos
        //Method override == sobrescrita de métodos --> métodos com a mesma assinatura, mas diferentes implementações
        #region Methods
        //Marcar o método para overriding com override( classe derivada
        public override void ListAll(string name, string surname, string location)
        {
            Name = name;
            SurName = surname;
            Location = location;
            Console.WriteLine($"{SurName}, {Name} lives in {Location}.");
        }
        #endregion
    }
}
