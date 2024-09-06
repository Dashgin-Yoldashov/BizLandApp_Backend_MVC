using BizLandApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BizLandApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<About> abouts { get; set; }
        public DbSet<AboutList> aboutlists { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<ContactHead> contactheads { get; set; }
        public DbSet<Counters> counters { get; set; }
        public DbSet<HomeHero> homeHeroes { get; set; }
        public DbSet<FAQ> faqs { get; set; }
        public DbSet<Pricing> pricings { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Services> services { get; set; }
        public DbSet<Skills> skills { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<Testimonials> testimonials { get; set; }
        public DbSet<SectionHeader> sectionHeaders { get; set; }
    }
}
