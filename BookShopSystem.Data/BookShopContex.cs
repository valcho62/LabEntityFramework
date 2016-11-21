using BookShopSystem.Models;

namespace BookShopSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookShopContex : DbContext
    {
       
        public BookShopContex()
            : base("name=BookShopContex")
        {
        }
        public virtual IDbSet<Author> Author { get; set; }
        public virtual IDbSet<Book> Book { get; set; }
        public virtual IDbSet<Category> Category { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

   
}