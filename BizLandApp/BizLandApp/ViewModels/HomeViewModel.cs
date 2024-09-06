using BizLandApp.Models;

namespace BizLandApp.ViewModels
{
    public class HomeViewModel
    {
        public List<About> abouts { get; set; }
        public List<AboutList> aboutlists { get; set; }
        public List<Categories> categories { get; set; }
        public List<Client> clients { get; set; }
        public List<Counters> counters { get; set; }
        public List<HomeHero> homeHeroes { get; set; }
        public List<Product> products { get; set; }
        public List<Pricing> pricings { get; set; }
        public List<Services> services { get; set; }
        public List<Skills> skills { get; set; }
        public List<Testimonials> testimonials { get; set; }
        public List<Team> teams { get; set; }
        public List<SectionHeader> sectionHeaders { get; set; }
        public List<FAQ> faqs { get; set; }
        public List<Contact> contacts { get; set; }
        public List<ContactHead> contacthead { get; set; }
    }
}
