using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiWithEfcore.Service;

namespace WebApiWithEfcore.Model
{
    public class ProductDbContext : DbContext
    {
      public   DbSet<ProductEntity> TBL_Products { set; get; }


        public ProductDbContext(DbContextOptions<ProductDbContext>options) : base(options)
        {


        }

    }
}
