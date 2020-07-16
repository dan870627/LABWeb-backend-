using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("Major")]
  public class MajorModel
  {
    #region 資料欄位
    //研究領域編號
    [Key]
    [Required]
    [StringLength(10)]
    public string Mojor_Id { get; set; }

    //研究領域內容
    [Required]
    [StringLength(10)]
    public string Major_Name { get; set; }
    #endregion

    #region 外部關聯
    public virtual ICollection<Member_MajorModel> MemberMajors { get; set; }
    #endregion
  }
}