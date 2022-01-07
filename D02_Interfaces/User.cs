using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_Interfaces
{

    class User : IAuthentication
    {
        
        #region Variables
        string message;
        #endregion
        
        #region Properties
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        #endregion

        #region Methods
        public void Exit()
        {
            message = "A sair";
            Message(message, "\n\n");
        }
        
        public void Message(string message, string startLine = "", string endLine = "")
        {
            Console.Write($"{startLine}{message}{endLine}");
        }

        public bool Validate(string userName, string userPassword)
        {
            //"utilizador for ´xpto´ e pass ´123´ entao mensagem é ok e retorna true"
            //"senão mensagem é ´não OK´ e retorna false
            if (userName == "Gonçalo" && userPassword == "pass12321") 
            {
                message = "OK";
                Message(message, "","\n");
                return true;
            }
            else
            {
                message = "Não OK";
                Message(message,"\n\n");
                return false;
            }
            
        }
        #endregion

        #region Constructors
        public User()
        {
            UserName = string.Empty;
            UserPassword = string.Empty;
        }

        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }
        #endregion
    }

}
