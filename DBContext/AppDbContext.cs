using System.Data;
using LabWeb.Models;
using LabWeb.Models.EntityConfiguration;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LabWeb.Data
{
  public class AppDbContext : DbContext
  {
    // private IDbConnection connection = null;
    // private SqlCommand command = null;
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }

    public DbSet<ItemModels> Item { get; set; }

    public DbSet<MemberModel> Member { get; set; }
    public DbSet<ActionModel> Action { get; set; }
    public DbSet<FunctionModel> Function { get; set; }
    public DbSet<PermissionModel> Permission { get; set; }
    public DbSet<Role_PmModel> Role_Pm { get; set; }
    public DbSet<Member_PmModel> Member_Pm { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<ItemModels>()
                  .ToTable("Item");

      modelBuilder.ApplyConfiguration(new TeamEntityConfiguration());
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfiguration(new Member_SystemEntityConfiguration());
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfiguration(new Member_MajorEntityConfiguration());
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfiguration(new Member_TechnologyEntityConfiguration());
      base.OnModelCreating(modelBuilder);

      //Member
      modelBuilder.ApplyConfiguration(new MemberEntityConfigration());
      base.OnModelCreating(modelBuilder);
      //Member_Pm
      modelBuilder.ApplyConfiguration(new Member_PmEntityConfigration());
      base.OnModelCreating(modelBuilder);
      //Permission
      modelBuilder.ApplyConfiguration(new PermissionEntityConfigration());
      base.OnModelCreating(modelBuilder);
      //Role_Pm
      modelBuilder.ApplyConfiguration(new Role_PmEntityConfigration());
      base.OnModelCreating(modelBuilder);
    }
    }
  }