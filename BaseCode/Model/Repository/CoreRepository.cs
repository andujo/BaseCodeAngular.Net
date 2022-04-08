using Model.Entities;
using Microsoft.EntityFrameworkCore;
using Model.EntityFramework;

namespace Model.Repository;
	public interface ICoreRepository
	{
		Task<Cores> GetCore(int id);
	}

	public class CoreRepository : ICoreRepository
	{
		private readonly DataContext _context;

		public CoreRepository(DataContext context)
		{
			_context = context;
		}
    	public async Task<Cores> GetCore(int id)
		{
			var core = new Cores();
			try
			{
				core = await _context.Cores.FirstAsync(p => p.Id == id);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return core;
		}
	}