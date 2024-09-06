using System.ComponentModel.DataAnnotations.Schema;

namespace BizLandApp.Models
{
    public class About : EntityBase
    {
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string FootText { get; set; }
    }
}
