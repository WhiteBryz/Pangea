using Pangea.Model;
using Microsoft.EntityFrameworkCore;

namespace Pangea.Repository
{
		public class RepositoryIncome : IRepositoryIncome
		{
			private readonly PangeaDbContext _context;
			public RepositoryIncome(PangeaDbContext context)
			{
				_context = context;
			}
			public async Task<Income> Add(Income income)
			{
				await _context.Incomes.AddAsync(income);
				await _context.SaveChangesAsync();
				return income;
			}

			public async Task Delete(int id)
			{
				var income = await _context.Incomes.FindAsync(id);
				if (income != null)
				{
					_context.Incomes.Remove(income);
					await _context.SaveChangesAsync();
				}
			}

			public async Task<Income?> Get(int id)
			{
				return await _context.Incomes.FindAsync(id);
			}

			public async Task<List<Income>> GetAll()
			{
				return await _context.Incomes
										.Include(u => u.UserAdmin)
										.Include(o => o.Owner)
										.Include(ic => ic.IncomeConcept)
										.ToListAsync();
			}

			public async Task Update(int id, Income income)
			{
				var actualIncome = await _context.Incomes.FindAsync(id);
				if (actualIncome != null)
				{
					actualIncome.RegisterDate = income.RegisterDate;
					actualIncome.PaidDate = income.PaidDate;
					actualIncome.UserAdminId = income.UserAdminId;
					actualIncome.ApplicableMonth = income.ApplicableMonth;
					actualIncome.ApplicableYear = income.ApplicableYear;
					actualIncome.OrderNum = income.OrderNum;
					actualIncome.PaidMethod = income.PaidMethod;
					actualIncome.OwnerId = income.OwnerId;
					actualIncome.IncomeConceptId = income.IncomeConceptId;
					actualIncome.Amount = income.Amount;
					actualIncome.PaidStatus = income.PaidStatus;
					actualIncome.Comments = income.Comments;
					await _context.SaveChangesAsync();
				}
			}
		}
}
