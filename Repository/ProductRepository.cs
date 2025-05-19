using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiWithEfcore.Model;
using WebApiWithEfcore.Service;

namespace WebApiWithEfcore.Repository
{
    public class ProductRepository :DbContext
    {


        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }

            
            public List<ProductEntity> GetProduct()
            {
            return _context.TBL_Products.ToList();
            }




            public bool PutProduct(int id, ProductEntity productEntity)
            {
              
                

                _context.Entry(productEntity).State = EntityState.Modified;

                try
                {
                     _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductEntityExists(id))
                    {
                        return true;
                    }
                    else
                    {
                        throw;
                    }
                }

                return true;
            }

      
        public bool AddProduct(ProductEntity product)
        {
            _context.TBL_Products.Add(product);
            _context.SaveChanges();
            return true;
        }

            public  bool DeleteProduct(int id)
            {
                var productEntity =  _context.TBL_Products.Find(id);
                if (productEntity == null)
                {
                    return false;
                }

                _context.TBL_Products.Remove(productEntity);
                 _context.SaveChanges();

                return true;
            }

            private bool ProductEntityExists(int id)
            {
                return _context.TBL_Products.Any(e => e.Id == id);
            }
        }
    }



