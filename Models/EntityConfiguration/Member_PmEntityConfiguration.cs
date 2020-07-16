using LabWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LebWeb.Models.EntityConfiguration
{
    public class Member_PmEntityConfigration : IEntityTypeConfiguration<Member_PmModel>
    {
        public void Configure(EntityTypeBuilder<Member_PmModel> builder)
        {
            builder.ToTable("Members_Pm");//對應資料表的資料結構

            //Role  一對多 Permission
            builder.HasOne(c => c.Member)
                   .WithMany(a => a.Permission)
                   .HasForeignKey(c => c.Member_Id);
            //Permission  一對多 Role
            builder.HasOne(c => c.Permission)
                   .WithMany(a => a.Member)
                   .HasForeignKey(c => c.Permission_Id);
        }
    }
}