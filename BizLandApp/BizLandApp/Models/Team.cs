using System.ComponentModel.DataAnnotations.Schema;

namespace BizLandApp.Models
{
    public class Team : EntityBase
    {
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }
        public string TwitterLink { get; set; }
        public string FacebookLink { get; set; }
        public string InstagramLink { get; set; }
        public string LinkedinLink { get; set; }
        public string FullName { get; set; }
        public string Work { get; set; }
    }
}
