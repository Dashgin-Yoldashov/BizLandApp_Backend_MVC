using System.ComponentModel.DataAnnotations.Schema;

namespace BizLandApp.Models
{
    public class Testimonials : EntityBase
    {
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
        public string Name { get; set; }
        public string Work { get; set; }
        public string Text { get; set; }

    }
}
