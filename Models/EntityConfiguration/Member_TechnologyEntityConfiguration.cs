using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabWeb.Models.EntityConfiguration
{
  public class Member_TechnologyEntityConfiguration:IEntityTypeConfiguration<Member_TechnologyModel>
  {
    public void Configure(EntityTypeBuilder<Member_TechnologyModel> builder)
    {
      //對應的資料標
      builder.ToTable("Member_Technology");

      //Member_Technology 多對一 Member
      builder.HasOne(m => m.Member)
             .WithMany(mt => mt.MemberTechnology)
             .HasForeignKey(m => m.Member_Id);

      //Member_Technology 多對一 System
      builder.HasOne(t => t.Technology)
             .WithMany(mt => mt.MemberTechnology)
             .HasForeignKey(t => t.TeCHnology_Id);
    }
  }
}