using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("Technology")]
  public class TechnologyModel
  {
    #region 資料欄位
    //技術方向編號
    [Key]
    [Required]
    [StringLength(10)]
    public string Tochnology_Id { get; set; }

    //技術方向內容
    [Required]
    [StringLength(100)]
    public string Technology_Name { get; set; }
    #endregion

    #region 外部關聯
    public virtual ICollection<Member_TechnologyModel> MemberTechnology { get; set; }
    #endregion
  }
}