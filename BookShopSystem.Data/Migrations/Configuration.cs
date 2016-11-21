using System.Globalization;
using System.IO;
using BookShopSystem.Models;

namespace BookShopSystem.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<BookShopSystem.Data.BookShopContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BookShopSystem.Data.BookShopContex";
        }

        protected override void Seed(BookShopSystem.Data.BookShopContex context)
        {

            BookShopContex contex = new BookShopContex();
            var Count = contex.Category.Count();
            Random random = new Random();

            var allBooks = contex.Book.Select(x => x);
            foreach (var book in allBooks)
            {
                var rand = random.Next(0, Count);
                Category cat = contex.Category.Where(i => i.Id == @rand).FirstOrDefault();
                cat.Book.Add(book);
                book.CategoryId.Add(cat);
                contex.SaveChanges();
            }

            //    using (var reader = new StreamReader("books.txt"))
            //    {
            //        var line = reader.ReadLine();
            //         line = reader.ReadLine();
            //        while (line != null)
            //        {
            //            var data = line.Split(new []{' '},6);
            //            var authorIndex = random.Next(0, contex.Author.Count());
            //            var author = contex.Author.Where(x => x.Id == authorIndex).FirstOrDefault();
            //            var edition = (EditionT) int.Parse(data[0]);
            //            var releaseDate = DateTime.ParseExact(data[1], "d/M/yyyy", CultureInfo.InvariantCulture);
            //            var copies = int.Parse(data[2]);
            //            var price = decimal.Parse(data[3]);
            //            var ageRestriction = (AgeRestriction)int.Parse(data[4]);
            //            var title = data[5];

            //            contex.Book.AddOrUpdate(new Book()
            //            {
            //                EditionType = edition,
            //        ReleaseDate = releaseDate,
            //        Copies = copies,
            //        Price = price,
            //        Agerestriction = ageRestriction,
            //        Title = title,
            //        Author = author
            //            });
            //            line = reader.ReadLine();
            //            contex.SaveChanges();
            //        }

            //}
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
