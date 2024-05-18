using Pangea.Model;

namespace Pangea.Repository
{
	public interface IRepositoryUserAdmin
	{
		Task<List<UserAdmin>> GetAll();
		Task<UserAdmin?> Get(int id);
		Task<UserAdmin> Add(UserAdmin admin);
		Task Update(int id, UserAdmin admin);
		Task Delete(int id);
	}
}
