using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
    [Table("Roles")]
    public class RoleModel
    {
        [Required]
        public string Role_Id{get;set;}
        [Required]
        public string Role_Name{get;set;}
        public ICollection<Role_PmModel>  Permission{get;set;}
        public ICollection<MemberModel>  Member{get;set;}
    }
}