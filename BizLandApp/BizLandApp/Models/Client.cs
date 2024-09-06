using System.ComponentModel.DataAnnotations.Schema;

namespace BizLandApp.Models
{
    public class Client : EntityBase
    {
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img {  get; set; }
    }
}
