using BabyTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BabyTracker.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<BabyEvent> BabyEvents => Set<BabyEvent>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Baby> Babies => Set<Baby>();
}
