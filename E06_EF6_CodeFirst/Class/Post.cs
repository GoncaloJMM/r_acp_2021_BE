using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_EF6_CodeFirst
{

    class Post
    {
        #region Properties
        //Scalar properties
        public int PostId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }
        public int BlogId { get; set; }

        //Navigation property
        //1 post pode ter somente 1 blog
        public virtual Blog Blog { get; set; }
        #endregion

        #region Methods
        public static void InsertPost()
        {
            using (var db = new BlogContext())
            {
                string newPost, newContent;

                Post post = new Post();

                Console.WriteLine("Lista de Blogs");
                Blog.ListBlog();

                //2. Pedir ao user p+ara escolher 1 blog, pelo nº

                //3.  Verificar se esse nº de blog existe

                //3.1 se não existir
                //Obrigar o user a escolher 1 nº de blog existente
                //OU
                //Sair e dizer ao user para repetir a operação
                //3.2 Se existir, pedir os outros dados do post e gravar

                Console.Write("Novo Post: ");
                newPost = Console.ReadLine();

                Console.Write("Texto: ");
                newContent = Console.ReadLine();

                post.BlogId = 1;        //Atencao!! Implementar
                post.Title = newPost;
                post.Content = newContent;
                db.Post.Add(post);
                db.SaveChanges();
            }

        }

        public static void ListPost()
        {
            using (var db = new BlogContext())
            {
                var query = db.Post.Select(r => r).OrderBy(r => r.PostId);

                Console.WriteLine("\n\n-----------------------Posts-----------------------\n\n");

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.PostId}: {item.Title}");
                }
                Console.ReadKey();
            }
            #endregion
        }
    }
}
