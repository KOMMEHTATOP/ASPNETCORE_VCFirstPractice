using Microsoft.EntityFrameworkCore;
using VCFirstPractice.Models;

namespace VCFirstPractice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<BooksModel> Books { get; set; }
    }

}
