using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabWeb.Models.EntityConfiguration
{
  public class Member_MajorEntityConfiguration:IEntityTypeConfiguration<Member_MajorModel>
  {
    public void Configure(EntityTypeBuilder<Member_MajorModel> builder)
    {
      //對應的資料標
      builder.ToTable("Member_Major");

      //Member_Major 多對一 Member
      builder.HasOne(m => m.Member)
             .WithMany(mm => mm.MemberMajors)
             .HasForeignKey(m => m.Member_Id);

      //Member_Major 多對一 Major
      builder.HasOne(s => s.Major)
             .WithMany(mm => mm.MemberMajors)
             .HasForeignKey(m => m.Major_Id);
    }
  }
}