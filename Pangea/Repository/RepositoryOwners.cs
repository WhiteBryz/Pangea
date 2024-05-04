using System.Data.Entity;
using Pangea.Model;

namespace Pangea.Repository
{
	public class RepositoryOwners : IRepositoryOwners
	{
		private readonly PangeaDbContext _context;
		public RepositoryOwners(PangeaDbContext context)
		{
			_context = context;
		}

		public async Task<Owner> Add(Owner owner)
		{
			await _context.Owners.AddAsync(owner);
			await _context.SaveChangesAsync();
			return owner;
		}

		public async Task Delete(int id)
		{
			var owner = await _context.Owners.FindAsync(id);
			if(owner != null)
			{
				_context.Owners.Remove(owner);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<Owner?> Get(int id)
		{
			return await _context.Owners.FindAsync(id);
		}

		public async Task<List<Owner>> GetAll()
		{
			return await _context.Owners.ToListAsync();
		}

		public async Task Update(int id, Owner owner)
		{
			var actualOwner = await _context.Owners.FindAsync(id);
			if(actualOwner != null)
			{
				actualOwner.HouseNumber = owner.HouseNumber;
				actualOwner.OwnerName = owner.OwnerName;
				actualOwner.OwnerType = owner.OwnerType;
				actualOwner.CellphoneNumber = owner.CellphoneNumber;
				actualOwner.OtherPhoneNumber = owner.OtherPhoneNumber;
				actualOwner.IsActive = owner.IsActive;
				await _context.SaveChangesAsync();
			}
		}
	}
}
