using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication6.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
        [NotMapped]
        public IFormFile ImgFile { get; set; }
    
    }
}
