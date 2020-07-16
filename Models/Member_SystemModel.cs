using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("Member_System")]
  public class Member_SystemModel
  {
    #region 資料欄位
    //會員編號
    [Key]
    [Required]
    [StringLength(36)]
    public string Member_Id { get; set; }

    //學制名稱編號
    [Key]
    [Required]
    [StringLength(36)]
    public string System_Id { get; set; }
    #endregion

    #region 外來鍵
    [ForeignKey("Member_Id")]
    public virtual MemberModel Member { get; set; }

    [ForeignKey("System_Id")]
    public virtual SystemModel System { get; set; }
    #endregion
  }
}