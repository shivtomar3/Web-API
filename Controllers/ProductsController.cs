using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiWithEfcore.Model;
using WebApiWithEfcore.Service;

namespace WebApiWithEfcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

       private  ProductService _productService;



      public  ProductsController(ProductService productService)

        {

            _productService = productService;
        }



        // GET: api/ProductEntities
        [HttpGet("Get_All_Product")]
        public  List<ProductDTO> GetTBL_Products()
        {
            var Product= _productService.GetProduct();

            return Product;
        }

        
 
       

        [HttpPut("Update_Product")]
        public IActionResult UpdateProduct(int id, ProductDTO Product)
        {


            var product = _productService.UpdateProduct(id, Product);
           
            

            return Ok();
        }

        [HttpPost("Add_Product")]
        public ActionResult AddProduct(ProductDTO product)
        {
            _productService.AddProduct(product);
            return Ok();
        }







        // DELETE: api/ProductEntities/5
        [HttpDelete("Delete_a_product")]
        public IActionResult DeleteProductEntity(int id)
        {
            var productEntity = _productService.DeleteProduct(id);
            if (productEntity == false)
            {
                return NotFound();
            }
     
            return NoContent();
        }

     
    }
}
