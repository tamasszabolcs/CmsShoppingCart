using Microsoft.EntityFrameworkCore;

namespace CmsShoppingCart.Data
{
    public class CmsShoppingCartContext : DbContext
    {
        public CmsShoppingCartContext(DbContextOptions<CmsShoppingCartContext> options)
        {
            
        }
    }
    
}
