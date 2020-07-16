using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
    [Table("Roles_Pm")]
    public class Role_PmModel
    {
        [Key]
        [Required]
        public string Role_Id{get;set;}
        [Key]
        [Required]
        public string Permission_Id{get;set;}

        public virtual RoleModel Role{get;set;}

        public virtual PermissionModel Permission{get;set;}

    }
}