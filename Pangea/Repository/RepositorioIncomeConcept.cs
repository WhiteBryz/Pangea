using Pangea.Model;
using Microsoft.EntityFrameworkCore;

namespace Pangea.Repository
{
	public class RepositorioIncomeConcept : IRepositoryIncomeConcept
	{
		private readonly PangeaDbContext _context;
		public RepositorioIncomeConcept(PangeaDbContext context)
		{
			_context = context;
		}

		public async Task<IncomeConcept> Add(IncomeConcept concept)
		{
			await _context.IncomeConcepts.AddAsync(concept);
			await _context.SaveChangesAsync();
			return concept;
		}

		public async Task Delete(int id)
		{
			var concept = await _context.IncomeConcepts.FindAsync(id);
			if (concept != null)
			{
				_context.IncomeConcepts.Remove(concept);
				await _context.SaveChangesAsync();
			}
		}

		public async Task<IncomeConcept?> Get(int id)
		{
			return await _context.IncomeConcepts.FindAsync(id);
		}

		public async Task<List<IncomeConcept>> GetAll()
		{
			return await _context.IncomeConcepts.ToListAsync();
		}

		public async Task Update(int id, IncomeConcept concept)
		{
			var actualConcept = await _context.IncomeConcepts.FindAsync(id);
			if (actualConcept != null)
			{
				actualConcept.Concept = concept.Concept;
				await _context.SaveChangesAsync();
			}
		}
	}
}
