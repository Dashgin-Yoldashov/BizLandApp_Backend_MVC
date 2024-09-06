namespace BerilliumApp.Models
{
    public class News: BaseEntity
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
