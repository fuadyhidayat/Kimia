using Microsoft.EntityFrameworkCore;
using Kimia.BackEnd.Entities;

namespace Kimia.BackEnd
{
    public class ChemistryDbContext : DbContext
    {
        public DbSet<Element> Elements => Set<Element>();

        public ChemistryDbContext(DbContextOptions<ChemistryDbContext> options) : base(options)
        {
        }
    }
}
