using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
    [Table("Action")]
    public class ActionModel
    {
        [Required]
        public string Action_Id{get;set;}
        public string Action_Name{get;set;}

        public ICollection<PermissionModel> Permission{get;set;}
    }
}