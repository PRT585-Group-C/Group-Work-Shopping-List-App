using Microsoft.EntityFrameworkCore;
using GroupCWebAPI._DAL.Models;
using GroupCWebAPI.Models;      


namespace GroupCWebAPI._DAL.Services
{
    public class GroupCContext : DbContext
    {
        public GroupCContext(DbContextOptions<GroupCContext> options)
            : base(options)
        {
        }

        public DbSet<NewItem> NewItem { get; set; }

       // public DbSet<MovieViewModel> Category { get; set; }

       // public DbSet<WebApplication1.Models.CategoryViewModel> Category_1 { get; set; }
    }
}
