
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabWeb.Models.EntityConfiguration
{
  public class TeamEntityConfiguration:IEntityTypeConfiguration<TeamModel>
  {
    public void Configure(EntityTypeBuilder<TeamModel> builder)
    {
      //對應的資料標
      builder.ToTable("Team");

      //Team 一對多 Member
      builder.HasMany(m => m.Members)
             .WithOne(t => t.Team)
             .HasForeignKey(m => m.Member_Id);

      //Team 多對一 GroupName
      builder.HasOne(g => g.GroupName)
             .WithMany(t => t.Teams)
             .HasForeignKey(g => g.Group_Id);
    }
  }
}