using LabWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LebWeb.Models.EntityConfiguration
{
    public class PermissionEntityConfigration : IEntityTypeConfiguration<PermissionModel>
    {
        public void Configure(EntityTypeBuilder<PermissionModel> builder)
        {
            builder.ToTable("Permission");//對應資料表的資料結構

            //Function  一對多 Permission
            builder.HasOne(c => c.Function)
                   .WithMany(a => a.Permission)
                   .HasForeignKey(c => c.Function_Id);
            //Action  一對多 Permission
            builder.HasOne(c => c.Action)
                   .WithMany(a => a.Permission)
                   .HasForeignKey(c => c.Action_Id);
        }
    }
}