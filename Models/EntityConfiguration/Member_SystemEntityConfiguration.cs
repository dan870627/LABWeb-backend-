using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabWeb.Models.EntityConfiguration
{
  public class Member_SystemEntityConfiguration:IEntityTypeConfiguration<Member_SystemModel>
  {
    public void Configure(EntityTypeBuilder<Member_SystemModel> builder)
    {
      //對應的資料標
      builder.ToTable("Member_System");

      //Member_System 多對一 Member
      builder.HasOne(m => m.Member)
             .WithMany(ms => ms.MemberSystems)
             .HasForeignKey(m => m.Member_Id);

      //Member_System 多對一 System
      builder.HasOne(s => s.System)
             .WithMany(ms => ms.MemberSystems)
             .HasForeignKey(s => s.System_Id);
    }
  }
}