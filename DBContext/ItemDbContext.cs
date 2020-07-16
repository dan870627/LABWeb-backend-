using System.Data;
using LabWeb.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LabWeb.Data
{
  public class ItemDbContext : DbContext
  {
    // private IDbConnection connection = null;
    // private SqlCommand command = null;
    public ItemDbContext(DbContextOptions<ItemDbContext> options) : base(options)
    { }

    public DbSet<ItemModels> Item { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<ItemModels>()
                  .ToTable("Item");

    }
  }
}