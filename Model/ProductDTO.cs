using System.ComponentModel.DataAnnotations;

namespace WebApiWithEfcore.Model
{
    public class ProductDTO
    {
      //  [Key]
     //  public int Id { get; set; }
        public string Name { set; get; }
        public double Price { get; set; }


    }
}
