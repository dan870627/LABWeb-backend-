using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LabWeb.Models.EntityConfiguration
{
  public class FileEntityConfiguration:IEntityTypeConfiguration<FileModel>
  {
    public void Configure(EntityTypeBuilder<FileModel> builder)
    {
      //對應的資料標
      builder.ToTable("File");

      //File 多對一 Proj
//       builder.HasOne(m => m.Proj)
//              .WithMany(f => f.File)
//              .HasForeignKey(m => m.Proj_Id);

//       //File 多對一 Act
//       builder.HasOne(s => s.Act)
//              .WithMany(f => f.File)
//              .HasForeignKey(m => m.Act_Id);

//       //File 多對一 Race
//       builder.HasOne(s => s.Race)
//              .WithMany(f => f.File)
//              .HasForeignKey(m => m.Race_Id);

//       //File 多對一 Forum
//       builder.HasOne(s => s.Forum)
//              .WithMany(f => f.File)
//              .HasForeignKey(m => m.Forum_Id);
    }
  }
}