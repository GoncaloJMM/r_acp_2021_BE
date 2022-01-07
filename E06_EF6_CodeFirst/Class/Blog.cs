using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_EF6_CodeFirst
{
    
    class Blog
    {
        #region Properties
        //Scalar properties
        public int BlogId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        //Navigation property
        // 1 blog ter uma lista(n) de posts
        public virtual List<Post> Posts { get; set; }
        #endregion

        #region Methods
        public static void InsertNewBlog()
        {
            using (var db = new BlogContext())
            {
                //Create and save a new Blog
                Console.Write("Nome do novo Blog: ");
                var name = Console.ReadLine();
                var blog = new Blog();
                blog.Name = name;
            
                db.Blog.Add(blog);
                db.SaveChanges();
            }
        }
        public static void ListBlog()
        {
            using (var db = new BlogContext())
            {
                var query = db.Blog.Select(r => r).OrderBy(r => r.BlogId);
                
                Console.WriteLine("\n\n-----------------------Blogs-----------------------\n\n");

                foreach (var item in query)
                {
                    Console.WriteLine($"{item.BlogId}: {item.Name}");
                }
                Console.ReadKey();
            }
        }
        #endregion



    }

}
