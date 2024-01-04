using Microsoft.EntityFrameworkCore;
using Yeli_il_Mvc.Models;

namespace Yeli_il_Mvc.DAL
{
    public class AppDbContext:DbContext
    {
      
        public AppDbContext(DbContextOptions<AppDbContext> options): base (options){}


        public DbSet<Slide> Slides { get; set; }
    }
}
