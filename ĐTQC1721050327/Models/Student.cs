using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ĐTQC1721050327.Models
{
    [Table("Students")]
    public class Student : Person
    {
        [key]
        public string Univercity { get; set; }
        public string Address { get; set; }
    }
}