using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_EF6_CodeFirst
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            try
            {
                Blog.InsertNewBlog();
                //Blog.ListBlog();

                Post.InsertPost();
                Post.ListPost();
                //ToDo : implementar inserir e listar posts
            }
            catch (Exception)
            {
                //throw;
                Console.WriteLine("Atenção, ocorreu um erro");
            }

            Console.ReadKey();
        }
        
    }
    
}


