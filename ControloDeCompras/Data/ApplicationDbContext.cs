using ControloDeCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace ControloDeCompras.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ShoppingList> ShoppingLists { get; set; }
    }
}
