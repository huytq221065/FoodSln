using System.ComponentModel.DataAnnotations;

namespace Food.Web.Models
{
    public class CategoryModel
    {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Slug { get; set; }
        public int Status { get; set; }
    }
}