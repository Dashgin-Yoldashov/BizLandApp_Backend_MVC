namespace BizLandApp.Models
{
    public class Categories : EntityBase
    {
        public string Name { get; set; }
        public string FilterName { get; set; }
        public List<Product> Products { get; set; }
}
}
