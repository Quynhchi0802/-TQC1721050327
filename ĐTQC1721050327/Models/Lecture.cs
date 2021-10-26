using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ĐTQC1721050327.Models
{
    [Table("Lectures")]
    public class Lecture:Person
    {
        [StringLength(50)]
        
        public string Faculty { get; set; }
        [StringLength(50)]
        
        public string Department { get; set; }
    }
}