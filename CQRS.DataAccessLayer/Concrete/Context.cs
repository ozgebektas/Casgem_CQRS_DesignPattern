using CQRS.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CQRS.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-8JIDE4EC\\SQLEXPRESS;initial catalog=CasgemCQRSDb;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
