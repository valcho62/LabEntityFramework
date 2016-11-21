

using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using BookShopSystem.Data;
using BookShopSystem.Data.Migrations;

namespace BookShopSystem.ConsoleClient
{
    class Program
    {
        static void Main()
        {
            
            
            var migrationStrategy = new MigrateDatabaseToLatestVersion<BookShopContex,Configuration>();
            Database.SetInitializer(migrationStrategy);

            BookShopContex contex = new BookShopContex();
            contex.Database.Initialize(true);
            
           // Console.WriteLine(bookCount);
        }
    }
}
