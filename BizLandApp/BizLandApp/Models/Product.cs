using System.ComponentModel.DataAnnotations.Schema;

namespace BizLandApp.Models
{
    public class Product : EntityBase
    {
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
        public string FilterName { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
        public string DetailsLink { get; set; }
        public string TextNum { get; set; }
    }
}
