using Goshin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Goshin.Database;

public class GoshinContext : DbContext
{
	public GoshinContext(DbContextOptions<GoshinContext> options) : base(options)
	{ }

	public required DbSet<User> Users { get; set; }
}

