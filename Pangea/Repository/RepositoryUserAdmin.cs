using Pangea.Model;
using Microsoft.EntityFrameworkCore;

namespace Pangea.Repository
{
	public class RepositoryUserAdmin : IRepositoryUserAdmin
	{
		private readonly PangeaDbContext _context;

		public RepositoryUserAdmin(PangeaDbContext context)
		{
			_context = context;
		}
		public async Task<UserAdmin> Add(UserAdmin admin)
		{
			await _context.UserAdmins.AddAsync(admin);
			await _context.SaveChangesAsync();
			return admin;
		}

		public async Task Delete(int id)
		{
			var admin = await _context.UserAdmins.FindAsync(id);
			if (admin != null)
			{
				_context.UserAdmins.Remove(admin);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<UserAdmin?> Get(int id)
		{
			return await _context.UserAdmins.FindAsync(id);
		}

		public async Task<List<UserAdmin>> GetAll()
		{
			return await _context.UserAdmins.ToListAsync();
		}

		public async Task Update(int id, UserAdmin admin)
		{
			var actualAdmin = await _context.UserAdmins.FindAsync(id);
			if (actualAdmin != null)
			{
				actualAdmin.AdminName = admin.AdminName;
				actualAdmin.Position = admin.Position;
				actualAdmin.IsActive = admin.IsActive;
				await _context.SaveChangesAsync();
			}
		}
	}
}
