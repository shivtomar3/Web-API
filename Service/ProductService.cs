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




        public bool AddProduct(ProductDTO product)
        {
            _productRepository.AddProduct(product);
         
            return true;
        }


        public bool UpdateProduct(int id, ProductDTO product)
        {
            _productRepository.PutProduct(id, product);
            return true;
        }



        public List<ProductDTOforID> GetProduct()
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
