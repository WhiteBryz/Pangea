using Pangea.Model;

namespace Pangea.Repository
{
	public interface IRepositoryIncome
	{
		Task<List<Income>> GetAll();
		Task<Income?> Get(int id);
		Task<Income> Add(Income income);
		Task Update(int id, Income income);
		Task Delete(int id);
	}
}
