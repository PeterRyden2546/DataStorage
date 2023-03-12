using LandLord.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LandLord.Contexts;

internal class DataContext : DbContext
{
    private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Peter\Desktop\webbutveckling_inom_.net\Datalagring\Hans\DataStorage\LandLord\Contexts\landlord_db.mdf;Integrated Security=True;Connect Timeout=30";

    #region constructors

    public DataContext()
    {

    }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    #endregion

    #region overrides

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(_connectionString);
    }

    #endregion

    #region entities

    public DbSet<ApartmentEntity> Apartments { get; set; } = null!;
    public DbSet<CommentEntity> Comments { get; set; } = null!;
    public DbSet<EmployeEntity> Employees { get; set; } = null!;
    public DbSet<OrderEntity> Orders { get; set; } = null!;
    public DbSet<OrderRowEntity> OrderRows { get; set; } = null!;
    public DbSet<RoleEntity> Roles { get; set; } = null!;
    public DbSet<TenantEntity> Tenants { get; set; } = null!;


    #endregion
}
