using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            User newUser01 = new User("Gonçalo", "pass12321");
            User newUser02 = new User("Mal", "false");

            newUser01.Validate(newUser01.UserName, newUser01.UserPassword);
            newUser02.Validate(newUser02.UserName, newUser02.UserPassword);
            //newUser01.Message(message, "", "");
            newUser01.Exit();
            Console.ReadKey();
        }
    
    }

}
