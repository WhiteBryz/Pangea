using Pangea.Model;

namespace Pangea.Repository
{
	public interface IRepositoryOwners
	{
		Task<List<Owner>> GetAll();
		Task<Owner?> Get(int id);
		Task<Owner> Add(Owner owner);
		Task Update(int id, Owner owner);
		Task Delete(int id);
		Task<Owner?> GetOwnersByHouseNumber(int id);
	}
}
