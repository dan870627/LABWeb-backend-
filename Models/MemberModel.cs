using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
    [Table("Members")]
    public class MemberModel
    {
        [Key]
        public string Member_Id { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [StringLength(20)]
        [Required]
        public string Name { get; set; }
        public string Role_Id{get;set;}
        [Phone]
        [StringLength(20)]
        public string Phone { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        [Required]
        public string Address { get; set; }
        //外部關聯
        [ForeignKey("Role_Id")]
        public virtual RoleModel Role{get;set;}
        public ICollection<Member_PmModel>  Permission{get;set;}
    }
}