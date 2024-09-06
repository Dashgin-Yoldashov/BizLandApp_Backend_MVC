using System.ComponentModel.DataAnnotations;

namespace BerilliumApp.Models
{
	public class Corusel : BaseEntity
	{
		[Required]
		public string Image { get; set; }
        [Required,MaxLength(50)]
        public string Architecture { get; set; }

        internal void ExecuteDelete()
        {
            throw new NotImplementedException();
        }
    }
}
