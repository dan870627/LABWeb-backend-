using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
    [Table("Function")]
    public class FunctionModel
    {
        [Required]
        public string Function_Id{get;set;}
        public string Function_Name{get;set;}

       public ICollection<PermissionModel> Permission{get;set;}
    }
}