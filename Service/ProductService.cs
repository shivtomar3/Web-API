using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;
using System.Security.Claims;
using WebApiWithEfcore.Model;
using WebApiWithEfcore.Repository;

namespace WebApiWithEfcore.Service
{
    public class ProductService { 
          

    


      private ProductRepository _productRepository;


    public  ProductService(ProductRepository productRepository)
    {
            _productRepository = productRepository;
    }




        public bool AddProduct(ProductEntity productEntity)
        {
            _productRepository.AddProduct(productEntity);
         
            return true;
        }


        public bool UpdateProduct(int id, ProductEntity productEntity)
        {
            _productRepository.PutProduct(id, productEntity);
            return true;
        }



        public List<ProductEntity> GetProduct()
        {

            var Product = _productRepository.GetProduct();
           

            return Product;

        }

        public bool DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id); 
            
            return true;

        }
    }
}
