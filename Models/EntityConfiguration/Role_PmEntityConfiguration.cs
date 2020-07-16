using LabWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LebWeb.Models.EntityConfiguration
{
    public class Role_PmEntityConfigration : IEntityTypeConfiguration<Role_PmModel>
    {
        public void Configure(EntityTypeBuilder<Role_PmModel> builder)
        {
            builder.ToTable("Role_Pm");//對應資料表的資料結構

            //Role  一對多 Permission
            builder.HasOne(c => c.Role)
                   .WithMany(a => a.Permission)
                   .HasForeignKey(c => c.Role_Id);
            builder.HasOne(c => c.Permission)
                   .WithMany(a => a.Role)
                   .HasForeignKey(c => c.Permission_Id);
        }
    }
}