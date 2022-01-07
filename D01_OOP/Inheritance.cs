using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D01_OOP
{
    
    class Inheritance
    {
        #region Properties
        public string Name { get; set; }

        #endregion

        #region Methods
        public void ListName()
        {
            Console.WriteLine($"Name: {Name}");

        }

        #endregion
    }

    class InheritanceChild : Inheritance
    {
        #region Properties
        public string SurName { get; set; }

        #endregion

        #region Methods
        public void ListSurName()
        {
            Console.WriteLine($"Name: {SurName}");
        }
        #endregion
    }

    class Person
    {
        #region Properties
        public string FullName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        #endregion

        #region Constructors
        public Person()
        {
            Name = "";
            SurName = "";
            FullName = "";
        }
        public Person(string name, string surName)
        {
           Name = name;
           SurName = surName;
           FullName = $"{Name} {SurName}";
        }
        #endregion

        #region Methods
        public void ListFullName()
        {
            Console.WriteLine($"FullName: {FullName}");
        } 
        #endregion
    }

    class Student : Person
    {
        #region Properties
        public string Course { get; set; }
        public string Location { get; set; }
        #endregion

        #region Constructors
        public Student() : base()     //mapear este construtor para o da base classe(person)
        {

        }

        public Student(string name, string surname) : base(name, surname)           // Mapear este construtor para o 2 da base classe
        {

        }
        //Este é o novo construtor da própria classe
        public Student(string name, string surname, string course, string location)
        {
            Name = name;
            SurName = surname;
            FullName = $"{Name} {SurName}";
            Course = course;
            Location = location;
        }
                                  
        
        #endregion

        #region Methods
        public void ListAll()
        {
            Console.WriteLine($"O formando: {FullName} que mora em {Location} está no curso: {Course}");
            Console.WriteLine($"O formando: {Name} {SurName} que mora em {Location} está no curso: {Course}");
        }
        #endregion
    }

    class TestPersonStudent
    {
        #region CallMethods
        
        #endregion

        #region MyRegion

        #endregion

    }
}
