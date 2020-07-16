
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("File")]
  public class FileModel
  {
    #region 資料欄位
    //檔案編號
    [Key]
    [Required]
    [StringLength(36)]
    public string File_Id { get; set; }

    //檔案名稱
    [Required]
    [StringLength(50)]
    public string File_FileName { get; set; }

    //檔案位置
    [Required]
    [StringLength(200)]
    public string File_FileUrl { get; set; }

    //檔案類型
    [Required]
    [StringLength(30)]
    public string File_FileType { get; set; }

    //研究成果編號
    [StringLength(36)]
    public string Proj_Id { get; set; }

    //活動編號
    [StringLength(37)]
    public string Act_Id { get; set; }

    //競賽資訊編號
    [StringLength(38)]
    public string Race_Id { get; set; }

    //文章編號
    [StringLength(39)]
    public string Forum_Id { get; set; }
    #endregion

    #region 外來鍵
    // [ForeignKey("Proj_Id")]
    // public virtual ProjModel Proj{get;set;}

    // [ForeignKey("Act_id")]
    // public virtual ActModel Act{get;set;}

    // [ForeignKey("Race_Id")]
    // public virtual RaceModel Race{get;set;}

    // [ForeignKey("Forum_Id")]
    // public virtual ForumModel Forum{get;set;}
    #endregion
  }
}