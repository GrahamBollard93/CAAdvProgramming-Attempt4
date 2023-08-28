using Microsoft.EntityFrameworkCore;
using PhonesApi.Models;
namespace PhonesApi.Data
{
public class PhonesDbContext : DbContext
{
    public PhonesDbContext(DbContextOptions<PhonesDbContext> options) :
base(options)
{}
public DbSet<Phones> Phones { get; set; } = null!;
}
}