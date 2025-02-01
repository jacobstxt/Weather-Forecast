using DLL.Constants;
using DLL.DataModels;
using Microsoft.EntityFrameworkCore;

public class WeatherDBContext : DbContext
{
    public DbSet<WeatherEntity> Weather { get; set; }
    public DbSet<UserEntity> User { get; set; }

    public WeatherDBContext(DbContextOptions<WeatherDBContext> options) : base(options)
    {
    }

    public WeatherDBContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(AppDatabase.ConnectionString); 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<WeatherEntity>().ToTable("tbl_weather");
        modelBuilder.Entity<UserEntity>().ToTable("tbl_users");
    }
}
