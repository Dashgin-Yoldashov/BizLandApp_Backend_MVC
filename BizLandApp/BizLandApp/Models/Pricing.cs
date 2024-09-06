namespace BizLandApp.Models
{
    public class Pricing : EntityBase
    {
        public string Status { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string BuyLink { get; set; }
    }
}
