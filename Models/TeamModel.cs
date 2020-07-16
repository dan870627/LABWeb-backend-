using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("Team")]
  public class TeamModel
  {
    #region 資料欄位
    //組別編號
    [Key]
    [Required]
    [StringLength(36)]
    public string Team_Id { get; set; }

    //會員編號
    [Required]
    [StringLength(36)]
    public string Member_Id { get; set; }

    //組別名稱編號
    [Required]
    [StringLength(36)]
    public string Group_Id { get; set; }
    #endregion

    #region 外來鍵
    [ForeignKey("Member_Id")]
    public virtual ICollection<MemberModel> Members { get; set; }

    [ForeignKey("Group_Id")]
    public virtual GroupNameModel GroupName { get; set; }
    #endregion
  }
}