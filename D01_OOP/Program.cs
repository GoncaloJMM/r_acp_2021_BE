using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            #region Inheritance

            #region Create Objects
            /*
            Person person01 = new Person();
            Person person02 = new Person("Gonçalo", "Moreira");
            Student stundent01 = new Student();
            Student stundent02 = new Student("A", "B");
            Student stundent03 = new Student("Gonçalo", "Moreira", "IT", "Melres"); 
            #endregion

            #region Call Methods
            person02.ListFullName();
            stundent03.ListAll();
            stundent03.ListAll();*/
            #endregion


            #endregion

            #region Encapsulation
            /*Encapsulation encapsulation01 = new Encapsulation();
            encapsulation01.Name = "Moreira";
            encapsulation01.SurName = "Moutinho";*/
            #endregion

            #region Polimophism
            Polimorphism baseClass = new Polimorphism();
            PolimorphismChild derivedClass01 = new PolimorphismChild();

            baseClass.ListFullName();
            baseClass.ListFullName("Gonçalo", "Moreira");
            baseClass.ListFullNameUS("Moreira", "Gonçalo");
            baseClass.ListAll("Gonçalo", "Moreira", "Melres");

            derivedClass01.ListAll("Gonçalo", "Moreira", "Melres");
            #endregion

            #region Abstration
            Vertebrate animal01 = new Vertebrate();
            Invertebrate animal02 = new Invertebrate();

            animal01.Register();
            animal01.List("Gato");

            animal02.Register();
            animal02.List("Polvo");
            
            #endregion


            Console.ReadKey();
        }
        
    }

}
