using CmsShoppingCart.Models;
using Microsoft.EntityFrameworkCore;

namespace CmsShoppingCart.Data
{
    public class CmsShoppingCartContext : DbContext
    {
        public CmsShoppingCartContext(DbContextOptions options) : base(options) { }
       

        public DbSet<Page> Pages { get; set; }
    }
    
}
