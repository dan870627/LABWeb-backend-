using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("GroupName")]
  public class GroupNameModel
  {
    #region 資料欄位
    //組別名稱編號
    [Key]
    [Required]
    [StringLength(36)]
    public string GroupName_id { get; set; }

    //組別名稱
    [Required]
    [StringLength(30)]
    public string GroupName { get; set; }
    #endregion

    #region 外部關聯
    public virtual ICollection<TeamModel> Teams { get; set; }
    #endregion
  }
}