using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
  [Table("System")]
  public class SystemModel
  {
    #region 資料欄位
    //學制名稱編號
    [Key]
    [Required]
    [StringLength(36)]
    public string System_Id { get; set; }

    //學制名稱
    [Required]
    [StringLength(30)]
    public string System_Name { get; set; }
    #endregion

    #region 外部關聯
    public virtual ICollection<Member_SystemModel> MemberSystems { get; set; }
    #endregion
  }
}