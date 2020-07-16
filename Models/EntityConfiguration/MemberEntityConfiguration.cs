using LabWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LebWeb.Models.EntityConfiguration
{
    // public class MemberEntityConfigration : IEntityTypeConfiguration<MemberModel>
    // {
        // public void Configure(EntityTypeBuilder<MemberModel> builder)
        // {
        //     builder.ToTable("Member");//對應資料表的資料結構

            //Role  一對多 Permission
            // builder.HasOne(c => c.Function)
            //        .WithMany(a => a.Permission)
            //        .HasForeignKey(c => c.Function_Id);
            // builder.HasOne(c => c.Action)
            //        .WithMany(a => a.Permission)
            //        .HasForeignKey(c => c.Action_Id);
    //     }
    // }
}