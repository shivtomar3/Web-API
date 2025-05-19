namespace WebApiWithEfcore.Model
{
    public class ProductEntity
    {

        public int Id{ set;get;}
        public string Name { get; set; }
        public double Price { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { set; get; }

        public string UpdatedBy { set; get; }
 
        public DateTime UpdateOn { set; get; }

    }
    
    
    
    }

