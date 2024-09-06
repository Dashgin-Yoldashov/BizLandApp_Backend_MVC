using System.ComponentModel.DataAnnotations;

namespace BizLandApp.Models
{
    public class Contact : EntityBase
    {
        [Required,MaxLength(40)]
        public string Name { get; set; }
        [Required, EmailAddress, MaxLength(40)]
        public string Email { get; set; }
        [Required,MaxLength (50)]
        public string Subject { get; set; }
        [Required,MaxLength (250)]
        public string Message { get; set; }
    }
}
