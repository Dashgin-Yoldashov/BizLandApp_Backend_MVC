using BerilliumApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BerilliumApp.DAL
{
	public class HomeDbContext : DbContext
	{
        public HomeDbContext(DbContextOptions<HomeDbContext> options):base(options)
        {}

        public DbSet<Location> Locations { get; set; }
        public DbSet<Corusel> Corusels { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Section> Sections { get; set; }
	}
}
