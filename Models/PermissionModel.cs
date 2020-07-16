using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
    [Table("Permission")]
    public class PermissionModel
    {
        [Required]
        public string Permission_Id{get;set;}
        [Required]
        public string Function_Id{get;set;}
        public string Action_Id{get;set;}
        public ICollection<Role_PmModel>  Role{get;set;}

        public ICollection<Member_PmModel>  Member{get;set;}
        [ForeignKey("Function_Id")]
        public virtual FunctionModel Function{get;set;}
        [ForeignKey("Action_Id")]
        public virtual ActionModel Action{get;set;}
    }
}