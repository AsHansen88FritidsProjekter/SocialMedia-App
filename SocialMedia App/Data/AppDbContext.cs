using Microsoft.EntityFrameworkCore;

namespace SocialMedia_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        }
        
}
    }

