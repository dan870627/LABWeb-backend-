using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("Member_Technology")]
  public class Member_TechnologyModel
  {
    #region 資料欄位
    //會員編號
    [Key]
    [Required]
    [StringLength(36)]
    public string Member_Id { get; set; }

    //技術方向編號
    [Key]
    [StringLength(10)]
    public string TeCHnology_Id { get; set; }
    #endregion

    #region 外來鍵
    [ForeignKey("Member_Id")]
    public virtual MemberModel Member{get;set;}

    [ForeignKey("Technology_Id")]
    public virtual TechnologyModel Technology {get;set;}
    #endregion
  }
}