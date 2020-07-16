using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabWeb.Models
{
    [Table("Members_Pm")]
    public class Member_PmModel
    {
        [Key]
        [Required]
        public string Member_Id { get; set; }
        [Key]
        [Required]
        public string Permission_Id{get;set;}
        public bool Check{get;set;}
    }
}