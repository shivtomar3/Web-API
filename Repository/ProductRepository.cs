using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApiWithEfcore.Model;
using WebApiWithEfcore.Service;

namespace WebApiWithEfcore.Repository
{
    public class ProductRepository :DbContext
    {


        private readonly ProductDbContext _context;

        private readonly IMapper _mapper;

        public ProductRepository(ProductDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        
            
            public List<ProductDTO> GetProduct()
            {
            List<ProductEntity> entity = _context.TBL_Products.ToList();

            List<ProductDTO> product = _mapper.Map<List < ProductDTO > >(entity);

            return product;
            }




            public bool PutProduct(int id, ProductDTO product)
            {

            ProductEntity entity = _mapper.Map<ProductEntity>(product);
            entity.UpdatedBy = "admin";
            entity.UpdateOn= DateTime.Now;

            _context.Entry(entity).State = EntityState.Modified;

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

      
        public bool AddProduct(ProductDTO product)
        {

            ProductEntity entity = _mapper.Map<ProductEntity>(product) ;

            entity.CreatedBy = "admin";
            entity.CreatedOn = DateTime.Now;
            entity.UpdateOn = null;
            entity.UpdatedBy = "";



            _context.TBL_Products.Add(entity);
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



