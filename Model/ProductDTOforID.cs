using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.ComponentModel.DataAnnotations;

namespace WebApiWithEfcore.Model
{
    public class ProductDTOforID
    {


        [Key]
        public int Id { get; set; }

        public string Name { get; set;}
        public double Price { set; get; }
    }
}
