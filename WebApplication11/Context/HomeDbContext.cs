using ClassLibrary1.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebApplication11.Context
{
    public class HomeDbContext:DbContext
    {
       public  DbSet<Slider> sliders {get; set; }      
       public  DbSet<About> abouts {get; set; }      
       public  DbSet<Board> boards{get; set; }      
       public  DbSet<Course> courses{get; set; }      
       public  DbSet<Category>  categories{get; set; }      
       public  DbSet<CourseCategory> courseCategories{get; set; }

        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Position>  positions { get; set; }
        public DbSet<Social>  socials{ get; set; }
        public DbSet<Contact>  contacts{ get; set; }


        public HomeDbContext(DbContextOptions<HomeDbContext> options):base(options)
        {

        }
    }
}
