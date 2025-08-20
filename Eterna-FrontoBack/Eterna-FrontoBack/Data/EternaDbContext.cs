using Eterna_FrontoBack.Models;
using Microsoft.EntityFrameworkCore;

namespace Eterna_FrontoBack.Data
{
    public class EternaDbContext: DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
    }
}
