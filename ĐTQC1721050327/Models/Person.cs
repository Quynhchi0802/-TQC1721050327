using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ĐTQC1721050327.Models
{
    [Table("Persons")]
    public class Person
    {
        [key]
        public string PersonID { get; set; }
        public string PersonName { get; set; }
    }
 
}