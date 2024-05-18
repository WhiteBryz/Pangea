using Pangea.Model;

namespace Pangea.Repository
{
	public interface IRepositoryIncomeConcept
	{
		Task<List<IncomeConcept>> GetAll();
		Task<IncomeConcept?> Get(int id);
		Task<IncomeConcept> Add(IncomeConcept concept);
		Task Update(int id, IncomeConcept concept);
		Task Delete(int id);
	}
}
