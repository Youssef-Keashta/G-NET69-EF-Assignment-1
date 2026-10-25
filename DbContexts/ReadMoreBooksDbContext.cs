using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_NET69_EF_Assignment_1.Models;
using Microsoft.EntityFrameworkCore;

namespace G_NET69_EF_Assignment_1.DbContexts
{
    internal class ReadMoreBooksDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = DESKTOP-VGTVSKK;" +
                "Database = ReadMoreBooksDb;" +
                "Trusted_Connection=True;" +
                "TrustServerCertificate = True");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
