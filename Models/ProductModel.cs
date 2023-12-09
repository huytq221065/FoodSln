using System.ComponentModel.DataAnnotations;

namespace Food.Web.Models
{
    public class ProductModel
    {
        [Key]
        public Int64 ID { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Slug{get;set;}
        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public string Image{get;set;}
    }
}