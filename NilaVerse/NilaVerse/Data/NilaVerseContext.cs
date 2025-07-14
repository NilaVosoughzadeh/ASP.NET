using Microsoft.EntityFrameworkCore;
using NilaVerse.Models;

namespace NilaVerse.Data
{
    public class NilaVerseContext : DbContext
    {
        public NilaVerseContext(DbContextOptions<NilaVerseContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
