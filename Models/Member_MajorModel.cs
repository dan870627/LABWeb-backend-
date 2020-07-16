using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("Member_Major")]
  public class Member_MajorModel
  {
    #region 資料欄位
    //會員編號
    [Key]
    [Required]
    [StringLength(36)]
    public string Member_Id { get; set; }

    //研究領域編號
    [Key]
    [StringLength(10)]
    public string Major_Id { get; set; }
    #endregion

    #region 外來鍵
    [ForeignKey("Member_Id")]
    public virtual MemberModel Member { get; set; }

    [ForeignKey("Major_Id")]
    public virtual MajorModel Major { get; set; }
    #endregion
  }
}