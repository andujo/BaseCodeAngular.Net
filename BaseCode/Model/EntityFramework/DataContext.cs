using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.EntityFramework;
public class DataContext : DbContext {
	public DataContext(DbContextOptions<DataContext> options)
		: base(options){}
	public DbSet<Cores> Cores { get; set; } = default!;
}
