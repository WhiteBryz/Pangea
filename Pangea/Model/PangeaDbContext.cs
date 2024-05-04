using Microsoft.EntityFrameworkCore;

namespace Pangea.Model
{
	public class PangeaDbContext : DbContext
	{
		public PangeaDbContext(DbContextOptions<PangeaDbContext> options) : base(options)
		{
		}
		public DbSet<Owner> Owners { get; set; }
	}

}
