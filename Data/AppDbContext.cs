using Microsoft.EntityFrameworkCore;
using Personel.Models;

namespace Personel.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<PersonelBilgileri> personelBilgileris => Set<PersonelBilgileri>();
}